using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ozone
{
    public partial class FormB : Form
    {
        public static string SelectedOrgan = "";
        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            /*
            foreach (RowStyle r in tableLayoutPanel1.RowStyles)
            {
                r.SizeType = SizeType.Percent;
                r.Height = 20;
                this.tableLayoutPanel1.RowStyles.Add(r);
            }*/
            //panel1.Coll.Collapsible = True;
            rtbSymptom.Text = FormA.SelectedSymptom0 + "  " + FormA.SelectedSymptom1 + "  " +
                FormA.SelectedSymptom2 + "  " + FormA.SelectedSymptom3 + "  " +
                FormA.SelectedSymptom4 + "  " + FormA.SelectedSymptom5 + "  " +
                FormA.SelectedSymptom6 + "  " + FormA.SelectedSymptom7 + "  " +
                FormA.SelectedSymptom8 + "  " + FormA.SelectedSymptom9 + "  " +
                FormA.SelectedSymptom10;            

            //rtbDisease.Text = FormA.SelectedOrgan;
            SelectedOrgan = FormA.SelectedOrgan;

            // Bind Data to Datagrid
            switch (SelectedOrgan)
            {
                case "Lungs":
                    dataGridView1.DataSource = GetLungDiseaseList();
                    break;
                case "Liver":
                    dataGridView1.DataSource = GetLiverDiseaseList();
                    break;
                case "Stomach":
                    dataGridView1.DataSource = GetStomachDiseaseList();
                    break;
                case "Spleen":
                    dataGridView1.DataSource = GetSpleenDiseaseList();
                    break;
                case "Intestine":
                    dataGridView1.DataSource = GetIntestineDiseaseList();
                    break;
                case "Brain":
                    dataGridView1.DataSource = GetBrainDiseaseList();
                    break;
                case "Heart":
                    dataGridView1.DataSource = GetHeartDiseaseList();
                    break;
                case "Pancreas":
                    dataGridView1.DataSource = GetPancreasDiseaseList();
                    break;
                case "Kidney":
                    dataGridView1.DataSource = GetKidneyDiseaseList();
                    break;
                case "Small Intestine":
                    dataGridView1.DataSource = GetIntestineDiseaseList();
                    break;
                default:
                    break;
            }
            linkLabel1.Text = "Visit Health Info";
        }
        protected List<Disease> GetLungDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Asthma", "83%");
            ldis.Add(d);
            d = new Disease(2, "Pneumothorax", "64%");
            ldis.Add(d);
            d = new Disease(3, "bronchitis", "55%");
            ldis.Add(d);
            d = new Disease(4, "COPD", "43%");
            ldis.Add(d);
            d = new Disease(5, "Lung Cancer", "38%");
            ldis.Add(d);
            d = new Disease(6, "Pneumonia", "29%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetBrainDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Alzheimers", "83%");
            ldis.Add(d);
            d = new Disease(2, "Dementia", "64%");
            ldis.Add(d);
            d = new Disease(3, "Brain Cancer", "55%");
            ldis.Add(d);
            d = new Disease(4, "Brain Tumor", "43%");
            ldis.Add(d);
            d = new Disease(5, "Mental Disorder", "38%");
            ldis.Add(d);
            d = new Disease(6, "Parkinson", "29%");
            ldis.Add(d);
            d = new Disease(7, "Stroke", "18%");
            ldis.Add(d);
            d = new Disease(8, "Concussion", "14%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetKidneyDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Kidney stone", "83%");
            ldis.Add(d);
            d = new Disease(2, "Glomerulonephritis", "64%");
            ldis.Add(d);
            d = new Disease(3, "Polycystic ", "55%");
            ldis.Add(d);
            d = new Disease(4, "Urinary Tract Infection", "43%");
            ldis.Add(d);
            d = new Disease(5, "Cystinosis", "38%");
            ldis.Add(d);
            d = new Disease(6, "Fabry", "29%");
            ldis.Add(d);
            d = new Disease(7, "Familial", "29%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetLiverDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Acute Hepatic", "83%");
            ldis.Add(d);
            d = new Disease(2, "Gilbert Syndrome.", "64%");
            ldis.Add(d);
            d = new Disease(3, "LALD", "55%");
            ldis.Add(d);
            d = new Disease(4, "NASH", "43%");
            ldis.Add(d);
            d = new Disease(5, "Viral Hepatatis - A", "38%");
            ldis.Add(d);
            d = new Disease(8, "Viral Hepatatis - B", "38%");
            ldis.Add(d);
            d = new Disease(7, "Viral Hepatatis - C", "38%");
            ldis.Add(d);
            d = new Disease(8, "Fabry", "29%");
            ldis.Add(d);
            d = new Disease(9, "Familial", "29%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetHeartDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Coronary artery(CAD)", "83%");
            ldis.Add(d);
            d = new Disease(2, "Heart Failure", "64%");
            ldis.Add(d);
            d = new Disease(3, "Arrhythmia", "55%");
            ldis.Add(d);
            d = new Disease(4, "Valvular ", "43%");
            ldis.Add(d);
            d = new Disease(5, "Aortic aneurysms", "38%");
            ldis.Add(d);
            d = new Disease(6, "Heart infections", "29%");
            ldis.Add(d);
            d = new Disease(7, "Heart Attack", "29%");
            ldis.Add(d);
            d = new Disease(8, "Cardiomyopathy", "29%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetStomachDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Gastroesophageal Reflux(GERD)", "83%");
            ldis.Add(d);
            d = new Disease(2, "Diarrhea", "64%");
            ldis.Add(d);
            d = new Disease(3, "Constipation", "55%");
            ldis.Add(d);
            d = new Disease(4, "Ulcers ", "43%");
            ldis.Add(d);
            d = new Disease(5, "Hemorrhoids", "38%");
            ldis.Add(d);
            d = new Disease(6, "Ulcerative Colitis", "29%");
            ldis.Add(d);
            d = new Disease(7, "Diverticulitis", "29%");
            ldis.Add(d);
            d = new Disease(8, "Gallstones", "29%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetIntestineDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Gastroesophageal Reflux(GERD)", "83%");
            ldis.Add(d);
            d = new Disease(2, "Peptic Ulcer", "64%");
            ldis.Add(d);
            d = new Disease(3, "Stomach Flu", "55%");
            ldis.Add(d);
            d = new Disease(4, "Inflammatory Bowel(IBD)", "43%");
            ldis.Add(d);
            d = new Disease(5, "Irritable Bowel Syndrome (IBS)", "38%");
            ldis.Add(d);
            d = new Disease(6, "Constipation", "29%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetSpleenDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Gastroesophageal Reflux(GERD)", "83%");
            ldis.Add(d);
            d = new Disease(2, "Peptic Ulcer", "64%");
            ldis.Add(d);
            d = new Disease(3, "Stomach Flu", "55%");
            ldis.Add(d);
            d = new Disease(4, "Inflammatory Bowel(IBD)", "43%");
            ldis.Add(d);
            d = new Disease(5, "Irritable Bowel Syndrome (IBS)", "38%");
            ldis.Add(d);
            d = new Disease(6, "Constipation", "29%");
            ldis.Add(d);
            return ldis;
        }
        protected List<Disease> GetPancreasDiseaseList()
        {
            List<Disease> ldis = new List<Disease>();
            Disease d = new Disease(1, "Pancreas Malfunction", "83%");
            ldis.Add(d);
            d = new Disease(2, "Pancreatitis", "64%");
            ldis.Add(d);
            d = new Disease(3, "Cystic fibrosis", "55%");
            ldis.Add(d);
            d = new Disease(4, "Pancreatic cancer", "43%");
            ldis.Add(d);
            d = new Disease(5, "Diabetes", "38%");
            ldis.Add(d);
            d = new Disease(6, "Acute pancreatitis", "29%");
            ldis.Add(d);
            d = new Disease(7, "Chronic pancreatitis", "29%");
            ldis.Add(d);
            return ldis;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                switch (SelectedOrgan)
                {
                    case "Lungs":
                        System.Diagnostics.Process.Start("https://www.lung.org/lung-health-diseases/warning-signs-of-lung-disease");
                        break;
                    case "Liver":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/diseases-conditions/liver-problems/symptoms-causes/syc-20374502");
                        break;
                    case "Stomach":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/diseases-conditions/stomach-polyps/symptoms-causes/syc-20377992");
                        break;
                    case "Spleen":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/diseases-conditions/enlarged-spleen/symptoms-causes/syc-20354326");
                        break;
                    case "Intestine":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/small-intestine/img-20006054");
                        break;
                    case "Brain":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/symptoms/brain-lesions/basics/definition/sym-20050692");
                        break;
                    case "Heart":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/diseases-conditions/heart-failure/symptoms-causes/syc-20373142");
                        break;
                    case "Pancreas":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/tests-procedures/pancreas-transplant/about/pac-20384783");
                        break;
                    case "Kidney":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/symptoms/kidney-pain/basics/causes/sym-20050902");
                        break;
                    case "Small Intestine":
                        System.Diagnostics.Process.Start("https://www.mayoclinic.org/small-intestine/img-20006054");
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }
    }
}
