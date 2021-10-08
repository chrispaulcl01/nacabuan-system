
namespace WindowsFormsApplication1
{
    partial class Rxviewer
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
            this.txtRXHistory = new System.Windows.Forms.RichTextBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnPConsultExit = new System.Windows.Forms.Button();
            this.PatientListViewerfrm = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEx = new System.Windows.Forms.Button();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRXHistory
            // 
            this.txtRXHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRXHistory.Location = new System.Drawing.Point(90, 75);
            this.txtRXHistory.Name = "txtRXHistory";
            this.txtRXHistory.Size = new System.Drawing.Size(370, 453);
            this.txtRXHistory.TabIndex = 3;
            this.txtRXHistory.Text = "";
            this.txtRXHistory.TextChanged += new System.EventHandler(this.txtRXHistory_TextChanged);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnEx);
            this.gunaShadowPanel1.Controls.Add(this.btnPConsultExit);
            this.gunaShadowPanel1.Controls.Add(this.PatientListViewerfrm);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(544, 69);
            this.gunaShadowPanel1.TabIndex = 249;
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
            // 
            // PatientListViewerfrm
            // 
            this.PatientListViewerfrm.AutoSize = true;
            this.PatientListViewerfrm.BackColor = System.Drawing.Color.MistyRose;
            this.PatientListViewerfrm.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientListViewerfrm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientListViewerfrm.Location = new System.Drawing.Point(41, 19);
            this.PatientListViewerfrm.Name = "PatientListViewerfrm";
            this.PatientListViewerfrm.Size = new System.Drawing.Size(229, 29);
            this.PatientListViewerfrm.TabIndex = 1;
            this.PatientListViewerfrm.Text = "Patient RX History";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 543);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(544, 23);
            this.flowLayoutPanel1.TabIndex = 250;
            // 
            // btnEx
            // 
            this.btnEx.BackColor = System.Drawing.Color.Transparent;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.Black;
            this.btnEx.Location = new System.Drawing.Point(487, 12);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(45, 39);
            this.btnEx.TabIndex = 251;
            this.btnEx.Text = "X";
            this.btnEx.UseVisualStyleBackColor = false;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // Rxviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(544, 575);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.txtRXHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rxviewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rxviewer";
            this.Load += new System.EventHandler(this.Rxviewer_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtRXHistory;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Button btnPConsultExit;
        private Guna.UI.WinForms.GunaLabel PatientListViewerfrm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEx;
    }
}