
namespace WindowsFormsApplication1
{
    partial class ReportTable
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
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.rprtReportTable = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.iconButton3);
            this.gunaShadowPanel1.Controls.Add(this.iconButton2);
            this.gunaShadowPanel1.Controls.Add(this.iconButton1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(-1, -2);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1104, 69);
            this.gunaShadowPanel1.TabIndex = 119;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(989, 17);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(41, 35);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "X";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(-14, -13);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1045, 13);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(46, 45);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "X";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(42, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(105, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Reports";
            // 
            // rprtReportTable
            // 
            this.rprtReportTable.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.rprtReportTable.rdlc";
            this.rprtReportTable.Location = new System.Drawing.Point(271, 73);
            this.rprtReportTable.Margin = new System.Windows.Forms.Padding(2);
            this.rprtReportTable.Name = "rprtReportTable";
            this.rprtReportTable.Size = new System.Drawing.Size(500, 520);
            this.rprtReportTable.TabIndex = 120;
            this.rprtReportTable.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // ReportTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 620);
            this.Controls.Add(this.rprtReportTable);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportTable";
            this.Text = "ReportTable";
            this.Load += new System.EventHandler(this.ReportTable_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Microsoft.Reporting.WinForms.ReportViewer rprtReportTable;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}