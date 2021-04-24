using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;

namespace Ozone
{
    public partial class FrmDoctorNotes : Form
    {
        bool action = false;
        /*patient seems to be having acute pain in the head
        patient seems to be having acute pain in the legs
        patient seems to be having acute pain in the arms
        patient should see a physiotherapist
        patient should see a psychiatrist
        end session*/
        String[] actions = (File.ReadAllLines("./Grammar/medicationActions.txt"));
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer speak = new SpeechSynthesizer();
        public FrmDoctorNotes()
        {
            InitializeComponent();

        }
        private void FrmDoctorNotes_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            speak.SelectVoiceByHints(VoiceGender.Male);
            Choices commands = new Choices();
            commands.Add(actions);
            GrammarBuilder builder = new GrammarBuilder(commands);
            builder.Append(commands);
            Grammar grammar = new Grammar(builder);
            recognizer.LoadGrammarAsync(grammar);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += recognizer_SpeechRecognized;
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String response = e.Result.Text;
            if (response.Contains("prescribe"))
            {
                action = true;
            }
            if (action == true)
            {
                rtbNotes.AppendText(response + "\n");
                action = false;
            }
        }
        private void FrmDoctorNotes_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            rtbNotes.Enabled = true;
            btnCancel.Enabled = true;
            btnClear.Enabled = true;
            btnSave.Enabled = true;

            groupBox1.Visible = true;
            rtbNotes.Visible = true;
            btnCancel.Visible = true;
            btnClear.Visible = true;
            btnSave.Visible = true;


        }
        private void rtbNotes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbNotes.AppendText("-------------End of session-------------");
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbNotes.Clear();
        }
    }
}
