namespace WindowsFormsApplication1
{
    partial class Staff_Memberfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cmbLoadServices = new Guna.UI.WinForms.GunaComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gridPatientData = new Guna.UI.WinForms.GunaDataGridView();
            this.btnLoad = new Guna.UI.WinForms.GunaButton();
            this.dateSchedule = new System.Windows.Forms.DateTimePicker();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatientData)).BeginInit();
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
            this.gunaShadowPanel1.TabIndex = 93;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(34, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(169, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Patients Data";
            // 
            // cmbLoadServices
            // 
            this.cmbLoadServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.cmbLoadServices.BaseColor = System.Drawing.Color.White;
            this.cmbLoadServices.BorderColor = System.Drawing.Color.Silver;
            this.cmbLoadServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoadServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoadServices.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLoadServices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoadServices.ForeColor = System.Drawing.Color.Black;
            this.cmbLoadServices.FormattingEnabled = true;
            this.cmbLoadServices.Items.AddRange(new object[] {
            "SkinTreatment",
            "CPT",
            "CDT",
            "BloodParasite",
            "Deworming"});
            this.cmbLoadServices.Location = new System.Drawing.Point(111, 92);
            this.cmbLoadServices.Name = "cmbLoadServices";
            this.cmbLoadServices.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbLoadServices.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbLoadServices.Size = new System.Drawing.Size(129, 26);
            this.cmbLoadServices.TabIndex = 216;
            this.cmbLoadServices.SelectedIndexChanged += new System.EventHandler(this.cmbLoadServices_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 215;
            this.label9.Text = "Service";
            // 
            // gridPatientData
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridPatientData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridPatientData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPatientData.BackgroundColor = System.Drawing.Color.White;
            this.gridPatientData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPatientData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPatientData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPatientData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridPatientData.ColumnHeadersHeight = 55;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPatientData.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridPatientData.EnableHeadersVisualStyles = false;
            this.gridPatientData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPatientData.Location = new System.Drawing.Point(39, 121);
            this.gridPatientData.Name = "gridPatientData";
            this.gridPatientData.ReadOnly = true;
            this.gridPatientData.RowHeadersVisible = false;
            this.gridPatientData.RowTemplate.Height = 45;
            this.gridPatientData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPatientData.Size = new System.Drawing.Size(763, 423);
            this.gridPatientData.TabIndex = 214;
            this.gridPatientData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridPatientData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPatientData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridPatientData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridPatientData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridPatientData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridPatientData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPatientData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPatientData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridPatientData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPatientData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridPatientData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPatientData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridPatientData.ThemeStyle.HeaderStyle.Height = 55;
            this.gridPatientData.ThemeStyle.ReadOnly = true;
            this.gridPatientData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPatientData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPatientData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridPatientData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridPatientData.ThemeStyle.RowsStyle.Height = 45;
            this.gridPatientData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPatientData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnLoad.Location = new System.Drawing.Point(539, 77);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLoad.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoad.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoad.OnHoverImage = null;
            this.btnLoad.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoad.Size = new System.Drawing.Size(71, 27);
            this.btnLoad.TabIndex = 213;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateSchedule
            // 
            this.dateSchedule.CalendarFont = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSchedule.CustomFormat = "MM/dd/yy";
            this.dateSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSchedule.Location = new System.Drawing.Point(614, 80);
            this.dateSchedule.Name = "dateSchedule";
            this.dateSchedule.Size = new System.Drawing.Size(188, 20);
            this.dateSchedule.TabIndex = 212;
            // 
            // Staff_Memberfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.cmbLoadServices);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridPatientData);
            this.Controls.Add(this.dateSchedule);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Memberfrm";
            this.Text = "Staff_Memberfrm";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatientData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cmbLoadServices;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaDataGridView gridPatientData;
        private Guna.UI.WinForms.GunaButton btnLoad;
        private System.Windows.Forms.DateTimePicker dateSchedule;
    }
}