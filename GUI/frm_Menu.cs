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
    public partial class frm_Menu : Form
    {
        string username;
        string password;
        public frm_Menu(string Username, string Password)
        {
            InitializeComponent();
            this.username = Username;
            this.password = Password;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void img_User_Click(object sender, EventArgs e)
        {
            frm_User menu_user = new frm_User(this);
            this.Hide();
            menu_user.Show();
        }

        private void img_Product_Click(object sender, EventArgs e)
        {
            frm_Product menu_product = new frm_Product(this);
            this.Hide();
            menu_product.Show();
        }

        private void label_signout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure want to sign out?",
                "Confirm Sign Out",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm_SignIn signInForm = new frm_SignIn(username, password);
                signInForm.Show();
            }
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
