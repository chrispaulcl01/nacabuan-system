
namespace WindowsFormsApplication1
{
    partial class PatientInfoViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPConsultExit = new System.Windows.Forms.Button();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.PatientListViewerfrm = new Guna.UI.WinForms.GunaLabel();
            this.btnrxhistory = new Guna.UI.WinForms.GunaGradientButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grpSymptoms = new System.Windows.Forms.GroupBox();
            this.gridnoticeviewer = new Guna.UI.WinForms.GunaDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI.WinForms.GunaGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.label26 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtOwnersName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.Label();
            this.bdayDatepicker = new System.Windows.Forms.Label();
            this.cmbAnimalSpecies = new System.Windows.Forms.Label();
            this.txtAnimalBreed = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.Label();
            this.dateLastvaccinedate = new System.Windows.Forms.Label();
            this.txtExistingConditions = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.Label();
            this.txtTypeOfVaccine = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.Label();
            this.cmbStool = new System.Windows.Forms.Label();
            this.cmbBehaAtti = new System.Windows.Forms.Label();
            this.cmbAppetite = new System.Windows.Forms.Label();
            this.cmbDrinkingwater = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.Label();
            this.txtPetID = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtDiagnosis = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            this.grpSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridnoticeviewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPConsultExit
            // 
            this.btnPConsultExit.BackColor = System.Drawing.Color.Transparent;
            this.btnPConsultExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPConsultExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPConsultExit.ForeColor = System.Drawing.Color.Black;
            this.btnPConsultExit.Location = new System.Drawing.Point(1254, 14);
            this.btnPConsultExit.Name = "btnPConsultExit";
            this.btnPConsultExit.Size = new System.Drawing.Size(45, 39);
            this.btnPConsultExit.TabIndex = 83;
            this.btnPConsultExit.Text = "X";
            this.btnPConsultExit.UseVisualStyleBackColor = false;
            this.btnPConsultExit.Click += new System.EventHandler(this.btnPConsultExit_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnPConsultExit);
            this.gunaShadowPanel1.Controls.Add(this.PatientListViewerfrm);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1323, 69);
            this.gunaShadowPanel1.TabIndex = 248;
            // 
            // PatientListViewerfrm
            // 
            this.PatientListViewerfrm.AutoSize = true;
            this.PatientListViewerfrm.BackColor = System.Drawing.Color.MistyRose;
            this.PatientListViewerfrm.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListViewerfrm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientListViewerfrm.Location = new System.Drawing.Point(42, 21);
            this.PatientListViewerfrm.Name = "PatientListViewerfrm";
            this.PatientListViewerfrm.Size = new System.Drawing.Size(248, 29);
            this.PatientListViewerfrm.TabIndex = 1;
            this.PatientListViewerfrm.Text = "Patient Information \r\n";
            // 
            // btnrxhistory
            // 
            this.btnrxhistory.AnimationHoverSpeed = 0.07F;
            this.btnrxhistory.AnimationSpeed = 0.03F;
            this.btnrxhistory.BaseColor1 = System.Drawing.Color.DarkGray;
            this.btnrxhistory.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.btnrxhistory.BorderColor = System.Drawing.Color.Black;
            this.btnrxhistory.FocusedColor = System.Drawing.Color.Empty;
            this.btnrxhistory.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrxhistory.ForeColor = System.Drawing.Color.White;
            this.btnrxhistory.Image = null;
            this.btnrxhistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnrxhistory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnrxhistory.Location = new System.Drawing.Point(1077, 551);
            this.btnrxhistory.Name = "btnrxhistory";
            this.btnrxhistory.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnrxhistory.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnrxhistory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnrxhistory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnrxhistory.OnHoverImage = null;
            this.btnrxhistory.OnPressedColor = System.Drawing.Color.Black;
            this.btnrxhistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnrxhistory.Size = new System.Drawing.Size(100, 51);
            this.btnrxhistory.TabIndex = 345;
            this.btnrxhistory.Text = "RX History";
            this.btnrxhistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnrxhistory.Click += new System.EventHandler(this.btnrxhistory_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.bunifuCustomLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(958, 490);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(104, 21);
            this.bunifuCustomLabel7.TabIndex = 343;
            this.bunifuCustomLabel7.Text = "Diagnosis:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.bunifuCustomLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(768, 447);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(154, 21);
            this.bunifuCustomLabel6.TabIndex = 341;
            this.bunifuCustomLabel6.Text = "Drinking Water:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.bunifuCustomLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(768, 362);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(93, 21);
            this.bunifuCustomLabel3.TabIndex = 339;
            this.bunifuCustomLabel3.Text = "Appetite:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.bunifuCustomLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(768, 271);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(173, 21);
            this.bunifuCustomLabel4.TabIndex = 337;
            this.bunifuCustomLabel4.Text = "Behavior/Attitude:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.bunifuCustomLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(768, 196);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(60, 21);
            this.bunifuCustomLabel2.TabIndex = 335;
            this.bunifuCustomLabel2.Text = "Stool:";
            // 
            // grpSymptoms
            // 
            this.grpSymptoms.Controls.Add(this.gridnoticeviewer);
            this.grpSymptoms.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.grpSymptoms.Location = new System.Drawing.Point(962, 95);
            this.grpSymptoms.Name = "grpSymptoms";
            this.grpSymptoms.Size = new System.Drawing.Size(318, 380);
            this.grpSymptoms.TabIndex = 333;
            this.grpSymptoms.TabStop = false;
            this.grpSymptoms.Text = "The following noticed";
            // 
            // gridnoticeviewer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridnoticeviewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridnoticeviewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridnoticeviewer.BackgroundColor = System.Drawing.Color.White;
            this.gridnoticeviewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridnoticeviewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridnoticeviewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridnoticeviewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridnoticeviewer.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridnoticeviewer.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridnoticeviewer.EnableHeadersVisualStyles = false;
            this.gridnoticeviewer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridnoticeviewer.Location = new System.Drawing.Point(49, 65);
            this.gridnoticeviewer.Name = "gridnoticeviewer";
            this.gridnoticeviewer.RowHeadersVisible = false;
            this.gridnoticeviewer.RowTemplate.Height = 28;
            this.gridnoticeviewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridnoticeviewer.Size = new System.Drawing.Size(240, 263);
            this.gridnoticeviewer.TabIndex = 2;
            this.gridnoticeviewer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridnoticeviewer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridnoticeviewer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridnoticeviewer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridnoticeviewer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridnoticeviewer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridnoticeviewer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridnoticeviewer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridnoticeviewer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridnoticeviewer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridnoticeviewer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gridnoticeviewer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridnoticeviewer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridnoticeviewer.ThemeStyle.HeaderStyle.Height = 28;
            this.gridnoticeviewer.ThemeStyle.ReadOnly = false;
            this.gridnoticeviewer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridnoticeviewer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridnoticeviewer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gridnoticeviewer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridnoticeviewer.ThemeStyle.RowsStyle.Height = 28;
            this.gridnoticeviewer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridnoticeviewer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(296, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 329;
            this.label4.Text = "Contact No.:";
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BaseColor1 = System.Drawing.Color.DarkGray;
            this.btnEdit.BaseColor2 = System.Drawing.Color.LightSlateGray;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Image = null;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(1190, 551);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(109, 51);
            this.btnEdit.TabIndex = 327;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(416, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 324;
            this.label3.Text = "Weight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(416, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 323;
            this.label2.Text = "Existing Conditions:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(416, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 321;
            this.label1.Text = "Type of Vaccine:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(416, 248);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(144, 19);
            this.label27.TabIndex = 319;
            this.label27.Text = "Last Vaccine Date:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(263, 506);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(288, 24);
            this.label29.TabIndex = 318;
            this.label29.Text = "When the last time pet eat and drink?";
            this.label29.UseCompatibleTextRendering = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(416, 345);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 19);
            this.label30.TabIndex = 316;
            this.label30.Text = "Allergies:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(416, 198);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(111, 19);
            this.label31.TabIndex = 314;
            this.label31.Text = "Temperature:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel3.Location = new System.Drawing.Point(504, 160);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(238, 19);
            this.gunaLabel3.TabIndex = 312;
            this.gunaLabel3.Text = "PET MEDICAL INFORMATION";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(26, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 23);
            this.label26.TabIndex = 310;
            this.label26.Text = "Pet ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(649, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 304;
            this.label18.Text = "Date:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(21, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 19);
            this.label19.TabIndex = 303;
            this.label19.Text = "Owners Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(22, 262);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 19);
            this.label20.TabIndex = 302;
            this.label20.Text = "Age:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(21, 357);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 19);
            this.label21.TabIndex = 301;
            this.label21.Text = "Birthdate :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(21, 458);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 19);
            this.label22.TabIndex = 300;
            this.label22.Text = "Animal Breed:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(21, 311);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 19);
            this.label23.TabIndex = 299;
            this.label23.Text = "Gender:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(21, 409);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 19);
            this.label24.TabIndex = 298;
            this.label24.Text = "Animal Species:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(21, 215);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 19);
            this.label25.TabIndex = 297;
            this.label25.Text = "Patient Name:";
            // 
            // txtOwnersName
            // 
            this.txtOwnersName.AutoSize = true;
            this.txtOwnersName.BackColor = System.Drawing.Color.Transparent;
            this.txtOwnersName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnersName.Location = new System.Drawing.Point(140, 162);
            this.txtOwnersName.Name = "txtOwnersName";
            this.txtOwnersName.Size = new System.Drawing.Size(54, 19);
            this.txtOwnersName.TabIndex = 347;
            this.txtOwnersName.Text = "label6";
            // 
            // txtPatientName
            // 
            this.txtPatientName.AutoSize = true;
            this.txtPatientName.BackColor = System.Drawing.Color.Transparent;
            this.txtPatientName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(140, 215);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(54, 19);
            this.txtPatientName.TabIndex = 348;
            this.txtPatientName.Text = "label7";
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.BackColor = System.Drawing.Color.Transparent;
            this.txtAge.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(140, 262);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(54, 19);
            this.txtAge.TabIndex = 349;
            this.txtAge.Text = "label8";
            // 
            // cmbGender
            // 
            this.cmbGender.AutoSize = true;
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.Location = new System.Drawing.Point(140, 309);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(54, 19);
            this.cmbGender.TabIndex = 350;
            this.cmbGender.Text = "label9";
            // 
            // bdayDatepicker
            // 
            this.bdayDatepicker.AutoSize = true;
            this.bdayDatepicker.BackColor = System.Drawing.Color.Transparent;
            this.bdayDatepicker.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayDatepicker.Location = new System.Drawing.Point(140, 357);
            this.bdayDatepicker.Name = "bdayDatepicker";
            this.bdayDatepicker.Size = new System.Drawing.Size(63, 19);
            this.bdayDatepicker.TabIndex = 351;
            this.bdayDatepicker.Text = "label10";
            // 
            // cmbAnimalSpecies
            // 
            this.cmbAnimalSpecies.AutoSize = true;
            this.cmbAnimalSpecies.BackColor = System.Drawing.Color.Transparent;
            this.cmbAnimalSpecies.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnimalSpecies.Location = new System.Drawing.Point(140, 409);
            this.cmbAnimalSpecies.Name = "cmbAnimalSpecies";
            this.cmbAnimalSpecies.Size = new System.Drawing.Size(63, 19);
            this.cmbAnimalSpecies.TabIndex = 352;
            this.cmbAnimalSpecies.Text = "label11";
            // 
            // txtAnimalBreed
            // 
            this.txtAnimalBreed.AutoSize = true;
            this.txtAnimalBreed.BackColor = System.Drawing.Color.Transparent;
            this.txtAnimalBreed.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalBreed.Location = new System.Drawing.Point(140, 456);
            this.txtAnimalBreed.Name = "txtAnimalBreed";
            this.txtAnimalBreed.Size = new System.Drawing.Size(63, 19);
            this.txtAnimalBreed.TabIndex = 353;
            this.txtAnimalBreed.Text = "label12";
            // 
            // txtTemperature
            // 
            this.txtTemperature.AutoSize = true;
            this.txtTemperature.BackColor = System.Drawing.Color.Transparent;
            this.txtTemperature.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(564, 198);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(63, 19);
            this.txtTemperature.TabIndex = 354;
            this.txtTemperature.Text = "label13";
            // 
            // dateLastvaccinedate
            // 
            this.dateLastvaccinedate.AutoSize = true;
            this.dateLastvaccinedate.BackColor = System.Drawing.Color.Transparent;
            this.dateLastvaccinedate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLastvaccinedate.Location = new System.Drawing.Point(564, 247);
            this.dateLastvaccinedate.Name = "dateLastvaccinedate";
            this.dateLastvaccinedate.Size = new System.Drawing.Size(54, 19);
            this.dateLastvaccinedate.TabIndex = 355;
            this.dateLastvaccinedate.Text = "label5";
            // 
            // txtExistingConditions
            // 
            this.txtExistingConditions.AutoSize = true;
            this.txtExistingConditions.BackColor = System.Drawing.Color.Transparent;
            this.txtExistingConditions.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistingConditions.Location = new System.Drawing.Point(564, 302);
            this.txtExistingConditions.Name = "txtExistingConditions";
            this.txtExistingConditions.Size = new System.Drawing.Size(63, 19);
            this.txtExistingConditions.TabIndex = 356;
            this.txtExistingConditions.Text = "label14";
            // 
            // txtAllergies
            // 
            this.txtAllergies.AutoSize = true;
            this.txtAllergies.BackColor = System.Drawing.Color.Transparent;
            this.txtAllergies.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.Location = new System.Drawing.Point(564, 345);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(63, 19);
            this.txtAllergies.TabIndex = 357;
            this.txtAllergies.Text = "label15";
            // 
            // txtTypeOfVaccine
            // 
            this.txtTypeOfVaccine.AutoSize = true;
            this.txtTypeOfVaccine.BackColor = System.Drawing.Color.Transparent;
            this.txtTypeOfVaccine.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeOfVaccine.Location = new System.Drawing.Point(564, 395);
            this.txtTypeOfVaccine.Name = "txtTypeOfVaccine";
            this.txtTypeOfVaccine.Size = new System.Drawing.Size(63, 19);
            this.txtTypeOfVaccine.TabIndex = 358;
            this.txtTypeOfVaccine.Text = "label16";
            // 
            // txtWeight
            // 
            this.txtWeight.AutoSize = true;
            this.txtWeight.BackColor = System.Drawing.Color.Transparent;
            this.txtWeight.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(564, 443);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(63, 19);
            this.txtWeight.TabIndex = 359;
            this.txtWeight.Text = "label17";
            // 
            // cmbStool
            // 
            this.cmbStool.AutoSize = true;
            this.cmbStool.BackColor = System.Drawing.Color.Transparent;
            this.cmbStool.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStool.Location = new System.Drawing.Point(772, 217);
            this.cmbStool.Name = "cmbStool";
            this.cmbStool.Size = new System.Drawing.Size(63, 19);
            this.cmbStool.TabIndex = 360;
            this.cmbStool.Text = "label28";
            // 
            // cmbBehaAtti
            // 
            this.cmbBehaAtti.AutoSize = true;
            this.cmbBehaAtti.BackColor = System.Drawing.Color.Transparent;
            this.cmbBehaAtti.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBehaAtti.Location = new System.Drawing.Point(772, 292);
            this.cmbBehaAtti.Name = "cmbBehaAtti";
            this.cmbBehaAtti.Size = new System.Drawing.Size(63, 19);
            this.cmbBehaAtti.TabIndex = 361;
            this.cmbBehaAtti.Text = "label32";
            // 
            // cmbAppetite
            // 
            this.cmbAppetite.AutoSize = true;
            this.cmbAppetite.BackColor = System.Drawing.Color.Transparent;
            this.cmbAppetite.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppetite.Location = new System.Drawing.Point(772, 383);
            this.cmbAppetite.Name = "cmbAppetite";
            this.cmbAppetite.Size = new System.Drawing.Size(63, 19);
            this.cmbAppetite.TabIndex = 362;
            this.cmbAppetite.Text = "label33";
            // 
            // cmbDrinkingwater
            // 
            this.cmbDrinkingwater.AutoSize = true;
            this.cmbDrinkingwater.BackColor = System.Drawing.Color.Transparent;
            this.cmbDrinkingwater.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrinkingwater.Location = new System.Drawing.Point(772, 468);
            this.cmbDrinkingwater.Name = "cmbDrinkingwater";
            this.cmbDrinkingwater.Size = new System.Drawing.Size(63, 19);
            this.cmbDrinkingwater.TabIndex = 363;
            this.cmbDrinkingwater.Text = "label34";
            // 
            // txtContactNo
            // 
            this.txtContactNo.AutoSize = true;
            this.txtContactNo.BackColor = System.Drawing.Color.Transparent;
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(395, 90);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(65, 21);
            this.txtContactNo.TabIndex = 365;
            this.txtContactNo.Text = "label36";
            // 
            // txtPetID
            // 
            this.txtPetID.AutoSize = true;
            this.txtPetID.BackColor = System.Drawing.Color.Transparent;
            this.txtPetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPetID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetID.Location = new System.Drawing.Point(98, 92);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(65, 21);
            this.txtPetID.TabIndex = 366;
            this.txtPetID.Text = "label37";
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.BackColor = System.Drawing.Color.Transparent;
            this.txtQuestion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(544, 505);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(63, 19);
            this.txtQuestion.TabIndex = 367;
            this.txtQuestion.Text = "label37";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(689, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 368;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.AutoSize = true;
            this.txtDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.txtDiagnosis.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(1062, 492);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(63, 19);
            this.txtDiagnosis.TabIndex = 369;
            this.txtDiagnosis.Text = "label34";
            // 
            // PatientInfoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 614);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtPetID);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.cmbDrinkingwater);
            this.Controls.Add(this.cmbAppetite);
            this.Controls.Add(this.cmbBehaAtti);
            this.Controls.Add(this.cmbStool);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtTypeOfVaccine);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.txtExistingConditions);
            this.Controls.Add(this.dateLastvaccinedate);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtAnimalBreed);
            this.Controls.Add(this.cmbAnimalSpecies);
            this.Controls.Add(this.bdayDatepicker);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtOwnersName);
            this.Controls.Add(this.btnrxhistory);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.grpSymptoms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientInfoViewer";
            this.Text = "PatientInfoEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PatientInfoViewer_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.grpSymptoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridnoticeviewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPConsultExit;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel PatientListViewerfrm;
        private Guna.UI.WinForms.GunaGradientButton btnrxhistory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.GroupBox grpSymptoms;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGradientButton btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label txtOwnersName;
        private System.Windows.Forms.Label txtPatientName;
        private System.Windows.Forms.Label txtAge;
        private System.Windows.Forms.Label cmbGender;
        private System.Windows.Forms.Label bdayDatepicker;
        private System.Windows.Forms.Label cmbAnimalSpecies;
        private System.Windows.Forms.Label txtAnimalBreed;
        private System.Windows.Forms.Label txtTemperature;
        private System.Windows.Forms.Label dateLastvaccinedate;
        private System.Windows.Forms.Label txtExistingConditions;
        private System.Windows.Forms.Label txtAllergies;
        private System.Windows.Forms.Label txtTypeOfVaccine;
        private System.Windows.Forms.Label txtWeight;
        private System.Windows.Forms.Label cmbStool;
        private System.Windows.Forms.Label cmbBehaAtti;
        private System.Windows.Forms.Label cmbAppetite;
        private System.Windows.Forms.Label cmbDrinkingwater;
        private System.Windows.Forms.Label txtContactNo;
        private System.Windows.Forms.Label txtPetID;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label txtDiagnosis;
        private Guna.UI.WinForms.GunaDataGridView gridnoticeviewer;
    }
}