namespace Ozone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.patientImages = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMaritalStatus = new System.Windows.Forms.TextBox();
            this.tbEmerContactNum = new System.Windows.Forms.TextBox();
            this.tbRelationship = new System.Windows.Forms.TextBox();
            this.tbEmerContName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLastScreenDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMedInsurance = new System.Windows.Forms.TextBox();
            this.tbEmployer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWorkPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHomePhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBloodGroup = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPatientInfo = new System.Windows.Forms.Button();
            this.pbPatientPic = new System.Windows.Forms.PictureBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tBSN = new System.Windows.Forms.TextBox();
            this.tbDOB = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandOutput = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DiagnosePatient = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientImages)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // patientImages
            // 
            this.patientImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientImages.Location = new System.Drawing.Point(0, 0);
            this.patientImages.Name = "patientImages";
            this.patientImages.Size = new System.Drawing.Size(998, 1024);
            this.patientImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patientImages.TabIndex = 8;
            this.patientImages.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.DiagnosePatient);
            this.panel1.Controls.Add(this.tbMaritalStatus);
            this.panel1.Controls.Add(this.tbEmerContactNum);
            this.panel1.Controls.Add(this.tbRelationship);
            this.panel1.Controls.Add(this.tbEmerContName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbLastScreenDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbMedInsurance);
            this.panel1.Controls.Add(this.tbEmployer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbWorkPhone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbHomePhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbGender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbBloodGroup);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPatientInfo);
            this.panel1.Controls.Add(this.pbPatientPic);
            this.panel1.Controls.Add(this.tbZip);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.tBSN);
            this.panel1.Controls.Add(this.tbDOB);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.tbLN);
            this.panel1.Controls.Add(this.tbFN);
            this.panel1.Controls.Add(this.lblZip);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblStreet);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblLN);
            this.panel1.Controls.Add(this.lblFN);
            this.panel1.Controls.Add(this.cbPatient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CommandOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 1024);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbMaritalStatus
            // 
            this.tbMaritalStatus.Location = new System.Drawing.Point(647, 388);
            this.tbMaritalStatus.Name = "tbMaritalStatus";
            this.tbMaritalStatus.ReadOnly = true;
            this.tbMaritalStatus.Size = new System.Drawing.Size(132, 26);
            this.tbMaritalStatus.TabIndex = 54;
            // 
            // tbEmerContactNum
            // 
            this.tbEmerContactNum.Location = new System.Drawing.Point(326, 573);
            this.tbEmerContactNum.Name = "tbEmerContactNum";
            this.tbEmerContactNum.ReadOnly = true;
            this.tbEmerContactNum.Size = new System.Drawing.Size(453, 26);
            this.tbEmerContactNum.TabIndex = 53;
            // 
            // tbRelationship
            // 
            this.tbRelationship.Location = new System.Drawing.Point(326, 612);
            this.tbRelationship.Name = "tbRelationship";
            this.tbRelationship.ReadOnly = true;
            this.tbRelationship.Size = new System.Drawing.Size(282, 26);
            this.tbRelationship.TabIndex = 52;
            // 
            // tbEmerContName
            // 
            this.tbEmerContName.Location = new System.Drawing.Point(326, 535);
            this.tbEmerContName.Name = "tbEmerContName";
            this.tbEmerContName.ReadOnly = true;
            this.tbEmerContName.Size = new System.Drawing.Size(453, 26);
            this.tbEmerContName.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(265, 27);
            this.label13.TabIndex = 50;
            this.label13.Text = "Emergency Contact Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 573);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 27);
            this.label12.TabIndex = 49;
            this.label12.Text = "Emergency Contact #:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 612);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 27);
            this.label11.TabIndex = 48;
            this.label11.Text = "Relationship to patient:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 998);
            this.splitter1.TabIndex = 47;
            this.splitter1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 27);
            this.label10.TabIndex = 45;
            this.label10.Text = "Marital Status:";
            // 
            // tbLastScreenDate
            // 
            this.tbLastScreenDate.Location = new System.Drawing.Point(326, 651);
            this.tbLastScreenDate.Name = "tbLastScreenDate";
            this.tbLastScreenDate.ReadOnly = true;
            this.tbLastScreenDate.Size = new System.Drawing.Size(175, 26);
            this.tbLastScreenDate.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 651);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 27);
            this.label9.TabIndex = 43;
            this.label9.Text = "Last Screening Date:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbMedInsurance
            // 
            this.tbMedInsurance.Location = new System.Drawing.Point(326, 689);
            this.tbMedInsurance.Name = "tbMedInsurance";
            this.tbMedInsurance.ReadOnly = true;
            this.tbMedInsurance.Size = new System.Drawing.Size(175, 26);
            this.tbMedInsurance.TabIndex = 42;
            // 
            // tbEmployer
            // 
            this.tbEmployer.Location = new System.Drawing.Point(190, 388);
            this.tbEmployer.Name = "tbEmployer";
            this.tbEmployer.ReadOnly = true;
            this.tbEmployer.Size = new System.Drawing.Size(134, 26);
            this.tbEmployer.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 27);
            this.label8.TabIndex = 40;
            this.label8.Text = "Employer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 689);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "Medical Insurance:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbWorkPhone
            // 
            this.tbWorkPhone.Location = new System.Drawing.Point(647, 347);
            this.tbWorkPhone.Name = "tbWorkPhone";
            this.tbWorkPhone.ReadOnly = true;
            this.tbWorkPhone.Size = new System.Drawing.Size(132, 26);
            this.tbWorkPhone.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "Work Phone:";
            // 
            // tbHomePhone
            // 
            this.tbHomePhone.Location = new System.Drawing.Point(190, 348);
            this.tbHomePhone.Name = "tbHomePhone";
            this.tbHomePhone.ReadOnly = true;
            this.tbHomePhone.Size = new System.Drawing.Size(134, 26);
            this.tbHomePhone.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 27);
            this.label6.TabIndex = 35;
            this.label6.Text = "Home Phone:";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(647, 303);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(132, 26);
            this.tbGender.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "SSN:";
            // 
            // tbBloodGroup
            // 
            this.tbBloodGroup.Location = new System.Drawing.Point(647, 261);
            this.tbBloodGroup.Name = "tbBloodGroup";
            this.tbBloodGroup.ReadOnly = true;
            this.tbBloodGroup.Size = new System.Drawing.Size(132, 26);
            this.tbBloodGroup.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(647, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Blood Group:";
            // 
            // btnPatientInfo
            // 
            this.btnPatientInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientInfo.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPatientInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientInfo.Image")));
            this.btnPatientInfo.Location = new System.Drawing.Point(186, 828);
            this.btnPatientInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnPatientInfo.Name = "btnPatientInfo";
            this.btnPatientInfo.Size = new System.Drawing.Size(315, 63);
            this.btnPatientInfo.TabIndex = 27;
            this.btnPatientInfo.Text = "Pull patient X-RAY";
            this.btnPatientInfo.UseVisualStyleBackColor = false;
            this.btnPatientInfo.Click += new System.EventHandler(this.btnPatientInfo_Click);
            // 
            // pbPatientPic
            // 
            this.pbPatientPic.Image = ((System.Drawing.Image)(resources.GetObject("pbPatientPic.Image")));
            this.pbPatientPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPatientPic.InitialImage")));
            this.pbPatientPic.Location = new System.Drawing.Point(0, 794);
            this.pbPatientPic.Name = "pbPatientPic";
            this.pbPatientPic.Size = new System.Drawing.Size(175, 165);
            this.pbPatientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatientPic.TabIndex = 26;
            this.pbPatientPic.TabStop = false;
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(190, 302);
            this.tbZip.Name = "tbZip";
            this.tbZip.ReadOnly = true;
            this.tbZip.Size = new System.Drawing.Size(134, 26);
            this.tbZip.TabIndex = 25;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(190, 259);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(201, 26);
            this.tbCity.TabIndex = 24;
            // 
            // tBSN
            // 
            this.tBSN.Location = new System.Drawing.Point(190, 218);
            this.tBSN.Name = "tBSN";
            this.tBSN.ReadOnly = true;
            this.tBSN.Size = new System.Drawing.Size(260, 26);
            this.tBSN.TabIndex = 23;
            // 
            // tbDOB
            // 
            this.tbDOB.Location = new System.Drawing.Point(647, 136);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.ReadOnly = true;
            this.tbDOB.Size = new System.Drawing.Size(132, 26);
            this.tbDOB.TabIndex = 22;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(647, 175);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(132, 26);
            this.tbAge.TabIndex = 21;
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(190, 175);
            this.tbLN.Name = "tbLN";
            this.tbLN.ReadOnly = true;
            this.tbLN.Size = new System.Drawing.Size(260, 26);
            this.tbLN.TabIndex = 20;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(190, 136);
            this.tbFN.Name = "tbFN";
            this.tbFN.ReadOnly = true;
            this.tbFN.Size = new System.Drawing.Size(260, 26);
            this.tbFN.TabIndex = 19;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.BackColor = System.Drawing.Color.Transparent;
            this.lblZip.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(40, 300);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(47, 27);
            this.lblZip.TabIndex = 18;
            this.lblZip.Text = "Zip:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(39, 257);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(53, 27);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(39, 217);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(136, 27);
            this.lblStreet.TabIndex = 16;
            this.lblStreet.Text = "Street Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(500, 136);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(61, 27);
            this.lblDOB.TabIndex = 15;
            this.lblDOB.Text = "DOB:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(500, 175);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(55, 27);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Age:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.BackColor = System.Drawing.Color.Transparent;
            this.lblLN.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(40, 173);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(117, 27);
            this.lblLN.TabIndex = 13;
            this.lblLN.Text = "Last Name:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.BackColor = System.Drawing.Color.Transparent;
            this.lblFN.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(39, 136);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(120, 27);
            this.lblFN.TabIndex = 12;
            this.lblFN.Text = "First Name:";
            // 
            // cbPatient
            // 
            this.cbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(190, 26);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(383, 34);
            this.cbPatient.TabIndex = 11;
            this.cbPatient.SelectedIndexChanged += new System.EventHandler(this.cbPatient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "My Patient List:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CommandOutput
            // 
            this.CommandOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommandOutput.Location = new System.Drawing.Point(0, 998);
            this.CommandOutput.Name = "CommandOutput";
            this.CommandOutput.Size = new System.Drawing.Size(838, 26);
            this.CommandOutput.TabIndex = 9;
            this.CommandOutput.Text = "-Log-";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.patientImages);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(900, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 1024);
            this.panel2.TabIndex = 11;
            // 
            // DiagnosePatient
            // 
            this.DiagnosePatient.BackColor = System.Drawing.Color.Transparent;
            this.DiagnosePatient.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosePatient.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DiagnosePatient.Image = ((System.Drawing.Image)(resources.GetObject("DiagnosePatient.Image")));
            this.DiagnosePatient.Location = new System.Drawing.Point(514, 828);
            this.DiagnosePatient.Margin = new System.Windows.Forms.Padding(0);
            this.DiagnosePatient.Name = "DiagnosePatient";
            this.DiagnosePatient.Size = new System.Drawing.Size(310, 63);
            this.DiagnosePatient.TabIndex = 55;
            this.DiagnosePatient.Text = "Diagnose Patient";
            this.DiagnosePatient.UseVisualStyleBackColor = false;
            this.DiagnosePatient.Click += new System.EventHandler(this.DiagnosePatient_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(344, 896);
            this.exit.Margin = new System.Windows.Forms.Padding(0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(315, 63);
            this.exit.TabIndex = 56;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientImages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox patientImages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox CommandOutput;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPatientInfo;
        private System.Windows.Forms.PictureBox pbPatientPic;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tBSN;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastScreenDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMedInsurance;
        private System.Windows.Forms.TextBox tbEmployer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWorkPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHomePhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBloodGroup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmerContactNum;
        private System.Windows.Forms.TextBox tbRelationship;
        private System.Windows.Forms.TextBox tbEmerContName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMaritalStatus;
        private System.Windows.Forms.Button DiagnosePatient;
        private System.Windows.Forms.Button exit;
    }
}

