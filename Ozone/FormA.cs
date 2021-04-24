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
    public partial class FormA : Form
    {
        public static string SelectedOrgan = "";

        public static string SelectedSymptom0 = "";
        public static string SelectedSymptom1 = "";
        public static string SelectedSymptom2 = "";
        public static string SelectedSymptom3 = "";
        public static string SelectedSymptom4 = "";
        public static string SelectedSymptom5 = "";
        public static string SelectedSymptom6 = "";
        public static string SelectedSymptom7 = "";
        public static string SelectedSymptom8 = "";
        public static string SelectedSymptom9 = "";
        public static string SelectedSymptom10 = "";

        public FormA()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbLung_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Lungs";
            groupBox2.Visible = true;
            groupBox2.Text = "LUNG DISEASE SYMPTOM";
            pbLung.BackColor = Color.Aqua;
            checkBox0.Text = "Shortness of breath";
            checkBox1.Text = "Dry cough";
            checkBox2.Text = "Chronic Cough";
            checkBox3.Text = "Shortness of breath";
            checkBox4.Text = "Chronic Mucus Production";
            checkBox5.Text = "Wheezing";
            checkBox6.Text = "Coughing up Blood";
            checkBox7.Text = "Chronic Chest Pain";
            checkBox8.Text = "Noisy Breething";
            checkBox9.Text = "Nausea";
            checkBox10.Text = "Vomiting";
        }

        private void pbheart_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Heart";
            groupBox2.Visible = true;
            groupBox2.Text = "HEART DISEASE SYMPTOM";
            checkBox0.Text = "Chest pain";
            checkBox1.Text = "Chest tightness";
            checkBox2.Text = "Chest pressure";
            checkBox3.Text = "Chest discomfort (angina)";
            checkBox4.Text = "Shortness of breath";
            checkBox5.Text = "Pain";
            checkBox6.Text = "Numbness";
            checkBox7.Text = "Weakness or Coldness";
            checkBox8.Text = "Pain in the Neck";
            checkBox9.Text = "Pain in the Upper abdomen";
            checkBox10.Text = "Nausea";

        }

        private void pbLiver_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Liver";
            groupBox2.Visible = true;
            groupBox2.Text = "LIVER DISEASE SYMPTOM";
            checkBox0.Text = "Fatigue";
            checkBox1.Text = "Abdominal swelling";
            checkBox2.Text = "Enlarged blood vessels ";
            checkBox3.Text = "Enlarged spleen";
            checkBox4.Text = "Red palms";
            checkBox5.Text = "Jaundice";
            checkBox6.Text = "Itchy skin";
            checkBox7.Text = "Dark Urine color";
            checkBox8.Text = "Pale stool color";
            checkBox9.Text = "Vomiting";
            checkBox10.Text = "Nausea";
        }

        private void pbStomach_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Stomach";
            groupBox2.Visible = true;
            groupBox2.Text = "STOMACH DISEASE SYMPTOM";
            checkBox0.Text = "Abdominal pain";
            checkBox1.Text = "Cramping";
            checkBox2.Text = "Belching";
            checkBox3.Text = "Bloody stool";
            checkBox4.Text = "Changes in Bowel movement";
            checkBox5.Text = "Constipation";
            checkBox6.Text = "Cramping";
            checkBox7.Text = "Diarrhea";
            checkBox8.Text = "Gas";
            checkBox9.Text = "Indigestion";
            checkBox10.Text = "Nausea";
        }

        private void pbSpleen_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Spleen";
            groupBox2.Visible = true;
            groupBox2.Text = "SPLEEN SYMPTOMS";
            checkBox0.Text = "Feeling full without eating";
            checkBox1.Text = "Anemia";
            checkBox2.Text = "Fatigue";
            checkBox3.Text = "Frequent Infection";
            checkBox4.Text = "Easy bleeding";
            checkBox5.Text = "Constipation";
            checkBox6.Text = "Cramping";
            checkBox7.Text = "Diarrhea";
            checkBox8.Text = "Gas";
            checkBox9.Text = "Indigestion";
            checkBox10.Text = "Nausea";
        }

        private void pbIntestine_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Intestine";
            groupBox2.Visible = true;
            groupBox2.Text = "INTESTINE DISEASE SYMPTOM";
            checkBox0.Text = "Feeling full without eating";
            checkBox1.Text = "Weight gain";
            checkBox2.Text = "Swallowing problems";
            checkBox3.Text = "Pain in the belly";
            checkBox4.Text = "Incontinence";
            checkBox5.Text = "Constipation";
            checkBox6.Text = "Heartburn";
            checkBox7.Text = "Diarrhea";
            checkBox8.Text = "Constipation";
            checkBox9.Text = "Bloating";
            checkBox10.Text = "Bleeding";

        }

        private void pbBrain_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Brain";
            groupBox2.Visible = true;
            groupBox2.Text = "BRAIN DISEASE SYMPTOM";
            checkBox0.Text = "Memory Loss";
            checkBox1.Text = "forgetfulness";
            checkBox2.Text = "Apathy";
            checkBox3.Text = "Anxiety";
            checkBox4.Text = "Agitation";
            checkBox5.Text = "Loss Inhibition";
            checkBox6.Text = "Mood changes";
            checkBox7.Text = "Sleep Problems";
            checkBox8.Text = "Personality changes";
            checkBox9.Text = "Headaches";
            checkBox10.Text = "Seizure";
        }

        private void pbPancreas_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Pancreas";
            groupBox2.Visible = true;
            groupBox2.Text = "PANCREAS DISEASE SYMPTOM";
            checkBox0.Text = "Abdominal tenderness";
            checkBox1.Text = "Swelling";
            checkBox2.Text = "Pain";
            checkBox3.Text = "Excess Gas";
            checkBox4.Text = "Diarrhea";
            checkBox5.Text = "Foul Smelling Stool";
            checkBox6.Text = "Light colored stool";
            checkBox7.Text = "Fever";
            checkBox8.Text = "Weight Loss";
            checkBox9.Text = "Malnutrition";
            checkBox10.Text = "Acute Chronic";
        }

        private void pbKidney_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Kidney";
            groupBox2.Visible = true;
            groupBox2.Text = "KIDNEY DISEASE SYMPTOM";
            checkBox0.Text = "Decreased Urine";
            checkBox1.Text = "Fluid retention";
            checkBox2.Text = "Shortness of Breath";
            checkBox3.Text = "Fatigue";
            checkBox4.Text = "Confusion";
            checkBox5.Text = "Nausea";
            checkBox6.Text = "Weakness";
            checkBox7.Text = "Irrelegular Heartbeat";
            checkBox8.Text = "Chest Pain";
            checkBox9.Text = "Pressure";
            checkBox10.Text = "Seizures";
        }

        private void pbSmallIntestine_Click(object sender, EventArgs e)
        {
            clearcheckbox();
            SelectedOrgan = "Small Intestine";
            groupBox2.Visible = true;
            groupBox2.Text = "SMALL INTESTINE SYMPTOMS";
            checkBox0.Text = "Bleeding";
            checkBox1.Text = "Celiac disease";
            checkBox2.Text = "Crohns disease";
            checkBox3.Text = "Infections";
            checkBox4.Text = "Intestinal Cancer";
            checkBox5.Text = "Intestinal Obstruction";
            checkBox6.Text = "Irritable bowl syndrome";
            checkBox7.Text = "Ulcer";
            checkBox8.Text = "Pain";
            checkBox9.Text = "Weight Loss";
            checkBox10.Text = "Fatigue";
        }

        private void clearcheckbox()
        {
            checkBox0.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
        }
        private void pbLung_MouseHover(object sender, EventArgs e)
        {
            pbLung.BackColor = Color.FromArgb(32, 32, 32);
            pbLung.BringToFront();
        }

        private void checkBox0_Click(object sender, EventArgs e)
        {
            if (checkBox0.Checked)
            {
                SelectedSymptom0 = checkBox0.Text;
            }
            else
            {
                SelectedSymptom0 = "";
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SelectedSymptom1 = checkBox1.Text;
            }
            else
            {
                SelectedSymptom1 = "";
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SelectedSymptom2 = checkBox2.Text;
            }
            else
            {
                SelectedSymptom2 = "";
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SelectedSymptom3 = checkBox3.Text;
            }
            else
            {
                SelectedSymptom3 = "";
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                SelectedSymptom4 = checkBox4.Text;
            }
            else
            {
                SelectedSymptom4 = "";
            }
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                SelectedSymptom5 = checkBox5.Text;
            }
            else
            {
                SelectedSymptom5 = "";
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                SelectedSymptom6 = checkBox6.Text;
            }
            else
            {
                SelectedSymptom6 = "";
            }
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                SelectedSymptom7 = checkBox7.Text;
            }
            else
            {
                SelectedSymptom7 = "";
            }
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                SelectedSymptom8 = checkBox8.Text;
            }
            else
            {
                SelectedSymptom8 = "";
            }
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                SelectedSymptom9 = checkBox9.Text;
            }
            else
            {
                SelectedSymptom9 = "";
            }
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SelectedSymptom10 = checkBox10.Text;
            }
            else
            {
                SelectedSymptom10 = "";
            }
        }
    }
}
