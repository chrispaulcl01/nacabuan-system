namespace WindowsFormsApplication1
{
    partial class SchedService
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
            this.btnLygaeide = new FontAwesome.Sharp.IconButton();
            this.btnCrastration = new FontAwesome.Sharp.IconButton();
            this.btnVaccination = new FontAwesome.Sharp.IconButton();
            this.btnDeworming = new FontAwesome.Sharp.IconButton();
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
            this.gunaLabel2.Size = new System.Drawing.Size(181, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Schedule Services";
            // 
            // btnLygaeide
            // 
            this.btnLygaeide.BackColor = System.Drawing.Color.LightCoral;
            this.btnLygaeide.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.veterinarian;
            this.btnLygaeide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLygaeide.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLygaeide.ForeColor = System.Drawing.Color.White;
            this.btnLygaeide.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLygaeide.IconColor = System.Drawing.Color.Black;
            this.btnLygaeide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLygaeide.Location = new System.Drawing.Point(564, 98);
            this.btnLygaeide.Name = "btnLygaeide";
            this.btnLygaeide.Size = new System.Drawing.Size(170, 283);
            this.btnLygaeide.TabIndex = 100;
            this.btnLygaeide.Text = "Lygaeidae";
            this.btnLygaeide.UseVisualStyleBackColor = false;
            this.btnLygaeide.Click += new System.EventHandler(this.btnLygaeide_Click);
            // 
            // btnCrastration
            // 
            this.btnCrastration.BackColor = System.Drawing.Color.LightCoral;
            this.btnCrastration.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.vet__1_;
            this.btnCrastration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrastration.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrastration.ForeColor = System.Drawing.Color.White;
            this.btnCrastration.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCrastration.IconColor = System.Drawing.Color.Black;
            this.btnCrastration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrastration.Location = new System.Drawing.Point(315, 98);
            this.btnCrastration.Name = "btnCrastration";
            this.btnCrastration.Size = new System.Drawing.Size(170, 283);
            this.btnCrastration.TabIndex = 99;
            this.btnCrastration.Text = "Crastration";
            this.btnCrastration.UseVisualStyleBackColor = false;
            this.btnCrastration.Click += new System.EventHandler(this.btnCrastration_Click);
            // 
            // btnVaccination
            // 
            this.btnVaccination.BackColor = System.Drawing.Color.LightCoral;
            this.btnVaccination.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.vaccine;
            this.btnVaccination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaccination.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaccination.ForeColor = System.Drawing.Color.White;
            this.btnVaccination.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVaccination.IconColor = System.Drawing.Color.Black;
            this.btnVaccination.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnVaccination.Location = new System.Drawing.Point(56, 98);
            this.btnVaccination.Name = "btnVaccination";
            this.btnVaccination.Size = new System.Drawing.Size(170, 283);
            this.btnVaccination.TabIndex = 101;
            this.btnVaccination.Text = "Vaccination";
            this.btnVaccination.UseVisualStyleBackColor = false;
            this.btnVaccination.Click += new System.EventHandler(this.btnVaccination_Click);
            // 
            // btnDeworming
            // 
            this.btnDeworming.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeworming.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.groomer1;
            this.btnDeworming.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeworming.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeworming.ForeColor = System.Drawing.Color.White;
            this.btnDeworming.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeworming.IconColor = System.Drawing.Color.Black;
            this.btnDeworming.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeworming.Location = new System.Drawing.Point(816, 98);
            this.btnDeworming.Name = "btnDeworming";
            this.btnDeworming.Size = new System.Drawing.Size(170, 283);
            this.btnDeworming.TabIndex = 105;
            this.btnDeworming.Text = "Deworming";
            this.btnDeworming.UseVisualStyleBackColor = false;
            this.btnDeworming.Click += new System.EventHandler(this.btnDeworming_Click);
            // 
            // SchedService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 447);
            this.Controls.Add(this.btnDeworming);
            this.Controls.Add(this.btnVaccination);
            this.Controls.Add(this.btnLygaeide);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btnCrastration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchedService";
            this.Text = "SchedService";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private FontAwesome.Sharp.IconButton btnLygaeide;
        private FontAwesome.Sharp.IconButton btnCrastration;
        private FontAwesome.Sharp.IconButton btnVaccination;
        private FontAwesome.Sharp.IconButton btnDeworming;
    }
}