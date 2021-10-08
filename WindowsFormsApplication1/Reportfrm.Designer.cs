namespace WindowsFormsApplication1
{
    partial class btnPReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.ChartDatePick = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtTotalpatient = new System.Windows.Forms.TextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtTotalBird = new System.Windows.Forms.TextBox();
            this.txtTotalCat = new System.Windows.Forms.TextBox();
            this.txtTotalDog = new System.Windows.Forms.TextBox();
            this.txtTotalYear = new System.Windows.Forms.TextBox();
            this.txtTotalMonth = new System.Windows.Forms.TextBox();
            this.txtTotalDay = new System.Windows.Forms.TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ChartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartDog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartBird = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBird)).BeginInit();
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
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1000, 64);
            this.gunaShadowPanel1.TabIndex = 94;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(34, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(105, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Reports";
            // 
            // ChartDatePick
            // 
            this.ChartDatePick.BaseColor = System.Drawing.Color.White;
            this.ChartDatePick.BorderColor = System.Drawing.Color.Silver;
            this.ChartDatePick.CustomFormat = "MM/dd/yy";
            this.ChartDatePick.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ChartDatePick.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ChartDatePick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChartDatePick.ForeColor = System.Drawing.Color.Black;
            this.ChartDatePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ChartDatePick.Location = new System.Drawing.Point(12, 70);
            this.ChartDatePick.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ChartDatePick.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ChartDatePick.Name = "ChartDatePick";
            this.ChartDatePick.OnHoverBaseColor = System.Drawing.Color.White;
            this.ChartDatePick.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ChartDatePick.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ChartDatePick.OnPressedColor = System.Drawing.Color.Black;
            this.ChartDatePick.Size = new System.Drawing.Size(223, 30);
            this.ChartDatePick.TabIndex = 128;
            this.ChartDatePick.Text = "09/07/21";
            this.ChartDatePick.Value = new System.DateTime(2021, 9, 7, 15, 27, 40, 704);
            // 
            // txtTotalpatient
            // 
            this.txtTotalpatient.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalpatient.Location = new System.Drawing.Point(879, 451);
            this.txtTotalpatient.Name = "txtTotalpatient";
            this.txtTotalpatient.Size = new System.Drawing.Size(88, 32);
            this.txtTotalpatient.TabIndex = 127;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(694, 454);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(120, 21);
            this.gunaLabel8.TabIndex = 126;
            this.gunaLabel8.Text = "Total Patient:";
            // 
            // txtTotalBird
            // 
            this.txtTotalBird.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBird.Location = new System.Drawing.Point(879, 402);
            this.txtTotalBird.Name = "txtTotalBird";
            this.txtTotalBird.Size = new System.Drawing.Size(88, 32);
            this.txtTotalBird.TabIndex = 125;
            // 
            // txtTotalCat
            // 
            this.txtTotalCat.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCat.Location = new System.Drawing.Point(879, 311);
            this.txtTotalCat.Name = "txtTotalCat";
            this.txtTotalCat.Size = new System.Drawing.Size(88, 32);
            this.txtTotalCat.TabIndex = 124;
            // 
            // txtTotalDog
            // 
            this.txtTotalDog.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDog.Location = new System.Drawing.Point(879, 356);
            this.txtTotalDog.Name = "txtTotalDog";
            this.txtTotalDog.Size = new System.Drawing.Size(88, 32);
            this.txtTotalDog.TabIndex = 123;
            // 
            // txtTotalYear
            // 
            this.txtTotalYear.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalYear.Location = new System.Drawing.Point(241, 475);
            this.txtTotalYear.Name = "txtTotalYear";
            this.txtTotalYear.Size = new System.Drawing.Size(88, 32);
            this.txtTotalYear.TabIndex = 122;
            // 
            // txtTotalMonth
            // 
            this.txtTotalMonth.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMonth.Location = new System.Drawing.Point(241, 434);
            this.txtTotalMonth.Name = "txtTotalMonth";
            this.txtTotalMonth.Size = new System.Drawing.Size(88, 32);
            this.txtTotalMonth.TabIndex = 121;
            // 
            // txtTotalDay
            // 
            this.txtTotalDay.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDay.Location = new System.Drawing.Point(241, 389);
            this.txtTotalDay.Name = "txtTotalDay";
            this.txtTotalDay.Size = new System.Drawing.Size(88, 32);
            this.txtTotalDay.TabIndex = 120;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(19, 480);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(202, 21);
            this.gunaLabel7.TabIndex = 119;
            this.gunaLabel7.Text = "Total Sales of the Year:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(19, 438);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(216, 21);
            this.gunaLabel6.TabIndex = 118;
            this.gunaLabel6.Text = "Total Sales of the Month:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(692, 406);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(184, 21);
            this.label.TabIndex = 117;
            this.label.Text = "Total Patient ofBirds:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(694, 315);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(179, 21);
            this.gunaLabel4.TabIndex = 116;
            this.gunaLabel4.Text = "Total Patient ofCats:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(684, 360);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(189, 21);
            this.gunaLabel3.TabIndex = 115;
            this.gunaLabel3.Text = "Total Patient of Dogs:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(19, 393);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(196, 21);
            this.gunaLabel1.TabIndex = 114;
            this.gunaLabel1.Text = "Total Sales of the Day:";
            // 
            // ChartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartSales.Legends.Add(legend1);
            this.ChartSales.Location = new System.Drawing.Point(12, 114);
            this.ChartSales.Name = "ChartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartSales.Series.Add(series1);
            this.ChartSales.Size = new System.Drawing.Size(300, 269);
            this.ChartSales.TabIndex = 129;
            this.ChartSales.Text = "chart1";
            // 
            // ChartDog
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartDog.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartDog.Legends.Add(legend2);
            this.ChartDog.Location = new System.Drawing.Point(374, 79);
            this.ChartDog.Name = "ChartDog";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartDog.Series.Add(series2);
            this.ChartDog.Size = new System.Drawing.Size(289, 175);
            this.ChartDog.TabIndex = 130;
            this.ChartDog.Text = "chart2";
            // 
            // ChartCat
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartCat.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartCat.Legends.Add(legend3);
            this.ChartCat.Location = new System.Drawing.Point(689, 79);
            this.ChartCat.Name = "ChartCat";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartCat.Series.Add(series3);
            this.ChartCat.Size = new System.Drawing.Size(289, 175);
            this.ChartCat.TabIndex = 131;
            this.ChartCat.Text = "chart3";
            // 
            // ChartBird
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartBird.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartBird.Legends.Add(legend4);
            this.ChartBird.Location = new System.Drawing.Point(374, 284);
            this.ChartBird.Name = "ChartBird";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ChartBird.Series.Add(series4);
            this.ChartBird.Size = new System.Drawing.Size(289, 175);
            this.ChartBird.TabIndex = 132;
            this.ChartBird.Text = "chart4";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheck.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnCheck.IconColor = System.Drawing.Color.Green;
            this.btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheck.IconSize = 25;
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCheck.Location = new System.Drawing.Point(237, 68);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 34);
            this.btnCheck.TabIndex = 201;
            this.btnCheck.Text = "Check";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(879, 522);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(85, 36);
            this.iconButton1.TabIndex = 202;
            this.iconButton1.Text = "Print Reports";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnPReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.ChartBird);
            this.Controls.Add(this.ChartCat);
            this.Controls.Add(this.ChartDog);
            this.Controls.Add(this.ChartSales);
            this.Controls.Add(this.ChartDatePick);
            this.Controls.Add(this.txtTotalpatient);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtTotalBird);
            this.Controls.Add(this.txtTotalCat);
            this.Controls.Add(this.txtTotalDog);
            this.Controls.Add(this.txtTotalYear);
            this.Controls.Add(this.txtTotalMonth);
            this.Controls.Add(this.txtTotalDay);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btnPReport";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Reportfrm_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker ChartDatePick;
        private System.Windows.Forms.TextBox txtTotalpatient;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.TextBox txtTotalBird;
        private System.Windows.Forms.TextBox txtTotalCat;
        private System.Windows.Forms.TextBox txtTotalDog;
        private System.Windows.Forms.TextBox txtTotalYear;
        private System.Windows.Forms.TextBox txtTotalMonth;
        private System.Windows.Forms.TextBox txtTotalDay;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel label;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDog;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCat;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBird;
        private FontAwesome.Sharp.IconButton btnCheck;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}