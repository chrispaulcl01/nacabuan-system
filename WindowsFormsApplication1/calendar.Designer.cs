namespace WindowsFormsApplication1
{
    partial class calendar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dateSchedule = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new Guna.UI.WinForms.GunaButton();
            this.gridBookingSchedule = new Guna.UI.WinForms.GunaDataGridView();
            this.btnLygaeidae = new FontAwesome.Sharp.IconButton();
            this.btnCrastration = new FontAwesome.Sharp.IconButton();
            this.btnVaccine = new FontAwesome.Sharp.IconButton();
            this.btnDeworming = new FontAwesome.Sharp.IconButton();
            this.txtSchedIdentifier = new System.Windows.Forms.TextBox();
            this.txtPatientToday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookingSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1146, 69);
            this.gunaShadowPanel1.TabIndex = 92;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(42, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(239, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "CLINIC CALENDAR";
            // 
            // dateSchedule
            // 
            this.dateSchedule.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSchedule.CustomFormat = "MM/dd/yy";
            this.dateSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSchedule.Location = new System.Drawing.Point(902, 86);
            this.dateSchedule.Name = "dateSchedule";
            this.dateSchedule.Size = new System.Drawing.Size(188, 20);
            this.dateSchedule.TabIndex = 99;
            // 
            // btnLoad
            // 
            this.btnLoad.AnimationHoverSpeed = 0.07F;
            this.btnLoad.AnimationSpeed = 0.03F;
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BaseColor = System.Drawing.Color.Transparent;
            this.btnLoad.BorderColor = System.Drawing.Color.Black;
            this.btnLoad.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Image = null;
            this.btnLoad.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLoad.Location = new System.Drawing.Point(827, 83);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLoad.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoad.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoad.OnHoverImage = null;
            this.btnLoad.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoad.Size = new System.Drawing.Size(71, 27);
            this.btnLoad.TabIndex = 116;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gridBookingSchedule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridBookingSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBookingSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBookingSchedule.BackgroundColor = System.Drawing.Color.White;
            this.gridBookingSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBookingSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridBookingSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBookingSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridBookingSchedule.ColumnHeadersHeight = 55;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBookingSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridBookingSchedule.EnableHeadersVisualStyles = false;
            this.gridBookingSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridBookingSchedule.Location = new System.Drawing.Point(17, 145);
            this.gridBookingSchedule.Name = "gridBookingSchedule";
            this.gridBookingSchedule.ReadOnly = true;
            this.gridBookingSchedule.RowHeadersVisible = false;
            this.gridBookingSchedule.RowTemplate.Height = 45;
            this.gridBookingSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookingSchedule.Size = new System.Drawing.Size(1083, 463);
            this.gridBookingSchedule.TabIndex = 117;
            this.gridBookingSchedule.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridBookingSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridBookingSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridBookingSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridBookingSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridBookingSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridBookingSchedule.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridBookingSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridBookingSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridBookingSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridBookingSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridBookingSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridBookingSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridBookingSchedule.ThemeStyle.HeaderStyle.Height = 55;
            this.gridBookingSchedule.ThemeStyle.ReadOnly = true;
            this.gridBookingSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridBookingSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridBookingSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridBookingSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridBookingSchedule.ThemeStyle.RowsStyle.Height = 45;
            this.gridBookingSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridBookingSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridBookingSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookingSchedule_CellContentClick);
            this.gridBookingSchedule.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookingSchedule_CellContentDoubleClick);
            this.gridBookingSchedule.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridBookingSchedule_CellMouseDoubleClick);
            // 
            // btnLygaeidae
            // 
            this.btnLygaeidae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLygaeidae.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLygaeidae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLygaeidae.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLygaeidae.IconColor = System.Drawing.Color.Black;
            this.btnLygaeidae.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLygaeidae.Location = new System.Drawing.Point(202, 101);
            this.btnLygaeidae.Name = "btnLygaeidae";
            this.btnLygaeidae.Size = new System.Drawing.Size(95, 43);
            this.btnLygaeidae.TabIndex = 214;
            this.btnLygaeidae.Text = "Lygaeidae";
            this.btnLygaeidae.UseVisualStyleBackColor = false;
            this.btnLygaeidae.Click += new System.EventHandler(this.btnLygaeidae_Click);
            // 
            // btnCrastration
            // 
            this.btnCrastration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCrastration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrastration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrastration.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCrastration.IconColor = System.Drawing.Color.Black;
            this.btnCrastration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrastration.Location = new System.Drawing.Point(110, 101);
            this.btnCrastration.Name = "btnCrastration";
            this.btnCrastration.Size = new System.Drawing.Size(95, 43);
            this.btnCrastration.TabIndex = 213;
            this.btnCrastration.Text = "Crastration";
            this.btnCrastration.UseVisualStyleBackColor = false;
            this.btnCrastration.Click += new System.EventHandler(this.btnCrastration_Click);
            // 
            // btnVaccine
            // 
            this.btnVaccine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaccine.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVaccine.IconColor = System.Drawing.Color.Black;
            this.btnVaccine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVaccine.Location = new System.Drawing.Point(17, 101);
            this.btnVaccine.Name = "btnVaccine";
            this.btnVaccine.Size = new System.Drawing.Size(96, 43);
            this.btnVaccine.TabIndex = 212;
            this.btnVaccine.Text = "Vaccine";
            this.btnVaccine.UseVisualStyleBackColor = false;
            this.btnVaccine.Click += new System.EventHandler(this.btnVaccine_Click);
            // 
            // btnDeworming
            // 
            this.btnDeworming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeworming.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeworming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeworming.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeworming.IconColor = System.Drawing.Color.Black;
            this.btnDeworming.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeworming.Location = new System.Drawing.Point(292, 101);
            this.btnDeworming.Name = "btnDeworming";
            this.btnDeworming.Size = new System.Drawing.Size(95, 43);
            this.btnDeworming.TabIndex = 215;
            this.btnDeworming.Text = "Deworming";
            this.btnDeworming.UseVisualStyleBackColor = false;
            this.btnDeworming.Click += new System.EventHandler(this.btnDeworming_Click);
            // 
            // txtSchedIdentifier
            // 
            this.txtSchedIdentifier.Location = new System.Drawing.Point(394, 119);
            this.txtSchedIdentifier.Name = "txtSchedIdentifier";
            this.txtSchedIdentifier.Size = new System.Drawing.Size(100, 20);
            this.txtSchedIdentifier.TabIndex = 216;
            // 
            // txtPatientToday
            // 
            this.txtPatientToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientToday.Location = new System.Drawing.Point(1021, 110);
            this.txtPatientToday.Name = "txtPatientToday";
            this.txtPatientToday.Size = new System.Drawing.Size(69, 26);
            this.txtPatientToday.TabIndex = 217;
            this.txtPatientToday.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(899, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 218;
            this.label1.Text = "Pantients Today:";
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientToday);
            this.Controls.Add(this.txtSchedIdentifier);
            this.Controls.Add(this.btnDeworming);
            this.Controls.Add(this.btnLygaeidae);
            this.Controls.Add(this.btnCrastration);
            this.Controls.Add(this.btnVaccine);
            this.Controls.Add(this.gridBookingSchedule);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dateSchedule);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calendar";
            this.Text = "calendar";
            this.Load += new System.EventHandler(this.calendar_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookingSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DateTimePicker dateSchedule;
        private Guna.UI.WinForms.GunaButton btnLoad;
        private Guna.UI.WinForms.GunaDataGridView gridBookingSchedule;
        private FontAwesome.Sharp.IconButton btnLygaeidae;
        private FontAwesome.Sharp.IconButton btnCrastration;
        private FontAwesome.Sharp.IconButton btnVaccine;
        private FontAwesome.Sharp.IconButton btnDeworming;
        private System.Windows.Forms.TextBox txtSchedIdentifier;
        private System.Windows.Forms.TextBox txtPatientToday;
        private System.Windows.Forms.Label label1;
    }
}