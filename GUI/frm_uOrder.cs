using BUS;
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

namespace GUI
{
    public partial class frm_uOrder : Form
    {
        private string user_id;
        private string username;
        private string password;

        BUS_uOrder bus_uOrder = new BUS_uOrder();
        public frm_uOrder(string ID, string Username, string Password)
        {
            InitializeComponent();
            loadProducts();
            user_id = ID;
            username = Username;
            password = Password;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_uMenu frm_UMenu = new frm_uMenu(user_id, username, password);
                this.Hide();
                frm_UMenu.ShowDialog();
            }
            else
            {
                this.Show();
            }
            Application.Exit();
        }

        private void frm_uOrder_Load(object sender, EventArgs e)
        {
            lb_id.Text = "UID: " + user_id;
        }

        private void loadProducts()
        {
            List<DTO_uOrder> products = bus_uOrder.getProduct();
            cb_pname.DataSource = products;
            cb_pname.DisplayMember = "PNAME";  
            cb_pname.ValueMember = "PID";   
            date_order.Value = DateTime.Now;
            date_order.Enabled = false; 
        }

        private void cb_pname_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO_uOrder selectedProduct = cb_pname.SelectedItem as DTO_uOrder;

            if (selectedProduct != null)
            {
                txt_price.Text = selectedProduct.PRICE.ToString();
                txt_unit.Text = selectedProduct.UNIT;
                txt_quantity.Text = "1"; 

                updateTotalPrice();
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txt_quantity.Text, out float quantity))
            {
                if (quantity < 0)
                {
                    MessageBox.Show("Quantity cannot be negative.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_quantity.Text = "1"; 
                    return;
                }

                updateTotalPrice();
            }
            else
            {
                MessageBox.Show("Please enter a valid number for quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantity.Text = "1"; 
            }
        }

        private void updateTotalPrice()
        {
            try
            {
                float price = float.Parse(txt_price.Text);
                float quantity = float.Parse(txt_quantity.Text);

                float totalPrice = price * quantity;

                lb_price.Text = $"{totalPrice:N0} VND";
            }
            catch (FormatException)
            {
                lb_price.Text = "Loading...";
            }
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            string orderDate = date_order.Value.ToString("yyyy/MM/dd");
            float price = float.Parse(txt_price.Text);
            float quantity = float.Parse(txt_quantity.Text);
            float totalPrice = price * quantity;
            frm_uPayment frm_uPayment = new frm_uPayment(user_id, price.ToString(), quantity.ToString(), lb_price.Text, cb_pname.Text, orderDate, cb_pname.SelectedValue.ToString(), totalPrice, username, password);
            this.Hide();
            frm_uPayment.ShowDialog();
        }
    }
}
