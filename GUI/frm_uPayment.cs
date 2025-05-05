using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frm_uPayment : Form
    {
        private string user_id;
        private string price;
        private string quantity;
        private string total_price;
        private string pname;
        private string date;
        private string paymentmethod;
        private string order_id;
        private string pid;
        private float TotalPrice;
        private string username;
        private string password;

        private BUS_uPayment bus_upayment = new BUS_uPayment();

        public frm_uPayment(string user_id, string price, string quantity, string total_price, string pname, string orderDate, string pid, float totalprice, string username, string password)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.price = price;
            this.quantity = quantity;
            this.total_price = total_price;
            this.pname = pname;
            this.date = orderDate;
            this.pid = pid;
            this.TotalPrice = totalprice;
            this.password = password;
            this.username = username;
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

        private void frm_uPayment_Load(object sender, EventArgs e)
        {
            lb_id.Text = "UID: " + user_id;
            lb_pname.Text = pname;
            lb_price.Text = $"{price:N0} VND";
            lb_quantity.Text = quantity;
            lb_totalPrice.Text = total_price;
            lb_dateOrder.Text = date;
            radio_cash.Checked = true;
        }

        private void btn_proceedPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_firstname.Text) ||
                string.IsNullOrWhiteSpace(txt_lastname.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radio_bank.Checked && !radio_cash.Checked)
            {
                MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radio_bank.Checked)
            {
                paymentmethod = lbbank.Text;
            }
            else
            {
                paymentmethod = lbcash.Text;
            }

            order_id = bus_upayment.generateOrderID();

            DTO_uPayment newOrder = new DTO_uPayment(
                order_id,
                user_id,
                date,
                TotalPrice,
                txt_firstname.Text,
                txt_lastname.Text,
                txt_email.Text,
                txt_phone.Text,
                txt_address.Text,
                paymentmethod
            );

            DTO_uPayment newDetailOrder = new DTO_uPayment(
                order_id,
                pid,
                quantity,
                TotalPrice
            );

            try
            {
                bus_upayment.addOrder(newOrder);
                bus_upayment.addOrderDetail(newDetailOrder);
                MessageBox.Show("Product added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            frm_uMenu uMenu = new frm_uMenu(user_id, username, password);
            this.Hide();
            uMenu.ShowDialog();
        }
    }
}
