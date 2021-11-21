
namespace WindowsFormsApplication1
{
    partial class Operation
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
            this.btnPregnacy = new FontAwesome.Sharp.IconButton();
            this.btnEyeOP = new FontAwesome.Sharp.IconButton();
            this.btnEarsOP = new FontAwesome.Sharp.IconButton();
            this.btnMammaryOP = new FontAwesome.Sharp.IconButton();
            this.btnCrastration = new FontAwesome.Sharp.IconButton();
            this.btnLygaeide = new FontAwesome.Sharp.IconButton();
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
            this.gunaShadowPanel1.TabIndex = 92;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(15, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(116, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Operations";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // btnPregnacy
            // 
            this.btnPregnacy.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pregnancy;
            this.btnPregnacy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPregnacy.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregnacy.ForeColor = System.Drawing.Color.White;
            this.btnPregnacy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPregnacy.IconColor = System.Drawing.Color.Black;
            this.btnPregnacy.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnPregnacy.Location = new System.Drawing.Point(0, 44);
            this.btnPregnacy.Name = "btnPregnacy";
            this.btnPregnacy.Size = new System.Drawing.Size(170, 403);
            this.btnPregnacy.TabIndex = 93;
            this.btnPregnacy.Text = "Pregnacy/ Cesarean";
            this.btnPregnacy.UseVisualStyleBackColor = true;
            this.btnPregnacy.Click += new System.EventHandler(this.btnPregnacy_Click);
            // 
            // btnEyeOP
            // 
            this.btnEyeOP.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Untitled;
            this.btnEyeOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEyeOP.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEyeOP.ForeColor = System.Drawing.Color.White;
            this.btnEyeOP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEyeOP.IconColor = System.Drawing.Color.Black;
            this.btnEyeOP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEyeOP.Location = new System.Drawing.Point(173, 44);
            this.btnEyeOP.Name = "btnEyeOP";
            this.btnEyeOP.Size = new System.Drawing.Size(170, 403);
            this.btnEyeOP.TabIndex = 94;
            this.btnEyeOP.Text = "Operation in Eyes";
            this.btnEyeOP.UseVisualStyleBackColor = true;
            this.btnEyeOP.Click += new System.EventHandler(this.btnEyeOP_Click);
            // 
            // btnEarsOP
            // 
            this.btnEarsOP.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dogear;
            this.btnEarsOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEarsOP.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarsOP.ForeColor = System.Drawing.Color.White;
            this.btnEarsOP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEarsOP.IconColor = System.Drawing.Color.Black;
            this.btnEarsOP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEarsOP.Location = new System.Drawing.Point(347, 44);
            this.btnEarsOP.Name = "btnEarsOP";
            this.btnEarsOP.Size = new System.Drawing.Size(170, 403);
            this.btnEarsOP.TabIndex = 95;
            this.btnEarsOP.Text = "Operation in Ears";
            this.btnEarsOP.UseVisualStyleBackColor = true;
            this.btnEarsOP.Click += new System.EventHandler(this.btnEarsOP_Click);
            // 
            // btnMammaryOP
            // 
            this.btnMammaryOP.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cat_and_dog;
            this.btnMammaryOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMammaryOP.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMammaryOP.ForeColor = System.Drawing.Color.White;
            this.btnMammaryOP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMammaryOP.IconColor = System.Drawing.Color.Black;
            this.btnMammaryOP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMammaryOP.Location = new System.Drawing.Point(522, 44);
            this.btnMammaryOP.Name = "btnMammaryOP";
            this.btnMammaryOP.Size = new System.Drawing.Size(170, 403);
            this.btnMammaryOP.TabIndex = 96;
            this.btnMammaryOP.Text = "Operation of Mammary Gland or Tumor";
            this.btnMammaryOP.UseVisualStyleBackColor = true;
            this.btnMammaryOP.Click += new System.EventHandler(this.btnMammaryOP_Click);
            // 
            // btnCrastration
            // 
            this.btnCrastration.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dog1;
            this.btnCrastration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrastration.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrastration.ForeColor = System.Drawing.Color.White;
            this.btnCrastration.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCrastration.IconColor = System.Drawing.Color.Black;
            this.btnCrastration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrastration.Location = new System.Drawing.Point(698, 44);
            this.btnCrastration.Name = "btnCrastration";
            this.btnCrastration.Size = new System.Drawing.Size(170, 403);
            this.btnCrastration.TabIndex = 97;
            this.btnCrastration.Text = "Crastration";
            this.btnCrastration.UseVisualStyleBackColor = true;
            this.btnCrastration.Click += new System.EventHandler(this.btnCrastration_Click);
            // 
            // btnLygaeide
            // 
            this.btnLygaeide.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.meow;
            this.btnLygaeide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLygaeide.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLygaeide.ForeColor = System.Drawing.Color.White;
            this.btnLygaeide.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLygaeide.IconColor = System.Drawing.Color.Black;
            this.btnLygaeide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLygaeide.Location = new System.Drawing.Point(873, 44);
            this.btnLygaeide.Name = "btnLygaeide";
            this.btnLygaeide.Size = new System.Drawing.Size(170, 403);
            this.btnLygaeide.TabIndex = 98;
            this.btnLygaeide.Text = "Lygaeidae";
            this.btnLygaeide.UseVisualStyleBackColor = true;
            this.btnLygaeide.Click += new System.EventHandler(this.btnLygaeide_Click);
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 447);
            this.Controls.Add(this.btnLygaeide);
            this.Controls.Add(this.btnCrastration);
            this.Controls.Add(this.btnMammaryOP);
            this.Controls.Add(this.btnEarsOP);
            this.Controls.Add(this.btnEyeOP);
            this.Controls.Add(this.btnPregnacy);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operation";
            this.Text = "Operation";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private FontAwesome.Sharp.IconButton btnPregnacy;
        private FontAwesome.Sharp.IconButton btnEyeOP;
        private FontAwesome.Sharp.IconButton btnEarsOP;
        private FontAwesome.Sharp.IconButton btnMammaryOP;
        private FontAwesome.Sharp.IconButton btnCrastration;
        private FontAwesome.Sharp.IconButton btnLygaeide;
    }
}