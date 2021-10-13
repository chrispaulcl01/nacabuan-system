namespace WindowsFormsApplication1
{
    partial class PaymentTransactfrm
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
            this.button5 = new System.Windows.Forms.Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtOwnersName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPetID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPatientName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.txtTotalAmountfee = new System.Windows.Forms.TextBox();
            this.txtAmountpay = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnGenerate = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSave = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPrint = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.button5);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1821, 85);
            this.gunaShadowPanel1.TabIndex = 94;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(1723, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 54);
            this.button5.TabIndex = 83;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaLabel2.Location = new System.Drawing.Point(56, 27);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(411, 38);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "PAYMENT TRANSACTION";
            // 
            // txtOwnersName
            // 
            this.txtOwnersName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOwnersName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOwnersName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtOwnersName.BorderThickness = 3;
            this.txtOwnersName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnersName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOwnersName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOwnersName.isPassword = false;
            this.txtOwnersName.Location = new System.Drawing.Point(405, 240);
            this.txtOwnersName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOwnersName.Name = "txtOwnersName";
            this.txtOwnersName.Size = new System.Drawing.Size(296, 39);
            this.txtOwnersName.TabIndex = 233;
            this.txtOwnersName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPetID
            // 
            this.txtPetID.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPetID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPetID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPetID.BorderThickness = 3;
            this.txtPetID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPetID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPetID.isPassword = false;
            this.txtPetID.Location = new System.Drawing.Point(351, 143);
            this.txtPetID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(221, 37);
            this.txtPetID.TabIndex = 232;
            this.txtPetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.MistyRose;
            this.label26.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(248, 148);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 29);
            this.label26.TabIndex = 231;
            this.label26.Text = "Pet ID:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPatientName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPatientName.BorderThickness = 3;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPatientName.isPassword = false;
            this.txtPatientName.Location = new System.Drawing.Point(405, 303);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(296, 39);
            this.txtPatientName.TabIndex = 230;
            this.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.MistyRose;
            this.label19.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(236, 249);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 24);
            this.label19.TabIndex = 229;
            this.label19.Text = "Owners Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.MistyRose;
            this.label25.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(236, 314);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(143, 24);
            this.label25.TabIndex = 228;
            this.label25.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 27);
            this.label1.TabIndex = 235;
            this.label1.Text = "Total Amount Fee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 234;
            this.label2.Text = "Amount Pay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 238;
            this.label3.Text = "Change:";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.Enabled = false;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(265, 81);
            this.gunaLinePanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(127, 2);
            this.gunaLinePanel1.TabIndex = 240;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.Enabled = false;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(265, 144);
            this.gunaLinePanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(127, 2);
            this.gunaLinePanel2.TabIndex = 241;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel3.Enabled = false;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.Location = new System.Drawing.Point(265, 210);
            this.gunaLinePanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(127, 2);
            this.gunaLinePanel3.TabIndex = 242;
            // 
            // txtTotalAmountfee
            // 
            this.txtTotalAmountfee.BackColor = System.Drawing.Color.White;
            this.txtTotalAmountfee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAmountfee.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmountfee.Location = new System.Drawing.Point(265, 50);
            this.txtTotalAmountfee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalAmountfee.Name = "txtTotalAmountfee";
            this.txtTotalAmountfee.Size = new System.Drawing.Size(133, 28);
            this.txtTotalAmountfee.TabIndex = 243;
            // 
            // txtAmountpay
            // 
            this.txtAmountpay.BackColor = System.Drawing.Color.White;
            this.txtAmountpay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountpay.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountpay.Location = new System.Drawing.Point(265, 114);
            this.txtAmountpay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountpay.Name = "txtAmountpay";
            this.txtAmountpay.Size = new System.Drawing.Size(133, 28);
            this.txtAmountpay.TabIndex = 244;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.White;
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChange.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(268, 182);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(133, 28);
            this.txtChange.TabIndex = 245;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnGenerate);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.txtChange);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.txtAmountpay);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.txtTotalAmountfee);
            this.gunaPanel1.Controls.Add(this.gunaLinePanel1);
            this.gunaPanel1.Controls.Add(this.gunaLinePanel3);
            this.gunaPanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaPanel1.Location = new System.Drawing.Point(241, 404);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(460, 357);
            this.gunaPanel1.TabIndex = 246;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AnimationHoverSpeed = 0.07F;
            this.btnGenerate.AnimationSpeed = 0.03F;
            this.btnGenerate.BackColor = System.Drawing.Color.MistyRose;
            this.btnGenerate.BaseColor1 = System.Drawing.Color.LightPink;
            this.btnGenerate.BaseColor2 = System.Drawing.Color.MistyRose;
            this.btnGenerate.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerate.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Image = null;
            this.btnGenerate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenerate.Location = new System.Drawing.Point(227, 255);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnGenerate.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnGenerate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnHoverImage = null;
            this.btnGenerate.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerate.Size = new System.Drawing.Size(152, 62);
            this.btnGenerate.TabIndex = 246;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.MistyRose;
            this.btnSave.BaseColor1 = System.Drawing.Color.Green;
            this.btnSave.BaseColor2 = System.Drawing.Color.YellowGreen;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(1220, 753);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnSave.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(132, 49);
            this.btnSave.TabIndex = 251;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.MistyRose;
            this.btnPrint.BaseColor1 = System.Drawing.Color.Red;
            this.btnPrint.BaseColor2 = System.Drawing.Color.Salmon;
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = null;
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.Location = new System.Drawing.Point(1360, 753);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnPrint.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Size = new System.Drawing.Size(132, 49);
            this.btnPrint.TabIndex = 250;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BackColor = System.Drawing.Color.MistyRose;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.Blue;
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.DodgerBlue;
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Image = null;
            this.gunaGradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(1080, 753);
            this.gunaGradientButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(132, 49);
            this.gunaGradientButton4.TabIndex = 249;
            this.gunaGradientButton4.Text = "BACK";
            this.gunaGradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(1075, 103);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(417, 618);
            this.reportViewer2.TabIndex = 253;
            // 
            // PaymentTransactfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1821, 922);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gunaGradientButton4);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.txtOwnersName);
            this.Controls.Add(this.txtPetID);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaymentTransactfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentTransactfrm";
            this.Load += new System.EventHandler(this.PaymentTransactfrm_Load);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Button button5;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOwnersName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPetID;
        private System.Windows.Forms.Label label26;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPatientName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        private System.Windows.Forms.TextBox txtTotalAmountfee;
        private System.Windows.Forms.TextBox txtAmountpay;
        private System.Windows.Forms.TextBox txtChange;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGradientButton btnGenerate;
        private Guna.UI.WinForms.GunaGradientButton btnSave;
        private Guna.UI.WinForms.GunaGradientButton btnPrint;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}