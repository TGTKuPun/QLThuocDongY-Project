using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Config;

namespace GUI
{
    public partial class frm_Config : Form
    {
        public frm_Config()
        {
            InitializeComponent();
            LoadExistingConfig();
        }

        private void LoadExistingConfig()
        {
            if (File.Exists("config.txt"))
            {
                string[] lines = File.ReadAllLines("config.txt");
                if (lines.Length >= 4)
                {
                    txt_server.Text = lines[0].Trim();
                    txt_database.Text = lines[1].Trim();
                    txt_username.Text = lines[2].Trim();
                    txt_pass.Text = lines[3].Trim();

                    if (lines.Length >= 5) 
                    {
                        chk_windowAuthen.Checked = lines[4].Trim().ToLower() == "windows";
                    }
                    else
                    {
                        chk_windowAuthen.Checked = false; 
                    }

                    ToggleAuthenticationFields();
                }
            }
        }

        private void ToggleAuthenticationFields()
        {
            bool isWindowsAuth = chk_windowAuthen.Checked;
            txt_username.Enabled = !isWindowsAuth;
            txt_pass.Enabled = !isWindowsAuth;

            if (isWindowsAuth)
            {
                txt_username.Text = "";
                txt_pass.Text = "";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string server = txt_server.Text.Trim();
            string database = txt_database.Text.Trim();
            string username = txt_username.Text.Trim();
            string password = txt_pass.Text.Trim();
            string authenMode = chk_windowAuthen.Checked ? "windows" : "sql";

            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Server and Database cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chk_windowAuthen.Checked && (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)))
            {
                MessageBox.Show("Username and Password cannot be empty when using SQL Authentication!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.WriteAllLines("Config.txt", new string[] { server, database, username, password, authenMode });

            Config_Settings.Server = server;
            Config_Settings.Database = database;
            Config_Settings.Authen = authenMode;
            Config_Settings.Username = username;
            Config_Settings.Password = password;

            MessageBox.Show("Configuration has been saved!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
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

        private void chk_windowAuthen_CheckedChanged(object sender, EventArgs e)
        {   
            ToggleAuthenticationFields();
        }
    }
}
