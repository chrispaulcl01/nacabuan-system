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
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.rvReciept = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtCashierName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(1040, 69);
            this.gunaShadowPanel1.TabIndex = 94;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(1292, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 44);
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
            this.gunaLabel2.Location = new System.Drawing.Point(42, 22);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(329, 29);
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
            this.txtOwnersName.Location = new System.Drawing.Point(313, 162);
            this.txtOwnersName.Margin = new System.Windows.Forms.Padding(4);
            this.txtOwnersName.Name = "txtOwnersName";
            this.txtOwnersName.Size = new System.Drawing.Size(222, 32);
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
            this.txtPetID.Location = new System.Drawing.Point(101, 78);
            this.txtPetID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(89, 30);
            this.txtPetID.TabIndex = 232;
            this.txtPetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(24, 82);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 23);
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
            this.txtPatientName.Location = new System.Drawing.Point(313, 213);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(222, 32);
            this.txtPatientName.TabIndex = 230;
            this.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(186, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 19);
            this.label19.TabIndex = 229;
            this.label19.Text = "Owners Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(186, 222);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 19);
            this.label25.TabIndex = 228;
            this.label25.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 235;
            this.label1.Text = "Total Amount Fee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 234;
            this.label2.Text = "Amount Pay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 238;
            this.label3.Text = "Change:";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.Enabled = false;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(199, 66);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(95, 2);
            this.gunaLinePanel1.TabIndex = 240;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.Enabled = false;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(199, 117);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(95, 2);
            this.gunaLinePanel2.TabIndex = 241;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel3.Enabled = false;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.Location = new System.Drawing.Point(199, 171);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(95, 2);
            this.gunaLinePanel3.TabIndex = 242;
            // 
            // txtTotalAmountfee
            // 
            this.txtTotalAmountfee.BackColor = System.Drawing.Color.White;
            this.txtTotalAmountfee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAmountfee.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmountfee.Location = new System.Drawing.Point(199, 41);
            this.txtTotalAmountfee.Name = "txtTotalAmountfee";
            this.txtTotalAmountfee.Size = new System.Drawing.Size(100, 23);
            this.txtTotalAmountfee.TabIndex = 243;
            // 
            // txtAmountpay
            // 
            this.txtAmountpay.BackColor = System.Drawing.Color.White;
            this.txtAmountpay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountpay.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountpay.Location = new System.Drawing.Point(199, 93);
            this.txtAmountpay.Name = "txtAmountpay";
            this.txtAmountpay.Size = new System.Drawing.Size(100, 23);
            this.txtAmountpay.TabIndex = 244;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.White;
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChange.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(201, 148);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(100, 23);
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
            this.gunaPanel1.Location = new System.Drawing.Point(181, 328);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(345, 290);
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
            this.btnGenerate.Location = new System.Drawing.Point(170, 207);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnGenerate.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnGenerate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnHoverImage = null;
            this.btnGenerate.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerate.Size = new System.Drawing.Size(114, 50);
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
            this.btnSave.Location = new System.Drawing.Point(849, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.btnSave.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(99, 40);
            this.btnSave.TabIndex = 251;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.gunaGradientButton4.Location = new System.Drawing.Point(744, 610);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.MistyRose;
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.Salmon;
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(99, 40);
            this.gunaGradientButton4.TabIndex = 249;
            this.gunaGradientButton4.Text = "BACK";
            this.gunaGradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rvReciept
            // 
            this.rvReciept.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reciept.rdlc";
            this.rvReciept.Location = new System.Drawing.Point(664, 99);
            this.rvReciept.Margin = new System.Windows.Forms.Padding(2);
            this.rvReciept.Name = "rvReciept";
            this.rvReciept.Size = new System.Drawing.Size(350, 502);
            this.rvReciept.TabIndex = 253;
            this.rvReciept.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // txtCashierName
            // 
            this.txtCashierName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCashierName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCashierName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCashierName.BorderThickness = 3;
            this.txtCashierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashierName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCashierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCashierName.isPassword = false;
            this.txtCashierName.Location = new System.Drawing.Point(313, 262);
            this.txtCashierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashierName.Name = "txtCashierName";
            this.txtCashierName.Size = new System.Drawing.Size(222, 32);
            this.txtCashierName.TabIndex = 255;
            this.txtCashierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(183, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 256;
            this.label4.Text = "Cashier name";
            // 
            // PaymentTransactfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._68_687504_s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCashierName);
            this.Controls.Add(this.rvReciept);
            this.Controls.Add(this.btnSave);
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
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Microsoft.Reporting.WinForms.ReportViewer rvReciept;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCashierName;
        private System.Windows.Forms.Label label4;
    }
}