using System;
using System.Data;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using ClosedXML.Excel;
using Microsoft.ML;
using System.Collections.Generic;
using Ozone.Models;
using Microsoft.ML.Transforms.Image;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net.Http;

namespace Ozone
{
    public partial class Form1 : Form
    {
        public const int rowCount = 13, columnCount = 13;
        public const int featuresPerBox = 5;
        private static readonly (float x, float y)[] boxAnchors = { (0.573f, 0.677f), (1.87f, 2.06f), (3.34f, 5.47f), (7.88f, 3.53f), (9.77f, 9.17f) };
        private PredictionEngine<TbInput, TBPredictions> _predictionEngine;
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer speak = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            //diagnoseThroughSymptoms();
            var context = new MLContext();
            var emptyData = new List<TbInput>();
            var data = context.Data.LoadFromEnumerable(emptyData);
            var pipeline = context.Transforms.ResizeImages(resizing: ImageResizingEstimator.ResizingKind.Fill, outputColumnName: "data", imageWidth: ImageSettings.imageWidth, imageHeight: ImageSettings.imageHeight, inputColumnName: nameof(TbInput.Image))
                            .Append(context.Transforms.ExtractPixels(outputColumnName: "data"))
                            .Append(context.Transforms.ApplyOnnxModel(modelFile: "./MLModel/model.onnx", outputColumnName: "model_outputs0", inputColumnName: "data"));

