namespace WindowsFormsApplication1
{
    partial class Services
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnDeworming = new FontAwesome.Sharp.IconButton();
            this.btnBloodTest = new FontAwesome.Sharp.IconButton();
            this.btnCDTest = new FontAwesome.Sharp.IconButton();
            this.btnCPTest = new FontAwesome.Sharp.IconButton();
            this.btnSknTreat = new FontAwesome.Sharp.IconButton();
            this.btnVaccination = new FontAwesome.Sharp.IconButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1047, 43);
            this.gunaShadowPanel1.TabIndex = 93;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(15, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(90, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Services";
            // 
            // btnDeworming
            // 
            this.btnDeworming.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.puppy_deworming_main_768x511;
            this.btnDeworming.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeworming.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeworming.ForeColor = System.Drawing.Color.White;
            this.btnDeworming.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeworming.IconColor = System.Drawing.Color.Black;
            this.btnDeworming.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeworming.Location = new System.Drawing.Point(876, 43);
            this.btnDeworming.Name = "btnDeworming";
            this.btnDeworming.Size = new System.Drawing.Size(170, 403);
            this.btnDeworming.TabIndex = 104;
            this.btnDeworming.Text = "Deworming";
            this.btnDeworming.UseVisualStyleBackColor = true;
            this.btnDeworming.Click += new System.EventHandler(this.btnDeworming_Click);
            // 
            // btnBloodTest
            // 
            this.btnBloodTest.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.blood;
            this.btnBloodTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodTest.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodTest.ForeColor = System.Drawing.Color.White;
            this.btnBloodTest.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBloodTest.IconColor = System.Drawing.Color.Black;
            this.btnBloodTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBloodTest.Location = new System.Drawing.Point(701, 43);
            this.btnBloodTest.Name = "btnBloodTest";
            this.btnBloodTest.Size = new System.Drawing.Size(170, 403);
            this.btnBloodTest.TabIndex = 103;
            this.btnBloodTest.Text = "Test for Blood Parasite";
            this.btnBloodTest.UseVisualStyleBackColor = true;
            this.btnBloodTest.Click += new System.EventHandler(this.btnBloodTest_Click);
            // 
            // btnCDTest
            // 
            this.btnCDTest.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.who_essential_labs920;
            this.btnCDTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCDTest.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDTest.ForeColor = System.Drawing.Color.White;
            this.btnCDTest.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCDTest.IconColor = System.Drawing.Color.Black;
            this.btnCDTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCDTest.Location = new System.Drawing.Point(525, 43);
            this.btnCDTest.Name = "btnCDTest";
            this.btnCDTest.Size = new System.Drawing.Size(170, 403);
            this.btnCDTest.TabIndex = 102;
            this.btnCDTest.Text = " Canine Distemper Test";
            this.btnCDTest.UseVisualStyleBackColor = true;
            this.btnCDTest.Click += new System.EventHandler(this.btnCDTest_Click);
            // 
            // btnCPTest
            // 
            this.btnCPTest.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.lab_test_tubes;
            this.btnCPTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCPTest.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPTest.ForeColor = System.Drawing.Color.White;
            this.btnCPTest.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCPTest.IconColor = System.Drawing.Color.Black;
            this.btnCPTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCPTest.Location = new System.Drawing.Point(350, 43);
            this.btnCPTest.Name = "btnCPTest";
            this.btnCPTest.Size = new System.Drawing.Size(170, 403);
            this.btnCPTest.TabIndex = 101;
            this.btnCPTest.Text = "Canine Parvovirus Test";
            this.btnCPTest.UseVisualStyleBackColor = true;
            this.btnCPTest.Click += new System.EventHandler(this.btnCPTest_Click);
            // 
            // btnSknTreat
            // 
            this.btnSknTreat.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dog11;
            this.btnSknTreat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSknTreat.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSknTreat.ForeColor = System.Drawing.Color.White;
            this.btnSknTreat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSknTreat.IconColor = System.Drawing.Color.Black;
            this.btnSknTreat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSknTreat.Location = new System.Drawing.Point(176, 43);
            this.btnSknTreat.Name = "btnSknTreat";
            this.btnSknTreat.Size = new System.Drawing.Size(170, 403);
            this.btnSknTreat.TabIndex = 100;
            this.btnSknTreat.Text = "Skin Treatment";
            this.btnSknTreat.UseVisualStyleBackColor = true;
            this.btnSknTreat.Click += new System.EventHandler(this.btnSknTreat_Click);
            // 
            // btnVaccination
            // 
            this.btnVaccination.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dogvac;
            this.btnVaccination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaccination.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaccination.ForeColor = System.Drawing.Color.White;
            this.btnVaccination.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVaccination.IconColor = System.Drawing.Color.Black;
            this.btnVaccination.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnVaccination.Location = new System.Drawing.Point(3, 43);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(170, 403);
            this.btnVaccination.TabIndex = 99;
            this.btnVaccination.Text = "Vaccination";
            this.btnVaccination.UseVisualStyleBackColor = true;
            this.btnVaccination.Click += new System.EventHandler(this.btnVaccination_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 447);
            this.Controls.Add(this.btnDeworming);
            this.Controls.Add(this.btnBloodTest);
            this.Controls.Add(this.btnCDTest);
            this.Controls.Add(this.btnCPTest);
            this.Controls.Add(this.btnSknTreat);
            this.Controls.Add(this.btnVaccination);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Services";
            this.Text = "Services";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private FontAwesome.Sharp.IconButton btnDeworming;
        private FontAwesome.Sharp.IconButton btnBloodTest;
        private FontAwesome.Sharp.IconButton btnCDTest;
        private FontAwesome.Sharp.IconButton btnCPTest;
        private FontAwesome.Sharp.IconButton btnSknTreat;
        private FontAwesome.Sharp.IconButton btnVaccination;
    }
}