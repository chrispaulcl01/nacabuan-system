namespace WindowsFormsApplication1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnTransHistory = new FontAwesome.Sharp.IconButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Cliniccal_btn = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.PatientList_btn = new FontAwesome.Sharp.IconButton();
            this.Home_panel = new System.Windows.Forms.Panel();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaGradient2Panel1.Controls.Add(this.label3);
            this.gunaGradient2Panel1.Controls.Add(this.label4);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.LightCoral;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.HotPink;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1366, 135);
            this.gunaGradient2Panel1.TabIndex = 5;
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(16, 3);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(120, 124);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 83;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            this.gunaCirclePictureBox1.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(200, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "CB Nacabuan Vetenary Clinic";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(178, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(521, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pet Medical Information System";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.btnTransHistory);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.Cliniccal_btn);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.PatientList_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 614);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnReports.IconColor = System.Drawing.Color.Black;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 30;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(18, 413);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(189, 48);
            this.btnReports.TabIndex = 205;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = null;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(7, 555);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(200, 47);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStaff.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnStaff.IconColor = System.Drawing.Color.Black;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.IconSize = 30;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(18, 353);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(189, 48);
            this.btnStaff.TabIndex = 204;
            this.btnStaff.Text = "        STAFF MEMBERS";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(37, 55);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(154, 17);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "MAIN NAVIGATION";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // btnTransHistory
            // 
            this.btnTransHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransHistory.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnTransHistory.IconColor = System.Drawing.Color.Black;
            this.btnTransHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransHistory.IconSize = 30;
            this.btnTransHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransHistory.Location = new System.Drawing.Point(18, 294);
            this.btnTransHistory.Name = "btnTransHistory";
            this.btnTransHistory.Size = new System.Drawing.Size(189, 48);
            this.btnTransHistory.TabIndex = 203;
            this.btnTransHistory.Text = "      TRANSACTION HISTORY";
            this.btnTransHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransHistory.UseVisualStyleBackColor = false;
            this.btnTransHistory.Click += new System.EventHandler(this.btnTransHistory_Click_1);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(59, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 18);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // Cliniccal_btn
            // 
            this.Cliniccal_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cliniccal_btn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliniccal_btn.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.Cliniccal_btn.IconColor = System.Drawing.Color.Black;
            this.Cliniccal_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cliniccal_btn.IconSize = 30;
            this.Cliniccal_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cliniccal_btn.Location = new System.Drawing.Point(18, 180);
            this.Cliniccal_btn.Name = "Cliniccal_btn";
            this.Cliniccal_btn.Size = new System.Drawing.Size(189, 48);
            this.Cliniccal_btn.TabIndex = 202;
            this.Cliniccal_btn.Text = " CLINIC CALENDAR";
            this.Cliniccal_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cliniccal_btn.UseVisualStyleBackColor = false;
            this.Cliniccal_btn.Click += new System.EventHandler(this.Cliniccal_btn_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.btnDashboard.IconColor = System.Drawing.Color.Black;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(18, 116);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(189, 48);
            this.btnDashboard.TabIndex = 201;
            this.btnDashboard.Text = "SERVICES AND OPERATIONS";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // PatientList_btn
            // 
            this.PatientList_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PatientList_btn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientList_btn.IconChar = FontAwesome.Sharp.IconChar.List;
            this.PatientList_btn.IconColor = System.Drawing.Color.Black;
            this.PatientList_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PatientList_btn.IconSize = 30;
            this.PatientList_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatientList_btn.Location = new System.Drawing.Point(18, 239);
            this.PatientList_btn.Name = "PatientList_btn";
            this.PatientList_btn.Size = new System.Drawing.Size(189, 48);
            this.PatientList_btn.TabIndex = 202;
            this.PatientList_btn.Text = " PATIENT LIST";
            this.PatientList_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatientList_btn.UseVisualStyleBackColor = false;
            this.PatientList_btn.Click += new System.EventHandler(this.PatientList_btn_Click);
            // 
            // Home_panel
            // 
            this.Home_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Home_panel.BackColor = System.Drawing.Color.Snow;
            this.Home_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Home_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_panel.Location = new System.Drawing.Point(222, 135);
            this.Home_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Home_panel.Name = "Home_panel";
            this.Home_panel.Size = new System.Drawing.Size(1144, 614);
            this.Home_panel.TabIndex = 7;
            this.Home_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Home_panel_Paint);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.Home_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Font = new System.Drawing.Font("Papyrus", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Panel Home_panel;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnStaff;
        private FontAwesome.Sharp.IconButton btnTransHistory;
        private FontAwesome.Sharp.IconButton Cliniccal_btn;
        private FontAwesome.Sharp.IconButton PatientList_btn;
        private FontAwesome.Sharp.IconButton btnDashboard;
    }
}