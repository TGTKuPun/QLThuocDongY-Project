using BUS;
using Config;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frm_SignIn : Form
    {
        public frm_SignIn(string username, string password)
        {
            InitializeComponent();
            txt_username.Text = username;
            txt_password.Text = password;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
            Application.Exit();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Config_Settings.Server) || string.IsNullOrEmpty(Config_Settings.Database))
            {
                MessageBox.Show("Config is missing! Please configure the system first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            BUS_FormLogin bus_FormLogin = new BUS_FormLogin();

            // Return object userInfo and check whether the user is admin or not
            DTO_FormLogin user = bus_FormLogin.checkLogin(username, password, out bool isAdmin);

            if (user != null) // Success
            {
                if (isAdmin)
                {
                    MessageBox.Show($"Hello Admin !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm_Menu menu = new frm_Menu(username, password);
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Hello {username} !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm_uMenu user_Menu = new frm_uMenu(user.USERID, username, password);
                    user_Menu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            /*Reset content state*/
            txt_username.Clear();
            txt_password.Clear();
            /*Adjust the border's color*/
            txt_username.FocusedState.BorderColor = Color.Silver;
            txt_password.FocusedState.BorderColor = Color.Silver;
            txt_username.Focus();
        }

        private void lb_changePassword_Click(object sender, EventArgs e)
        {
            frm_ChangePass form = new frm_ChangePass(this);
            this.Hide();
            form.ShowDialog();
        }

        private void frm_SignIn_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
