namespace WinFormUI
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddProject = new MetroFramework.Controls.MetroButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnAddSoftwareDevelepor = new MetroFramework.Controls.MetroButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnAddTester = new MetroFramework.Controls.MetroButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnAddJobAnalist = new MetroFramework.Controls.MetroButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAddTeamLeader = new MetroFramework.Controls.MetroButton();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cmbSoftwareDeveloper = new System.Windows.Forms.ComboBox();
            this.cmbTester = new System.Windows.Forms.ComboBox();
            this.cmbJobAnalyst = new System.Windows.Forms.ComboBox();
            this.btnDeleteEmployee = new MetroFramework.Controls.MetroButton();
            this.cmbTeamLeader = new System.Windows.Forms.ComboBox();
            this.dtpPlannedStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPlannedEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgProjectList = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddProject);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox3.Location = new System.Drawing.Point(1135, 389);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(363, 436);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddProject.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddProject.Highlight = true;
            this.btnAddProject.Location = new System.Drawing.Point(116, 121);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(216, 42);
            this.btnAddProject.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddProject.TabIndex = 17;
            this.btnAddProject.Text = "Kaydet";
            this.btnAddProject.UseSelectable = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(45, 294);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 208);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 121);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate.Highlight = true;
            this.btnUpdate.Location = new System.Drawing.Point(116, 294);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 42);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelete.Highlight = true;
            this.btnDelete.Location = new System.Drawing.Point(116, 208);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 42);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCompanyName);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.btnAddSoftwareDevelepor);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.btnAddTester);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.btnAddJobAnalist);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.btnAddTeamLeader);
            this.groupBox1.Controls.Add(this.lstEmployee);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.cmbSoftwareDeveloper);
            this.groupBox1.Controls.Add(this.cmbTester);
            this.groupBox1.Controls.Add(this.cmbJobAnalyst);
            this.groupBox1.Controls.Add(this.btnDeleteEmployee);
            this.groupBox1.Controls.Add(this.cmbTeamLeader);
            this.groupBox1.Controls.Add(this.dtpPlannedStartDate);
            this.groupBox1.Controls.Add(this.dtpPlannedEndDate);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox1.Location = new System.Drawing.Point(27, 389);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1085, 436);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Kayıt";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(311, 337);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(200, 28);
            this.cmbCompanyName.TabIndex = 33;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(961, 181);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 32;
            this.pictureBox9.TabStop = false;
            // 
            // btnAddSoftwareDevelepor
            // 
            this.btnAddSoftwareDevelepor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSoftwareDevelepor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddSoftwareDevelepor.Highlight = true;
            this.btnAddSoftwareDevelepor.Location = new System.Drawing.Point(997, 181);
            this.btnAddSoftwareDevelepor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSoftwareDevelepor.Name = "btnAddSoftwareDevelepor";
            this.btnAddSoftwareDevelepor.Size = new System.Drawing.Size(87, 25);
            this.btnAddSoftwareDevelepor.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddSoftwareDevelepor.TabIndex = 14;
            this.btnAddSoftwareDevelepor.Text = "Ekle";
            this.btnAddSoftwareDevelepor.UseSelectable = true;
            this.btnAddSoftwareDevelepor.Click += new System.EventHandler(this.btnAddSoftwareDevelepor_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(961, 139);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // btnAddTester
            // 
            this.btnAddTester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTester.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddTester.Highlight = true;
            this.btnAddTester.Location = new System.Drawing.Point(997, 139);
            this.btnAddTester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTester.Name = "btnAddTester";
            this.btnAddTester.Size = new System.Drawing.Size(87, 25);
            this.btnAddTester.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddTester.TabIndex = 12;
            this.btnAddTester.Text = "Ekle";
            this.btnAddTester.UseSelectable = true;
            this.btnAddTester.Click += new System.EventHandler(this.btnAddTester_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(961, 94);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // btnAddJobAnalist
            // 
            this.btnAddJobAnalist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddJobAnalist.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddJobAnalist.Highlight = true;
            this.btnAddJobAnalist.Location = new System.Drawing.Point(997, 94);
            this.btnAddJobAnalist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddJobAnalist.Name = "btnAddJobAnalist";
            this.btnAddJobAnalist.Size = new System.Drawing.Size(87, 25);
            this.btnAddJobAnalist.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddJobAnalist.TabIndex = 10;
            this.btnAddJobAnalist.Text = "Ekle";
            this.btnAddJobAnalist.UseSelectable = true;
            this.btnAddJobAnalist.Click += new System.EventHandler(this.btnAddJobAnalist_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(961, 48);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // btnAddTeamLeader
            // 
            this.btnAddTeamLeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTeamLeader.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddTeamLeader.Highlight = true;
            this.btnAddTeamLeader.Location = new System.Drawing.Point(997, 48);
            this.btnAddTeamLeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTeamLeader.Name = "btnAddTeamLeader";
            this.btnAddTeamLeader.Size = new System.Drawing.Size(87, 25);
            this.btnAddTeamLeader.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAddTeamLeader.TabIndex = 8;
            this.btnAddTeamLeader.Text = "Ekle";
            this.btnAddTeamLeader.UseSelectable = true;
            this.btnAddTeamLeader.Click += new System.EventHandler(this.btnAddTeamLeader_Click);
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 20;
            this.lstEmployee.Location = new System.Drawing.Point(597, 260);
            this.lstEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(263, 124);
            this.lstEmployee.TabIndex = 15;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(911, 337);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // cmbSoftwareDeveloper
            // 
            this.cmbSoftwareDeveloper.FormattingEnabled = true;
            this.cmbSoftwareDeveloper.Location = new System.Drawing.Point(736, 180);
            this.cmbSoftwareDeveloper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSoftwareDeveloper.Name = "cmbSoftwareDeveloper";
            this.cmbSoftwareDeveloper.Size = new System.Drawing.Size(200, 28);
            this.cmbSoftwareDeveloper.TabIndex = 13;
            // 
            // cmbTester
            // 
            this.cmbTester.FormattingEnabled = true;
            this.cmbTester.Location = new System.Drawing.Point(736, 135);
            this.cmbTester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTester.Name = "cmbTester";
            this.cmbTester.Size = new System.Drawing.Size(200, 28);
            this.cmbTester.TabIndex = 11;
            // 
            // cmbJobAnalyst
            // 
            this.cmbJobAnalyst.FormattingEnabled = true;
            this.cmbJobAnalyst.Location = new System.Drawing.Point(736, 90);
            this.cmbJobAnalyst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbJobAnalyst.Name = "cmbJobAnalyst";
            this.cmbJobAnalyst.Size = new System.Drawing.Size(200, 28);
            this.cmbJobAnalyst.TabIndex = 9;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteEmployee.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteEmployee.Highlight = true;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(961, 336);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(87, 25);
            this.btnDeleteEmployee.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDeleteEmployee.TabIndex = 16;
            this.btnDeleteEmployee.Text = "Sil";
            this.btnDeleteEmployee.UseSelectable = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // cmbTeamLeader
            // 
            this.cmbTeamLeader.FormattingEnabled = true;
            this.cmbTeamLeader.Location = new System.Drawing.Point(736, 46);
            this.cmbTeamLeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTeamLeader.Name = "cmbTeamLeader";
            this.cmbTeamLeader.Size = new System.Drawing.Size(200, 28);
            this.cmbTeamLeader.TabIndex = 7;
            // 
            // dtpPlannedStartDate
            // 
            this.dtpPlannedStartDate.Location = new System.Drawing.Point(311, 175);
            this.dtpPlannedStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPlannedStartDate.Name = "dtpPlannedStartDate";
            this.dtpPlannedStartDate.Size = new System.Drawing.Size(200, 28);
            this.dtpPlannedStartDate.TabIndex = 3;
            // 
            // dtpPlannedEndDate
            // 
            this.dtpPlannedEndDate.Location = new System.Drawing.Point(311, 224);
            this.dtpPlannedEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPlannedEndDate.Name = "dtpPlannedEndDate";
            this.dtpPlannedEndDate.Size = new System.Drawing.Size(200, 28);
            this.dtpPlannedEndDate.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(311, 91);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 50);
            this.txtDescription.TabIndex = 2;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(311, 276);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(200, 28);
            this.txtState.TabIndex = 5;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(311, 52);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(200, 28);
            this.txtProjectName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Durumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Planlanan Bitiş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Planlanan Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Açıklaması";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Müşteri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(593, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Yazılımcı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(593, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tester";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(593, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "İş Analisti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(593, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Takım Lideri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Proje Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvgProjectList);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox2.Location = new System.Drawing.Point(27, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1483, 287);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proje Listesi";
            // 
            // dvgProjectList
            // 
            this.dvgProjectList.AllowUserToAddRows = false;
            this.dvgProjectList.AllowUserToDeleteRows = false;
            this.dvgProjectList.AllowUserToResizeColumns = false;
            this.dvgProjectList.AllowUserToResizeRows = false;
            this.dvgProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProjectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgProjectList.Location = new System.Drawing.Point(3, 23);
            this.dvgProjectList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgProjectList.Name = "dvgProjectList";
            this.dvgProjectList.RowTemplate.Height = 24;
            this.dvgProjectList.Size = new System.Drawing.Size(1477, 262);
            this.dvgProjectList.TabIndex = 4;
            this.dvgProjectList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgProjectList_RowHeaderMouseClick);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 841);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectForm";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Proje";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProjectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvgProjectList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPlannedStartDate;
        private System.Windows.Forms.DateTimePicker dtpPlannedEndDate;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox cmbSoftwareDeveloper;
        private System.Windows.Forms.ComboBox cmbTester;
        private System.Windows.Forms.ComboBox cmbJobAnalyst;
        private MetroFramework.Controls.MetroButton btnDeleteEmployee;
        private System.Windows.Forms.ComboBox cmbTeamLeader;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private MetroFramework.Controls.MetroButton btnAddSoftwareDevelepor;
        private System.Windows.Forms.PictureBox pictureBox8;
        private MetroFramework.Controls.MetroButton btnAddTester;
        private System.Windows.Forms.PictureBox pictureBox7;
        private MetroFramework.Controls.MetroButton btnAddJobAnalist;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MetroFramework.Controls.MetroButton btnAddTeamLeader;
        private MetroFramework.Controls.MetroButton btnAddProject;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.Label label6;
    }
}