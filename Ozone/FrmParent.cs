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
    public partial class FrmParent : Form
    {
        Form[] frm = { new FormA(), new FormB() };
        int top = -1;
        int count;
        public FrmParent()
        {
            count = frm.Count();
            InitializeComponent();
            
        }
        private void LoadNewForm()
        {
            frm[top].TopLevel = false;
            frm[top].AutoScroll = true;
            frm[top].Dock = DockStyle.Fill;
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(frm[top]);
            //MessageBox.Show(frm[top].Name);
            frm[top].Show();
        }
        private void Back()
        {
            top--;
            if(top <= -1)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                LoadNewForm();
                if(top-1 <= -1)
                {
                    btnBack.Enabled = false;
                }
                if (top >= count)
                {
                    btnNext.Enabled = false;
                }
            }
        }
        private void Next()
        {
            top++;
            if (top >= count)
            {
                return;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                LoadNewForm();
                if (top + 1 == count)
                {
                    btnNext.Enabled = false;
                }
                if (top <= 0)
                {
                    btnBack.Enabled = false;
                }
            }
        }
        private void FrmParent_Load(object sender, EventArgs e)
        {
            LoadNewForm();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            Back();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
