namespace WindowsFormsApplication1
{
    partial class frmRX
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRXprinted = new System.Windows.Forms.RichTextBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSaveRX = new Guna.UI.WinForms.GunaGradientButton();
            this.txtEditor = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.MistyRose;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(111, 116);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 17);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Id:";
            // 
            // txtRXprinted
            // 
            this.txtRXprinted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRXprinted.Location = new System.Drawing.Point(615, 113);
            this.txtRXprinted.Name = "txtRXprinted";
            this.txtRXprinted.Size = new System.Drawing.Size(370, 477);
            this.txtRXprinted.TabIndex = 2;
            this.txtRXprinted.Text = "";
            this.txtRXprinted.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.button5);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(-1, 4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1364, 69);
            this.gunaShadowPanel1.TabIndex = 93;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1293, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 43);
            this.button5.TabIndex = 83;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(34, 22);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(58, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "RX.";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(457, 596);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 49);
            this.btnGenerate.TabIndex = 94;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.MistyRose;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.Blue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.DodgerBlue;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(676, 605);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(99, 40);
            this.gunaGradientButton1.TabIndex = 116;
            this.gunaGradientButton1.Text = "BACK";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BackColor = System.Drawing.Color.MistyRose;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.Red;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.Salmon;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Image = null;
            this.gunaGradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(886, 605);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(99, 40);
            this.gunaGradientButton2.TabIndex = 117;
            this.gunaGradientButton2.Text = "PRINT";
            this.gunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveRX
            // 
            this.btnSaveRX.AnimationHoverSpeed = 0.07F;
            this.btnSaveRX.AnimationSpeed = 0.03F;
            this.btnSaveRX.BackColor = System.Drawing.Color.MistyRose;
            this.btnSaveRX.BaseColor1 = System.Drawing.Color.Green;
            this.btnSaveRX.BaseColor2 = System.Drawing.Color.YellowGreen;
            this.btnSaveRX.BorderColor = System.Drawing.Color.Black;
            this.btnSaveRX.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveRX.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRX.ForeColor = System.Drawing.Color.Black;
            this.btnSaveRX.Image = null;
            this.btnSaveRX.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveRX.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveRX.Location = new System.Drawing.Point(781, 605);
            this.btnSaveRX.Name = "btnSaveRX";
            this.btnSaveRX.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnSaveRX.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnSaveRX.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveRX.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveRX.OnHoverImage = null;
            this.btnSaveRX.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveRX.Size = new System.Drawing.Size(99, 40);
            this.btnSaveRX.TabIndex = 118;
            this.btnSaveRX.Text = "SAVE";
            this.btnSaveRX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveRX.Click += new System.EventHandler(this.btnSaveRX_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.BaseColor = System.Drawing.Color.White;
            this.txtEditor.BorderColor = System.Drawing.Color.Silver;
            this.txtEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEditor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEditor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEditor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEditor.Location = new System.Drawing.Point(245, 113);
            this.txtEditor.MultiLine = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.PasswordChar = '\0';
            this.txtEditor.Size = new System.Drawing.Size(339, 477);
            this.txtEditor.TabIndex = 119;
            this.txtEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(110, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 5);
            this.panel1.TabIndex = 120;
            // 
            // frmRX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.btnSaveRX);
            this.Controls.Add(this.gunaGradientButton2);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.txtRXprinted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRX";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRX";
            this.Load += new System.EventHandler(this.frmRX_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtRXprinted;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Button btnGenerate;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaGradientButton btnSaveRX;
        private Guna.UI.WinForms.GunaTextBox txtEditor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}