            var model = pipeline.Fit(data);
            _predictionEngine = context.Model.CreatePredictionEngine<TbInput, TBPredictions>(model);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPatientList();
            speak.SelectVoiceByHints(VoiceGender.Male);
            Choices commands = new Choices();
            commands.Add(new string[] { "pull up latest patient", "diagnose patient", "what are my next steps" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recognizer.LoadGrammarAsync(grammar);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += recognizer_SpeechRecognized;
            recognizer.RecognizeAsync(RecognizeMode.Multiple);

        }
        private void LoadPatientList()
        {
            cbPatient.Items.Add("Adam Hill");
            cbPatient.Items.Add("Bill Sanchez");
            cbPatient.Items.Add("Joe Smith");
            cbPatient.Items.Add("Steve Buckner");
            cbPatient.Items.Add("Patty Hill");
            cbPatient.Items.Add("Howard Smith");

        }
        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            CommandOutput.Text += e.Result.Text + "\n";
            switch (e.Result.Text)
            {
                //case "pull up latest patient" :
                    //speak.SpeakAsync("here is your latest patient");
                    //openClient();
                    //break;
                case "diagnose patient":
                    speak.SpeakAsync("Here is the diagnosis");
                    diagnosePatientImage();
                    break;
                case "what are my next steps":
                    speak.SpeakAsync("Heres what you should do next");
                    break;
                default:
                    break;
            }
        }
        private void openClient()
        {
            try
            {
                String firstSubDir = "";
                /*String filePath = "./Patients/";
                string[] subDirectories = System.IO.Directory.GetDirectories(filePath);
                if (subDirectories.Length > 0)
                {
                    firstSubDir = subDirectories[0] + @"\Data.xlsx";
                }*/
                firstSubDir = "./Patients/Phantom-Danny/Data.xlsx";
                //Using code snippet for ClosedXML file
                using (XLWorkbook workBook = new XLWorkbook(firstSubDir))
                {
                    IXLWorksheet workSheet = workBook.Worksheet(1);
                    DataTable dt = new DataTable();
                    bool firstRow = true;
                    foreach (IXLRow row in workSheet.Rows())
                    {
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }
                    }
                }
                patientImages.ImageLocation = returnImage();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: " + e.ToString());
            }
        }
        private string returnImage()
        {
            String firstSubDirImage = "";
            /*String filePath = @"C:\Shashank\Projects\Ozone\";
            string[] subDirectories = System.IO.Directory.GetDirectories(filePath);
            if (subDirectories.Length > 0)
            {
                firstSubDirImage = subDirectories[0] + @"\xRay.png";
            }*/
            int itemnum = this.cbPatient.SelectedIndex;
            firstSubDirImage = @"C:\Users\shash\source\repos\Ozone\Ozone\Images\TB_" +
                itemnum+".jpg";
            return firstSubDirImage;
        }
        private void diagnosePatientImage()
        {
            var image = (Bitmap) Image.FromFile(returnImage());
            var prediction = _predictionEngine.Predict(new TbInput { Image = image});
            var labels = File.ReadAllLines("./MLModel/Labels.txt");

            var boundingBoxes = ParseOutputs(prediction.TbType, labels);
            var originalWidth = image.Width;
            var originalHeight = image.Height;
            if (boundingBoxes.Count > 1)
            {
                var maxConfidence = boundingBoxes.Max(b => b.Confidence);
                var topBoundingBox = boundingBoxes.FirstOrDefault(b => b.Confidence == maxConfidence);

                boundingBoxes.Clear();

                boundingBoxes.Add(topBoundingBox);
            }
            else
            {
                MessageBox.Show("No prediction for image");
                return;
            }

            foreach (var boundingBox in boundingBoxes)
            {
                float x = Math.Max(boundingBox.Dimensions.X, 0);
                float y = Math.Max(boundingBox.Dimensions.Y, 0);
                float width = Math.Min(originalWidth - x, boundingBox.Dimensions.Width);
                float height = Math.Min(originalHeight - y, boundingBox.Dimensions.Height);

                // fit to current image size
                x = originalWidth * x / ImageSettings.imageWidth;
                y = originalHeight * y / ImageSettings.imageHeight;
                width = originalWidth * width / ImageSettings.imageWidth;
                height = originalHeight * height / ImageSettings.imageHeight;

                using (var graphics = Graphics.FromImage(image))
                {
                    graphics.DrawRectangle(new Pen(Color.Red, 3), x, y, width, height);
                    graphics.DrawString(boundingBox.Description, new Font(FontFamily.Families[0], 30f), Brushes.Red, x + 5, y + 5);
                    speak.SpeakAsync("Here are the stats: " + boundingBox.Description + " certain");

                }
            }
            patientImages.Image = image;
            patientImages.SizeMode = PictureBoxSizeMode.AutoSize;

        }
        private async void diagnoseThroughSymptoms()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://priaid-symptom-checker-v1.p.rapidapi.com/symptoms?language=en-gb&format=json&symptomId=17"),
                Headers =
                {
                    { "x-rapidapi-key", "f99426b33amsh6bfb78ee98deddcp19c11ajsn0c723fed2e5f" },
                    { "x-rapidapi-host", "priaid-symptom-checker-v1.p.rapidapi.com" },
                },
                };  
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                CommandOutput.Text += body;
            }

        }
        //Accessor/Helper methods listed below(Thanks microsoft!)
        public static List<BoundingBox> ParseOutputs(float[] modelOutput, string[] labels, float probabilityThreshold = .5f)
        {
            var boxes = new List<BoundingBox>();

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    for (int box = 0; box < boxAnchors.Length; box++)
                    {
                        var channel = box * (labels.Length + featuresPerBox);

                        var boundingBoxPrediction = ExtractBoundingBoxPrediction(modelOutput, row, column, channel);

                        var mappedBoundingBox = MapBoundingBoxToCell(row, column, box, boundingBoxPrediction);

                        if (boundingBoxPrediction.Confidence < probabilityThreshold)
                            continue;

                        float[] classProbabilities = ExtractClassProbabilities(modelOutput, row, column, channel, boundingBoxPrediction.Confidence, labels);

                        var (topProbability, topIndex) = classProbabilities.Select((probability, index) => (Score: probability, Index: index)).Max();

                        if (topProbability < probabilityThreshold)
                            continue;

                        boxes.Add(new BoundingBox
                        {
                            Dimensions = mappedBoundingBox,
                            Confidence = topProbability,
                            Label = labels[topIndex]
                        });
                    }
                }
            }

            return boxes;
        }

        private static BoundingBoxDimensions MapBoundingBoxToCell(int row, int column, int box, BoundingBoxPrediction boxDimensions)
        {
            const float cellWidth = ImageSettings.imageWidth / columnCount;
            const float cellHeight = ImageSettings.imageHeight / rowCount;

            var mappedBox = new BoundingBoxDimensions
            {
                X = (row + Sigmoid(boxDimensions.X)) * cellWidth,
                Y = (column + Sigmoid(boxDimensions.Y)) * cellHeight,
                Width = (float)Math.Exp(boxDimensions.Width) * cellWidth * boxAnchors[box].x,
                Height = (float)Math.Exp(boxDimensions.Height) * cellHeight * boxAnchors[box].y,
            };

            // The x,y coordinates from the (mapped) bounding box prediction represent the center
            // of the bounding box. We adjust them here to represent the top left corner.
            mappedBox.X -= mappedBox.Width / 2;
            mappedBox.Y -= mappedBox.Height / 2;

            return mappedBox;
        }

        private static BoundingBoxPrediction ExtractBoundingBoxPrediction(float[] modelOutput, int row, int column, int channel)
        {
            return new BoundingBoxPrediction
            {
                X = modelOutput[GetOffset(row, column, channel++)],
                Y = modelOutput[GetOffset(row, column, channel++)],
                Width = modelOutput[GetOffset(row, column, channel++)],
                Height = modelOutput[GetOffset(row, column, channel++)],
                Confidence = Sigmoid(modelOutput[GetOffset(row, column, channel++)])
            };
        }

        public static float[] ExtractClassProbabilities(float[] modelOutput, int row, int column, int channel, float confidence, string[] labels)
        {
            var classProbabilitiesOffset = channel + featuresPerBox;
            float[] classProbabilities = new float[labels.Length];
            for (int classProbability = 0; classProbability < labels.Length; classProbability++)
                classProbabilities[classProbability] = modelOutput[GetOffset(row, column, classProbability + classProbabilitiesOffset)];
            return Softmax(classProbabilities).Select(p => p * confidence).ToArray();
        }

        private static float Sigmoid(float value)
        {
            var k = (float)Math.Exp(value);
            return k / (1.0f + k);
        }

        private static float[] Softmax(float[] classProbabilities)
        {
            var max = classProbabilities.Max();
            var exp = classProbabilities.Select(v => Math.Exp(v - max));
            var sum = exp.Sum();
            return exp.Select(v => (float)v / (float)sum).ToArray();
        }

        private static int GetOffset(int row, int column, int channel)
        {
            const int channelStride = rowCount * columnCount;
            return (channel * channelStride) + (column * columnCount) + row;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        class BoundingBoxPrediction : BoundingBoxDimensions
        {
            public float Confidence { get; set; }
        }
        private void cbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.Items.Clear();
            MessageBox.Show(cbPatient.SelectedItem.ToString() + " has been selected!");
            String s = cbPatient.SelectedItem.ToString();
            string[] subs = s.Split(' ');

            Patient p = ReadPatientInfo(subs[0], subs[1]);
            tbFN.Text = p.FirstName;
            tbLN.Text = p.LastName;
            tbAge.Text = p.Age;
            tbDOB.Text = p.DOB;
            tbAge.Text = p.Age;
            tBSN.Text = p.Street;
            tbCity.Text = p.City;
            tbZip.Text = p.Zip;
            tbGender.Text = p.Gender;
            tbHomePhone.Text = p.HomePhone;
            tbWorkPhone.Text = p.WorkPhone;
            tbEmployer.Text = p.Employer;
            tbMaritalStatus.Text = p.MaritalStatus;
            tbEmerContName.Text = p.EmerContactName;
            tbEmerContactNum.Text = p.EmerContactPhNumber;
            tbLastScreenDate.Text = p.LastSCreenDate;
            tbMedInsurance.Text = p.MedInsProvName;
            
        }

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            var image = (Bitmap)Image.FromFile(returnImage());
            patientImages.Image = image;
        }

        private void DiagnosePatient_Click(object sender, EventArgs e)
        {
            diagnosePatientImage();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private Patient ReadPatientInfo(string fn, string ln)
        {
            Patient p = new Patient();
            var textFile = @"C:\Users\shash\source\repos\Ozone\Ozone\PatientDB.txt";
            // Read a file to end of text
            string[] lines = File.ReadAllLines(textFile);

            foreach (string line in lines)
            {
                //MessageBox.Show(line);
                string[] subs = line.Split(';');
                if (String.Compare(fn, subs[0]) == 0 &&
                    String.Compare(ln, subs[1]) == 0)
                {
                    p.FirstName = subs[0];
                    p.LastName = subs[1];
                    p.Rank = subs[2];
                    p.Gender= subs[3];
                    p.DOB= subs[4];
                    p.Age= subs[5];
                    p.SSN= subs[6];
                    p.Street= subs[7];
                    p.City= subs[8];
                    p.Street= subs[9];
                    p.BloodGroup= subs[10];
                    p.HomePhone= subs[11];
                    p.WorkPhone= subs[12];
                    p.Employer= subs[13];
                    p.MaritalStatus= subs[14];
                    p.EmerContactName= subs[15];
                    p.EmerContactPhNumber= subs[16];
                    p.LastSCreenDate= subs[17];
                    p.MedInsProvName= subs[18];
                    break;
                }
            }
            return p;
        }
    }
}
