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
    public partial class HomeForms : Form
    {
        public HomeForms()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            if (MessageBox.Show("Navigating to XRAY Diagnosis !!!", "Inject",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Form1 f1 = new Form1();
                //further instructions
                f1.Show();
            }
        }

        private void HomeForms_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Navigating to Symtom Checker !!!", "Inject", 
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FrmParent f1 = new FrmParent();
                //further instructions
                f1.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            if (MessageBox.Show("Navigating to Doctor Notes !!!", "Inject",
                MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FrmDoctorNotes f1 = new FrmDoctorNotes();
                //further instructions
                f1.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EXITING !!!");
            this.Close();
        }
    }
}
