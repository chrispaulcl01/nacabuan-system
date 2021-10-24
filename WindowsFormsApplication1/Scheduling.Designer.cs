
namespace WindowsFormsApplication1
{
    partial class Scheduling
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
            this.btnChechUp = new FontAwesome.Sharp.IconButton();
            this.btnPregnancy = new FontAwesome.Sharp.IconButton();
            this.btnOperation = new FontAwesome.Sharp.IconButton();
            this.panelScheduling = new System.Windows.Forms.Panel();
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
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1102, 69);
            this.gunaShadowPanel1.TabIndex = 93;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(42, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(195, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Scheduling List";
            // 
            // btnChechUp
            // 
            this.btnChechUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnChechUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChechUp.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChechUp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChechUp.IconColor = System.Drawing.Color.Black;
            this.btnChechUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChechUp.Location = new System.Drawing.Point(24, 88);
            this.btnChechUp.Name = "btnChechUp";
            this.btnChechUp.Size = new System.Drawing.Size(92, 54);
            this.btnChechUp.TabIndex = 94;
            this.btnChechUp.Text = "CheckUp";
            this.btnChechUp.UseVisualStyleBackColor = false;
            this.btnChechUp.Click += new System.EventHandler(this.btnChechUp_Click);
            // 
            // btnPregnancy
            // 
            this.btnPregnancy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPregnancy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPregnancy.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregnancy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPregnancy.IconColor = System.Drawing.Color.Black;
            this.btnPregnancy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPregnancy.Location = new System.Drawing.Point(117, 88);
            this.btnPregnancy.Name = "btnPregnancy";
            this.btnPregnancy.Size = new System.Drawing.Size(92, 54);
            this.btnPregnancy.TabIndex = 95;
            this.btnPregnancy.Text = "Pregnancy";
            this.btnPregnancy.UseVisualStyleBackColor = false;
            this.btnPregnancy.Click += new System.EventHandler(this.btnPregnancy_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperation.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOperation.IconColor = System.Drawing.Color.Black;
            this.btnOperation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOperation.Location = new System.Drawing.Point(210, 88);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(92, 54);
            this.btnOperation.TabIndex = 96;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // panelScheduling
            // 
            this.panelScheduling.Location = new System.Drawing.Point(24, 143);
            this.panelScheduling.Name = "panelScheduling";
            this.panelScheduling.Size = new System.Drawing.Size(1047, 447);
            this.panelScheduling.TabIndex = 97;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 620);
            this.Controls.Add(this.panelScheduling);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnPregnancy);
            this.Controls.Add(this.btnChechUp);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private FontAwesome.Sharp.IconButton btnChechUp;
        private FontAwesome.Sharp.IconButton btnPregnancy;
        private FontAwesome.Sharp.IconButton btnOperation;
        private System.Windows.Forms.Panel panelScheduling;
    }
}