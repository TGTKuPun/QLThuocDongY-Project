namespace GUI
{
    partial class frm_uPayment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_uPayment));
            this.lb_id = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_proceedPayment = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grp_personalInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbbank = new System.Windows.Forms.Label();
            this.lbcash = new System.Windows.Forms.Label();
            this.radio_bank = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.radio_cash = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_firstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_pname = new System.Windows.Forms.Label();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_totalPrice = new System.Windows.Forms.Label();
            this.lb_dateOrder = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.grp_personalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(16, 652);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(89, 18);
            this.lb_id.TabIndex = 42;
            this.lb_id.Text = "Unknown ID";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BorderRadius = 12;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(90)))), ((int)(((byte)(56)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(353, 580);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(199, 61);
            this.btn_cancel.TabIndex = 35;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_proceedPayment
            // 
            this.btn_proceedPayment.BorderRadius = 12;
            this.btn_proceedPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_proceedPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_proceedPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_proceedPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_proceedPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btn_proceedPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceedPayment.ForeColor = System.Drawing.Color.White;
            this.btn_proceedPayment.Location = new System.Drawing.Point(28, 580);
            this.btn_proceedPayment.Name = "btn_proceedPayment";
            this.btn_proceedPayment.Size = new System.Drawing.Size(290, 61);
            this.btn_proceedPayment.TabIndex = 34;
            this.btn_proceedPayment.Text = "Proceed Payment";
            this.btn_proceedPayment.Click += new System.EventHandler(this.btn_proceedPayment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.label7.Location = new System.Drawing.Point(462, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 36);
            this.label7.TabIndex = 33;
            this.label7.Text = "2/2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAYMENT PROCESS";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.guna2Panel1.Location = new System.Drawing.Point(13, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(932, 62);
            this.guna2Panel1.TabIndex = 24;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            // 
            // grp_personalInfo
            // 
            this.grp_personalInfo.Controls.Add(this.lbbank);
            this.grp_personalInfo.Controls.Add(this.lbcash);
            this.grp_personalInfo.Controls.Add(this.radio_bank);
            this.grp_personalInfo.Controls.Add(this.radio_cash);
            this.grp_personalInfo.Controls.Add(this.label8);
            this.grp_personalInfo.Controls.Add(this.txt_firstname);
            this.grp_personalInfo.Controls.Add(this.label6);
            this.grp_personalInfo.Controls.Add(this.txt_phone);
            this.grp_personalInfo.Controls.Add(this.label4);
            this.grp_personalInfo.Controls.Add(this.txt_email);
            this.grp_personalInfo.Controls.Add(this.label2);
            this.grp_personalInfo.Controls.Add(this.txt_lastname);
            this.grp_personalInfo.Controls.Add(this.label5);
            this.grp_personalInfo.Controls.Add(this.txt_address);
            this.grp_personalInfo.Controls.Add(this.label3);
            this.grp_personalInfo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.grp_personalInfo.FillColor = System.Drawing.Color.Transparent;
            this.grp_personalInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grp_personalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grp_personalInfo.Location = new System.Drawing.Point(19, 131);
            this.grp_personalInfo.Name = "grp_personalInfo";
            this.grp_personalInfo.Size = new System.Drawing.Size(544, 428);
            this.grp_personalInfo.TabIndex = 43;
            this.grp_personalInfo.Text = "DETAIL INFORMATION";
            // 
            // lbbank
            // 
            this.lbbank.AutoSize = true;
            this.lbbank.Location = new System.Drawing.Point(43, 392);
            this.lbbank.Name = "lbbank";
            this.lbbank.Size = new System.Drawing.Size(69, 20);
            this.lbbank.TabIndex = 62;
            this.lbbank.Text = "Bank QR";
            // 
            // lbcash
            // 
            this.lbcash.AutoSize = true;
            this.lbcash.Location = new System.Drawing.Point(42, 352);
            this.lbcash.Name = "lbcash";
            this.lbcash.Size = new System.Drawing.Size(42, 20);
            this.lbcash.TabIndex = 61;
            this.lbcash.Text = "Cash";
            // 
            // radio_bank
            // 
            this.radio_bank.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_bank.CheckedState.BorderThickness = 0;
            this.radio_bank.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_bank.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio_bank.Location = new System.Drawing.Point(16, 392);
            this.radio_bank.Name = "radio_bank";
            this.radio_bank.Size = new System.Drawing.Size(20, 20);
            this.radio_bank.TabIndex = 60;
            this.radio_bank.Text = "guna2CustomRadioButton2";
            this.radio_bank.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio_bank.UncheckedState.BorderThickness = 2;
            this.radio_bank.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio_bank.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radio_cash
            // 
            this.radio_cash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_cash.CheckedState.BorderThickness = 0;
            this.radio_cash.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio_cash.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio_cash.Location = new System.Drawing.Point(16, 352);
            this.radio_cash.Name = "radio_cash";
            this.radio_cash.Size = new System.Drawing.Size(20, 20);
            this.radio_cash.TabIndex = 59;
            this.radio_cash.Text = "guna2CustomRadioButton1";
            this.radio_cash.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio_cash.UncheckedState.BorderThickness = 2;
            this.radio_cash.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio_cash.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Payment method";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_firstname.DefaultText = "";
            this.txt_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstname.Location = new System.Drawing.Point(15, 79);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.PlaceholderText = "";
            this.txt_firstname.SelectedText = "";
            this.txt_firstname.Size = new System.Drawing.Size(249, 36);
            this.txt_firstname.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Phone number";
            // 
            // txt_phone
            // 
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultText = "";
            this.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Location = new System.Drawing.Point(287, 165);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(246, 36);
            this.txt_phone.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(14, 165);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(249, 36);
            this.txt_email.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Lastname";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lastname.DefaultText = "";
            this.txt_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastname.Location = new System.Drawing.Point(287, 79);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PlaceholderText = "";
            this.txt_lastname.SelectedText = "";
            this.txt_lastname.Size = new System.Drawing.Size(246, 36);
            this.txt_lastname.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(14, 251);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(519, 36);
            this.txt_address.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Firstname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(581, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 29);
            this.label11.TabIndex = 44;
            this.label11.Text = "Order";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.FillColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(586, 171);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(359, 10);
            this.guna2Panel2.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(582, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 22);
            this.label12.TabIndex = 46;
            this.label12.Text = "Product Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(815, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 22);
            this.label13.TabIndex = 47;
            this.label13.Text = "Quantity";
            // 
            // lb_pname
            // 
            this.lb_pname.AutoSize = true;
            this.lb_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pname.Location = new System.Drawing.Point(594, 228);
            this.lb_pname.Name = "lb_pname";
            this.lb_pname.Size = new System.Drawing.Size(104, 18);
            this.lb_pname.TabIndex = 48;
            this.lb_pname.Text = "Loading Name";
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.Location = new System.Drawing.Point(829, 228);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(118, 18);
            this.lb_quantity.TabIndex = 49;
            this.lb_quantity.Text = "Loading Quantity";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(594, 296);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(98, 18);
            this.lb_price.TabIndex = 50;
            this.lb_price.Text = "Loading Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(582, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 22);
            this.label17.TabIndex = 51;
            this.label17.Text = "Price";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderRadius = 8;
            this.guna2Panel3.FillColor = System.Drawing.Color.Black;
            this.guna2Panel3.Location = new System.Drawing.Point(586, 337);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(359, 10);
            this.guna2Panel3.TabIndex = 52;
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPrice.Location = new System.Drawing.Point(581, 368);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(242, 29);
            this.lb_totalPrice.TabIndex = 53;
            this.lb_totalPrice.Text = "Loading Total Price";
            // 
            // lb_dateOrder
            // 
            this.lb_dateOrder.AutoSize = true;
            this.lb_dateOrder.Location = new System.Drawing.Point(661, 136);
            this.lb_dateOrder.Name = "lb_dateOrder";
            this.lb_dateOrder.Size = new System.Drawing.Size(165, 22);
            this.lb_dateOrder.TabIndex = 54;
            this.lb_dateOrder.Text = "Loading Order date";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this;
            // 
            // frm_uPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(957, 681);
            this.Controls.Add(this.lb_dateOrder);
            this.Controls.Add(this.lb_totalPrice);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.lb_pname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grp_personalInfo);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_proceedPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_uPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_uPayment";
            this.Load += new System.EventHandler(this.frm_uPayment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.grp_personalInfo.ResumeLayout(false);
            this.grp_personalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_proceedPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox grp_personalInfo;
        private Guna.UI2.WinForms.Guna2TextBox txt_firstname;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_lastname;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbbank;
        private System.Windows.Forms.Label lbcash;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radio_bank;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radio_cash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_pname;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lb_totalPrice;
        private System.Windows.Forms.Label lb_dateOrder;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}