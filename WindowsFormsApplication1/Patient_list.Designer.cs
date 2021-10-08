namespace WindowsFormsApplication1
{
    partial class Patient_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnPListExit = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.GridPatienlist = new Guna.UI.WinForms.GunaDataGridView();
            this.txtPetidPList = new Guna.UI.WinForms.GunaTextBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnView = new FontAwesome.Sharp.IconButton();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPatienlist)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnPListExit);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(-2, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1030, 64);
            this.gunaShadowPanel1.TabIndex = 92;
            // 
            // btnPListExit
            // 
            this.btnPListExit.BackColor = System.Drawing.Color.Transparent;
            this.btnPListExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPListExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPListExit.ForeColor = System.Drawing.Color.Black;
            this.btnPListExit.Location = new System.Drawing.Point(952, 12);
            this.btnPListExit.Name = "btnPListExit";
            this.btnPListExit.Size = new System.Drawing.Size(45, 40);
            this.btnPListExit.TabIndex = 83;
            this.btnPListExit.Text = "X";
            this.btnPListExit.UseVisualStyleBackColor = false;
            this.btnPListExit.Click += new System.EventHandler(this.btnPListExit_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.Location = new System.Drawing.Point(34, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(195, 29);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "PATIENT LISTS";
            // 
            // GridPatienlist
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GridPatienlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridPatienlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPatienlist.BackgroundColor = System.Drawing.Color.White;
            this.GridPatienlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPatienlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridPatienlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPatienlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridPatienlist.ColumnHeadersHeight = 55;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPatienlist.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridPatienlist.EnableHeadersVisualStyles = false;
            this.GridPatienlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridPatienlist.Location = new System.Drawing.Point(24, 145);
            this.GridPatienlist.Name = "GridPatienlist";
            this.GridPatienlist.ReadOnly = true;
            this.GridPatienlist.RowHeadersVisible = false;
            this.GridPatienlist.RowTemplate.Height = 45;
            this.GridPatienlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPatienlist.Size = new System.Drawing.Size(809, 433);
            this.GridPatienlist.TabIndex = 113;
            this.GridPatienlist.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GridPatienlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridPatienlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridPatienlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridPatienlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridPatienlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridPatienlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridPatienlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridPatienlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridPatienlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridPatienlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridPatienlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridPatienlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridPatienlist.ThemeStyle.HeaderStyle.Height = 55;
            this.GridPatienlist.ThemeStyle.ReadOnly = true;
            this.GridPatienlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridPatienlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridPatienlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridPatienlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridPatienlist.ThemeStyle.RowsStyle.Height = 45;
            this.GridPatienlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridPatienlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridPatienlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            this.GridPatienlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPatienlist_CellDoubleClick);
            this.GridPatienlist.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridPatienlist_CellMouseClick);
            this.GridPatienlist.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridPatienlist_CellMouseDoubleClick);
            // 
            // txtPetidPList
            // 
            this.txtPetidPList.BaseColor = System.Drawing.Color.White;
            this.txtPetidPList.BorderColor = System.Drawing.Color.Silver;
            this.txtPetidPList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPetidPList.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPetidPList.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPetidPList.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPetidPList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPetidPList.Location = new System.Drawing.Point(835, 70);
            this.txtPetidPList.Name = "txtPetidPList";
            this.txtPetidPList.PasswordChar = '\0';
            this.txtPetidPList.Size = new System.Drawing.Size(160, 30);
            this.txtPetidPList.TabIndex = 119;
            // 
            // txtSearch
            // 
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Size = new System.Drawing.Size(288, 42);
            this.txtSearch.TabIndex = 120;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnNext.IconColor = System.Drawing.Color.Green;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 30;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(318, 79);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 42);
            this.btnNext.TabIndex = 201;
            this.btnNext.Text = "Search";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnView.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnView.IconColor = System.Drawing.Color.Green;
            this.btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnView.IconSize = 30;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(839, 145);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 42);
            this.btnView.TabIndex = 202;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // Patient_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 619);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPetidPList);
            this.Controls.Add(this.GridPatienlist);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Patient_list";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_list_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPatienlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDataGridView GridPatienlist;
        private System.Windows.Forms.Button btnPListExit;
        private Guna.UI.WinForms.GunaTextBox txtPetidPList;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnView;
    }
}