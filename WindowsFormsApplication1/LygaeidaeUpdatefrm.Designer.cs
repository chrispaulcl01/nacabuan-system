namespace WindowsFormsApplication1
{
    partial class LygaeidaeUpdatefrm
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
            this.btnBackLyg = new FontAwesome.Sharp.IconButton();
            this.cmbGender = new Guna.UI.WinForms.GunaComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPetID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAllergies = new Guna.UI.WinForms.GunaComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExDisease = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.cmbAnimalBreed = new Guna.UI.WinForms.GunaComboBox();
            this.bdayDatepicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cmbAnimalSpecies = new Guna.UI.WinForms.GunaComboBox();
            this.txtAge = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPatientName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnSaveLy = new FontAwesome.Sharp.IconButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtOwnersname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOperations = new Guna.UI.WinForms.GunaComboBox();
            this.txtOpTime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.DateOperetion = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackLyg
            // 
            this.btnBackLyg.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBackLyg.IconColor = System.Drawing.Color.Black;
            this.btnBackLyg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackLyg.Location = new System.Drawing.Point(1169, 696);
            this.btnBackLyg.Name = "btnBackLyg";
            this.btnBackLyg.Size = new System.Drawing.Size(79, 47);
            this.btnBackLyg.TabIndex = 224;
            this.btnBackLyg.Text = "Back";
            this.btnBackLyg.UseVisualStyleBackColor = true;
            this.btnBackLyg.Click += new System.EventHandler(this.btnBackLyg_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.AccessibleName = "cmbGender";
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.cmbGender.BaseColor = System.Drawing.Color.White;
            this.cmbGender.BorderColor = System.Drawing.Color.Silver;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(177, 258);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbGender.Size = new System.Drawing.Size(129, 26);
            this.cmbGender.TabIndex = 222;
            // 
            // label14
            // 
            this.label14.AccessibleName = "cmbGender";
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 221;
            this.label14.Text = "Gender";
            // 
            // txtPetID
            // 
            this.txtPetID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtPetID.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPetID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPetID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPetID.BorderThickness = 3;
            this.txtPetID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPetID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPetID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPetID.isPassword = false;
            this.txtPetID.Location = new System.Drawing.Point(261, 60);
            this.txtPetID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(89, 32);
            this.txtPetID.TabIndex = 220;
            this.txtPetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 219;
            this.label4.Text = "Pet ID";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtWeight.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtWeight.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWeight.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtWeight.BorderThickness = 3;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWeight.isPassword = false;
            this.txtWeight.Location = new System.Drawing.Point(176, 373);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(154, 32);
            this.txtWeight.TabIndex = 218;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 209;
            this.label1.Text = "Weight";
            // 
            // cmbAllergies
            // 
            this.cmbAllergies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.cmbAllergies.BaseColor = System.Drawing.Color.White;
            this.cmbAllergies.BorderColor = System.Drawing.Color.Silver;
            this.cmbAllergies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAllergies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllergies.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAllergies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAllergies.ForeColor = System.Drawing.Color.Black;
            this.cmbAllergies.FormattingEnabled = true;
            this.cmbAllergies.Items.AddRange(new object[] {
            "no list"});
            this.cmbAllergies.Location = new System.Drawing.Point(179, 414);
            this.cmbAllergies.Name = "cmbAllergies";
            this.cmbAllergies.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAllergies.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAllergies.Size = new System.Drawing.Size(129, 26);
            this.cmbAllergies.TabIndex = 215;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 213;
            this.label10.Text = "Allelrgies";
            // 
            // txtExDisease
            // 
            this.txtExDisease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtExDisease.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtExDisease.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExDisease.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtExDisease.BorderThickness = 3;
            this.txtExDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExDisease.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtExDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExDisease.isPassword = false;
            this.txtExDisease.Location = new System.Drawing.Point(209, 450);
            this.txtExDisease.Margin = new System.Windows.Forms.Padding(4);
            this.txtExDisease.Name = "txtExDisease";
            this.txtExDisease.Size = new System.Drawing.Size(154, 32);
            this.txtExDisease.TabIndex = 211;
            this.txtExDisease.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 210;
            this.label6.Text = "Existing Disease";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 36);
            this.panel3.TabIndex = 207;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 201;
            this.label2.Text = "Patient Information";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(346, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // cmbAnimalBreed
            // 
            this.cmbAnimalBreed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.cmbAnimalBreed.BaseColor = System.Drawing.Color.White;
            this.cmbAnimalBreed.BorderColor = System.Drawing.Color.Silver;
            this.cmbAnimalBreed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimalBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimalBreed.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAnimalBreed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAnimalBreed.ForeColor = System.Drawing.Color.Black;
            this.cmbAnimalBreed.FormattingEnabled = true;
            this.cmbAnimalBreed.Location = new System.Drawing.Point(176, 334);
            this.cmbAnimalBreed.Name = "cmbAnimalBreed";
            this.cmbAnimalBreed.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAnimalBreed.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAnimalBreed.Size = new System.Drawing.Size(153, 26);
            this.cmbAnimalBreed.TabIndex = 205;
            // 
            // bdayDatepicker
            // 
            this.bdayDatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.bdayDatepicker.BaseColor = System.Drawing.Color.White;
            this.bdayDatepicker.BorderColor = System.Drawing.Color.Silver;
            this.bdayDatepicker.CustomFormat = null;
            this.bdayDatepicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bdayDatepicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bdayDatepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bdayDatepicker.ForeColor = System.Drawing.Color.Black;
            this.bdayDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdayDatepicker.Location = new System.Drawing.Point(176, 213);
            this.bdayDatepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.bdayDatepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.bdayDatepicker.Name = "bdayDatepicker";
            this.bdayDatepicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.bdayDatepicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bdayDatepicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bdayDatepicker.OnPressedColor = System.Drawing.Color.Black;
            this.bdayDatepicker.Size = new System.Drawing.Size(153, 31);
            this.bdayDatepicker.TabIndex = 204;
            this.bdayDatepicker.Text = "8/14/2021";
            this.bdayDatepicker.Value = new System.DateTime(2021, 8, 14, 13, 50, 22, 159);
            // 
            // cmbAnimalSpecies
            // 
            this.cmbAnimalSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.cmbAnimalSpecies.BaseColor = System.Drawing.Color.White;
            this.cmbAnimalSpecies.BorderColor = System.Drawing.Color.Silver;
            this.cmbAnimalSpecies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimalSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimalSpecies.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAnimalSpecies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAnimalSpecies.ForeColor = System.Drawing.Color.Black;
            this.cmbAnimalSpecies.FormattingEnabled = true;
            this.cmbAnimalSpecies.Items.AddRange(new object[] {
            "DOG",
            "CAT",
            "BIRD"});
            this.cmbAnimalSpecies.Location = new System.Drawing.Point(176, 294);
            this.cmbAnimalSpecies.Name = "cmbAnimalSpecies";
            this.cmbAnimalSpecies.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAnimalSpecies.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAnimalSpecies.Size = new System.Drawing.Size(129, 26);
            this.cmbAnimalSpecies.TabIndex = 203;
            this.cmbAnimalSpecies.SelectedIndexChanged += new System.EventHandler(this.cmbAnimalSpecies_SelectedIndexChanged);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtAge.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAge.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAge.BorderThickness = 3;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.isPassword = false;
            this.txtAge.Location = new System.Drawing.Point(176, 165);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(154, 32);
            this.txtAge.TabIndex = 165;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(52, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 19);
            this.label20.TabIndex = 159;
            this.label20.Text = "Pet Age";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(52, 220);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 19);
            this.label21.TabIndex = 200;
            this.label21.Text = "Pet Birthdate ";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtPatientName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPatientName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPatientName.BorderThickness = 3;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientName.isPassword = false;
            this.txtPatientName.Location = new System.Drawing.Point(176, 125);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(154, 32);
            this.txtPatientName.TabIndex = 162;
            this.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(52, 334);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 19);
            this.label22.TabIndex = 199;
            this.label22.Text = "Animal Breed";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.cmbGender);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtPetID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtWeight);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbAllergies);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtExDisease);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cmbAnimalBreed);
            this.panel2.Controls.Add(this.bdayDatepicker);
            this.panel2.Controls.Add(this.cmbAnimalSpecies);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtPatientName);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Location = new System.Drawing.Point(281, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 500);
            this.panel2.TabIndex = 225;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(52, 138);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 19);
            this.label25.TabIndex = 154;
            this.label25.Text = "Patient Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(52, 296);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 19);
            this.label24.TabIndex = 197;
            this.label24.Text = "Animal Species";
            // 
            // btnSaveLy
            // 
            this.btnSaveLy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSaveLy.IconColor = System.Drawing.Color.Black;
            this.btnSaveLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveLy.Location = new System.Drawing.Point(1254, 696);
            this.btnSaveLy.Name = "btnSaveLy";
            this.btnSaveLy.Size = new System.Drawing.Size(79, 47);
            this.btnSaveLy.TabIndex = 223;
            this.btnSaveLy.Text = "Save";
            this.btnSaveLy.UseVisualStyleBackColor = true;
            this.btnSaveLy.Click += new System.EventHandler(this.btnSaveLy_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.iconButton2);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1366, 69);
            this.gunaShadowPanel1.TabIndex = 220;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.No;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(1308, 16);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(43, 34);
            this.iconButton2.TabIndex = 95;
            this.iconButton2.Text = "X";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(42, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(236, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Update Patient Info";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.Controls.Add(this.txtOwnersname);
            this.panel5.Controls.Add(this.txtPhoneNumber);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtAddress);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(703, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 257);
            this.panel5.TabIndex = 222;
            // 
            // txtOwnersname
            // 
            this.txtOwnersname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtOwnersname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOwnersname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOwnersname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOwnersname.BorderThickness = 3;
            this.txtOwnersname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnersname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOwnersname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOwnersname.isPassword = false;
            this.txtOwnersname.Location = new System.Drawing.Point(154, 70);
            this.txtOwnersname.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwnersname.Name = "txtOwnersname";
            this.txtOwnersname.Size = new System.Drawing.Size(154, 32);
            this.txtOwnersname.TabIndex = 213;
            this.txtOwnersname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPhoneNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPhoneNumber.BorderThickness = 3;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNumber.isPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(154, 112);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(154, 32);
            this.txtPhoneNumber.TabIndex = 212;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 211;
            this.label8.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtAddress.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAddress.BorderThickness = 3;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(154, 155);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 32);
            this.txtAddress.TabIndex = 162;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.iconPictureBox3);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(384, 36);
            this.panel6.TabIndex = 207;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 23);
            this.label11.TabIndex = 201;
            this.label11.Text = "Owners Information";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(346, 4);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 0;
            this.iconPictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 201;
            this.label12.Text = "Phone Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 19);
            this.label13.TabIndex = 154;
            this.label13.Text = "Owners Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbOperations);
            this.panel1.Controls.Add(this.txtOpTime);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.DateOperetion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(703, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 231);
            this.panel1.TabIndex = 221;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 211;
            this.label7.Text = "Operation Time";
            // 
            // cmbOperations
            // 
            this.cmbOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.cmbOperations.BaseColor = System.Drawing.Color.White;
            this.cmbOperations.BorderColor = System.Drawing.Color.Silver;
            this.cmbOperations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperations.FocusedColor = System.Drawing.Color.Empty;
            this.cmbOperations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOperations.ForeColor = System.Drawing.Color.Black;
            this.cmbOperations.FormattingEnabled = true;
            this.cmbOperations.Items.AddRange(new object[] {
            "Lygaeidae"});
            this.cmbOperations.Location = new System.Drawing.Point(154, 70);
            this.cmbOperations.Name = "cmbOperations";
            this.cmbOperations.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbOperations.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbOperations.Size = new System.Drawing.Size(129, 26);
            this.cmbOperations.TabIndex = 209;
            // 
            // txtOpTime
            // 
            this.txtOpTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.txtOpTime.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOpTime.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOpTime.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOpTime.BorderThickness = 3;
            this.txtOpTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpTime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOpTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOpTime.isPassword = false;
            this.txtOpTime.Location = new System.Drawing.Point(154, 159);
            this.txtOpTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpTime.Name = "txtOpTime";
            this.txtOpTime.Size = new System.Drawing.Size(154, 32);
            this.txtOpTime.TabIndex = 162;
            this.txtOpTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 36);
            this.panel4.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 201;
            this.label3.Text = "Surgery Information";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(226)))));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(346, 4);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // DateOperetion
            // 
            this.DateOperetion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.DateOperetion.BaseColor = System.Drawing.Color.White;
            this.DateOperetion.BorderColor = System.Drawing.Color.Silver;
            this.DateOperetion.CustomFormat = null;
            this.DateOperetion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateOperetion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateOperetion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateOperetion.ForeColor = System.Drawing.Color.Black;
            this.DateOperetion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOperetion.Location = new System.Drawing.Point(154, 112);
            this.DateOperetion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateOperetion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateOperetion.Name = "DateOperetion";
            this.DateOperetion.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateOperetion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateOperetion.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateOperetion.OnPressedColor = System.Drawing.Color.Black;
            this.DateOperetion.Size = new System.Drawing.Size(106, 31);
            this.DateOperetion.TabIndex = 206;
            this.DateOperetion.Text = "9/9/2021";
            this.DateOperetion.Value = new System.DateTime(2021, 9, 9, 14, 54, 26, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 201;
            this.label5.Text = "Operation Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 154;
            this.label9.Text = "Operation";
            // 
            // LygaeidaeUpdatefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.btnBackLyg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSaveLy);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LygaeidaeUpdatefrm";
            this.Text = "LygaeidaeUpdatefrm";
            this.Load += new System.EventHandler(this.LygaeidaeUpdatefrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBackLyg;
        private Guna.UI.WinForms.GunaComboBox cmbGender;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPetID;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtWeight;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbAllergies;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtExDisease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI.WinForms.GunaComboBox cmbAnimalBreed;
        private Guna.UI.WinForms.GunaDateTimePicker bdayDatepicker;
        private Guna.UI.WinForms.GunaComboBox cmbAnimalSpecies;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAge;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPatientName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private FontAwesome.Sharp.IconButton btnSaveLy;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOwnersname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhoneNumber;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox cmbOperations;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOpTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Guna.UI.WinForms.GunaDateTimePicker DateOperetion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}