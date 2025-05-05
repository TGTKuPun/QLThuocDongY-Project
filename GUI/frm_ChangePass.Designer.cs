namespace GUI
{
    partial class frm_ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChangePass));
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_old_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_ChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.btn_GoBack = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_new_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btn_exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(86, -78);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(373, 148);
            this.guna2CircleButton1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.label1.Font = new System.Drawing.Font("Roboto SemiCondensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESET";
            // 
            // txt_email
            // 
            this.txt_email.BorderRadius = 20;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Roboto Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_email.IconRight")));
            this.txt_email.IconRightOffset = new System.Drawing.Point(15, 0);
            this.txt_email.Location = new System.Drawing.Point(82, 132);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_email.PlaceholderText = "Your Email";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(373, 53);
            this.txt_email.TabIndex = 0;
            // 
            // txt_old_password
            // 
            this.txt_old_password.BorderRadius = 20;
            this.txt_old_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_old_password.DefaultText = "";
            this.txt_old_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_old_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_old_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_old_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_old_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_old_password.Font = new System.Drawing.Font("Roboto Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_old_password.ForeColor = System.Drawing.Color.Black;
            this.txt_old_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_old_password.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_old_password.IconRight")));
            this.txt_old_password.IconRightOffset = new System.Drawing.Point(15, 0);
            this.txt_old_password.Location = new System.Drawing.Point(82, 215);
            this.txt_old_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_old_password.Name = "txt_old_password";
            this.txt_old_password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_old_password.PlaceholderText = "New Password";
            this.txt_old_password.SelectedText = "";
            this.txt_old_password.Size = new System.Drawing.Size(373, 53);
            this.txt_old_password.TabIndex = 1;
            this.txt_old_password.UseSystemPasswordChar = true;
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BorderRadius = 20;
            this.btn_ChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChangePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btn_ChangePass.Font = new System.Drawing.Font("Roboto SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btn_ChangePass.Location = new System.Drawing.Point(82, 359);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(373, 54);
            this.btn_ChangePass.TabIndex = 3;
            this.btn_ChangePass.Text = "Change Password";
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.AutoSize = true;
            this.btn_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoBack.Font = new System.Drawing.Font("Roboto SemiCondensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btn_GoBack.Location = new System.Drawing.Point(227, 429);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(114, 34);
            this.btn_GoBack.TabIndex = 4;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_new_password
            // 
            this.txt_new_password.BorderRadius = 20;
            this.txt_new_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_new_password.DefaultText = "";
            this.txt_new_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_new_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_new_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_new_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_new_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_new_password.Font = new System.Drawing.Font("Roboto Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_password.ForeColor = System.Drawing.Color.Black;
            this.txt_new_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_new_password.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_new_password.IconRight")));
            this.txt_new_password.IconRightOffset = new System.Drawing.Point(15, 0);
            this.txt_new_password.Location = new System.Drawing.Point(82, 276);
            this.txt_new_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_new_password.PlaceholderText = "Type Again New Password";
            this.txt_new_password.SelectedText = "";
            this.txt_new_password.Size = new System.Drawing.Size(373, 53);
            this.txt_new_password.TabIndex = 2;
            this.txt_new_password.UseSystemPasswordChar = true;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btn_exit.Font = new System.Drawing.Font("Roboto SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(466, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_exit.Size = new System.Drawing.Size(59, 58);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_2);
            // 
            // frm_ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(537, 522);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_new_password);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.txt_old_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ChangePassword_Part_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_old_password;
        private Guna.UI2.WinForms.Guna2Button btn_ChangePass;
        private System.Windows.Forms.Label btn_GoBack;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txt_new_password;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_exit;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}