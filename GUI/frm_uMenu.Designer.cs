namespace GUI
{
    partial class frm_uMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_uMenu));
            this.btn_changePassword = new System.Windows.Forms.Panel();
            this.btn_editOrder = new System.Windows.Forms.Button();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.lb_signOut = new System.Windows.Forms.Label();
            this.lb_userID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_changePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btn_changePassword.Controls.Add(this.btn_editOrder);
            this.btn_changePassword.Controls.Add(this.btn_cancelOrder);
            this.btn_changePassword.Controls.Add(this.btn_placeOrder);
            this.btn_changePassword.Controls.Add(this.lb_signOut);
            this.btn_changePassword.Controls.Add(this.lb_userID);
            this.btn_changePassword.Controls.Add(this.pictureBox1);
            this.btn_changePassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_changePassword.Location = new System.Drawing.Point(0, 0);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(176, 610);
            this.btn_changePassword.TabIndex = 0;
            // 
            // btn_editOrder
            // 
            this.btn_editOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btn_editOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btn_editOrder.Location = new System.Drawing.Point(0, 239);
            this.btn_editOrder.Name = "btn_editOrder";
            this.btn_editOrder.Size = new System.Drawing.Size(173, 49);
            this.btn_editOrder.TabIndex = 7;
            this.btn_editOrder.Text = "Update Order";
            this.btn_editOrder.UseVisualStyleBackColor = false;
            this.btn_editOrder.Click += new System.EventHandler(this.btn_editOrder_Click);
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(43)))), ((int)(((byte)(41)))));
            this.btn_cancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btn_cancelOrder.Location = new System.Drawing.Point(0, 193);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(173, 49);
            this.btn_cancelOrder.TabIndex = 6;
            this.btn_cancelOrder.Text = "Cancel Order";
            this.btn_cancelOrder.UseVisualStyleBackColor = false;
            this.btn_cancelOrder.Click += new System.EventHandler(this.btn_cancelOrder_Click);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btn_placeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btn_placeOrder.Location = new System.Drawing.Point(0, 147);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(173, 49);
            this.btn_placeOrder.TabIndex = 3;
            this.btn_placeOrder.Text = "Place Order";
            this.btn_placeOrder.UseVisualStyleBackColor = false;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // lb_signOut
            // 
            this.lb_signOut.AutoSize = true;
            this.lb_signOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.lb_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_signOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.lb_signOut.Location = new System.Drawing.Point(4, 577);
            this.lb_signOut.Name = "lb_signOut";
            this.lb_signOut.Size = new System.Drawing.Size(114, 29);
            this.lb_signOut.TabIndex = 2;
            this.lb_signOut.Text = "Sign Out";
            this.lb_signOut.Click += new System.EventHandler(this.lb_signOut_Click);
            // 
            // lb_userID
            // 
            this.lb_userID.AutoSize = true;
            this.lb_userID.Location = new System.Drawing.Point(33, 101);
            this.lb_userID.Name = "lb_userID";
            this.lb_userID.Size = new System.Drawing.Size(178, 22);
            this.lb_userID.TabIndex = 1;
            this.lb_userID.Text = "USER ID: Loading ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // grd
            // 
            this.grd.BackgroundColor = System.Drawing.Color.White;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(179, 68);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 51;
            this.grd.RowTemplate.Height = 24;
            this.grd.Size = new System.Drawing.Size(897, 537);
            this.grd.TabIndex = 1;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(525, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "LIST OF ORDER";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1033, -9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_exit.Size = new System.Drawing.Size(59, 58);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 12;
            this.guna2Elipse2.TargetControl = this.grd;
            // 
            // frm_uMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1080, 610);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.btn_changePassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_uMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_uMenu";
            this.Load += new System.EventHandler(this.frm_uMenu_Load);
            this.btn_changePassword.ResumeLayout(false);
            this.btn_changePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btn_changePassword;
        private System.Windows.Forms.Label lb_userID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label lb_signOut;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton btn_exit;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Button btn_editOrder;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}