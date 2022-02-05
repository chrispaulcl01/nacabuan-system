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
            this.cmbLoadOperations = new Guna.UI.WinForms.GunaComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1016, 69);
            this.gunaShadowPanel1.TabIndex = 92;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(42, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(251, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "CLINIC CALENDAR";
            // 
            // dateSchedule
            // 
            this.dateSchedule.CalendarFont = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSchedule.CustomFormat = "MM/dd/yy";
            this.dateSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSchedule.Location = new System.Drawing.Point(592, 104);
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
            this.btnLoad.Font = new System.Drawing.Font("Rockwell Extra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Image = null;
            this.btnLoad.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLoad.Location = new System.Drawing.Point(517, 101);
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
            this.gridBookingSchedule.Size = new System.Drawing.Size(763, 423);
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
            this.gridBookingSchedule.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridBookingSchedule_CellMouseDoubleClick);
            // 
            // cmbLoadOperations
            // 
            this.cmbLoadOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.cmbLoadOperations.BaseColor = System.Drawing.Color.White;
            this.cmbLoadOperations.BorderColor = System.Drawing.Color.Silver;
            this.cmbLoadOperations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoadOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoadOperations.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLoadOperations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoadOperations.ForeColor = System.Drawing.Color.Black;
            this.cmbLoadOperations.FormattingEnabled = true;
            this.cmbLoadOperations.Items.AddRange(new object[] {
            "Vaccination",
            "Crastration",
            "Lygaeidae"});
            this.cmbLoadOperations.Location = new System.Drawing.Point(113, 116);
            this.cmbLoadOperations.Name = "cmbLoadOperations";
            this.cmbLoadOperations.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbLoadOperations.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbLoadOperations.Size = new System.Drawing.Size(129, 26);
            this.cmbLoadOperations.TabIndex = 211;
            this.cmbLoadOperations.SelectedIndexChanged += new System.EventHandler(this.cmbLoadOperations_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 210;
            this.label9.Text = "Operation";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 580);
            this.Controls.Add(this.cmbLoadOperations);
            this.Controls.Add(this.label9);
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
        private Guna.UI.WinForms.GunaComboBox cmbLoadOperations;
        private System.Windows.Forms.Label label9;
    }
}