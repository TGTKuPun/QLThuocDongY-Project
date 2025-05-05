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
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class frm_uMenu : Form
    {
        private string User_id;
        private string Username;
        private string Password;

        private BUS_uMenu bus_uMenu = new BUS_uMenu();
        public frm_uMenu(string user_id, string username, string password)
        {
            InitializeComponent();
            this.User_id = user_id;
            this.Username = username;
            this.Password = password;
        }

        private void frm_uMenu_Load(object sender, EventArgs e)
        {
            lb_userID.Text = "USER ID: " +  User_id;
            initGRD();
            styleGRD();
            btn_cancelOrder.Enabled = false;
            btn_editOrder.Enabled = false;
            // To handle address's Text when it's too long
            grd.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            frm_uOrder frm_UOrder = new frm_uOrder(User_id, Username, Password);
            this.Hide();
            frm_UOrder.ShowDialog();
        }

        public void styleGRD()
        {
            grd.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            grd.BackgroundColor = Color.White;
            grd.BorderStyle = BorderStyle.None;
            grd.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grd.GridColor = Color.LightGray;

            grd.EnableHeadersVisualStyles = false;
            grd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 98, 115);
            grd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grd.DefaultCellStyle.ForeColor = Color.Black;
            grd.DefaultCellStyle.BackColor = Color.White;
            grd.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            grd.DefaultCellStyle.SelectionForeColor = Color.Black;

            grd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd.RowTemplate.Height = 28;

            foreach (DataGridViewColumn col in grd.Columns)
            {
                col.MinimumWidth = 100;
            }

            grd.ReadOnly = true;
            grd.AllowUserToAddRows = false;
            grd.AllowUserToResizeRows = false;
        }



        public void initGRD()
        {
            grd.Rows.Clear();
            grd.Columns.Clear();
            grd.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn col_oid = new DataGridViewTextBoxColumn();
            col_oid.Name = "id_order";
            col_oid.HeaderText = "Order ID"; 
            col_oid.DataPropertyName = "ORDER_ID"; 
            grd.Columns.Add(col_oid);

            DataGridViewTextBoxColumn col_date = new DataGridViewTextBoxColumn();
            col_date.Name = "order_date";
            col_date.HeaderText = "Order Date";
            col_date.DataPropertyName = "ORDER_DATE";
            grd.Columns.Add(col_date);

            DataGridViewTextBoxColumn col_status = new DataGridViewTextBoxColumn();
            col_status.Name = "Status";
            col_status.HeaderText = "Status"; 
            col_status.DataPropertyName = "STATUS"; 
            grd.Columns.Add(col_status);

            DataGridViewTextBoxColumn col_total = new DataGridViewTextBoxColumn();
            col_total.Name = "total_price";
            col_total.HeaderText = "Total"; 
            col_total.DataPropertyName = "TOTAL"; 
            grd.Columns.Add(col_total);

            DataGridViewTextBoxColumn col_phone = new DataGridViewTextBoxColumn();
            col_phone.Name = "phone";
            col_phone.HeaderText = "Phone"; 
            col_phone.DataPropertyName = "PHONE";
            grd.Columns.Add(col_phone);

            DataGridViewTextBoxColumn col_address = new DataGridViewTextBoxColumn();
            col_address.Name = "detail_address";
            col_address.HeaderText = "Address";
            col_address.DataPropertyName = "ADDRESS";
            grd.Columns.Add(col_address);

            loadOrderData();
        }

        private void loadOrderData()
        {
            List<DTO_uMenu> orderList = bus_uMenu.getOrderByUserId(User_id);

            if (orderList.Count == 0)
            {
                grd.DataSource = null;
                grd.Rows.Clear();
                grd.Columns.Clear();

                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = "Notification";
                col.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                col.DefaultCellStyle.ForeColor = Color.Red;
                col.Width = grd.Width - 20;
                grd.Columns.Add(col);

                grd.Rows.Add("You do not have any orders");
                grd.ClearSelection(); 
            }
            else
            {
                grd.AutoGenerateColumns = false;
                grd.DataSource = orderList;
            }
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                btn_cancelOrder.Enabled = true;
                btn_editOrder.Enabled = true;
            }
        }

        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {
            if (grd.SelectedRows.Count > 0)
            {
                string orderId = grd.SelectedRows[0].Cells["id_order"].Value?.ToString();

                DialogResult result = MessageBox.Show("Are you sure of deleting the order?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bus_uMenu.cancelOrder(orderId))
                    {
                        MessageBox.Show("Order has been canceled.");
                    }
                    else
                    {
                        MessageBox.Show("Can only delete an order with 'Chờ xử lý' status.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, choose at least 1 order!!!.");
            }
            loadOrderData();
        }

        private void btn_editOrder_Click(object sender, EventArgs e)
        {
            if (grd.SelectedRows.Count > 0)
            {
                string orderId = grd.SelectedRows[0].Cells["id_order"].Value?.ToString();
                string oldPhone = grd.SelectedRows[0].Cells["phone"].Value?.ToString();
                string oldAddress = grd.SelectedRows[0].Cells["detail_address"].Value?.ToString();

                string newPhone = Microsoft.VisualBasic.Interaction.InputBox("Enter new phone numnber:", "Update Order", oldPhone);
                string newAddress = Microsoft.VisualBasic.Interaction.InputBox("Enter new address:", "Update Order", oldAddress);

                if (string.IsNullOrWhiteSpace(newPhone) || string.IsNullOrWhiteSpace(newAddress))
                {
                    MessageBox.Show("Information should not be ignore.");
                    return;
                }

                if (bus_uMenu.updateOrder(orderId, newPhone, newAddress))
                {
                    MessageBox.Show("Update Order Successfully!");
                }
                else
                {
                    MessageBox.Show("Can only update information with status 'Chờ xử lý'.");
                }
            }
            else
            {
                MessageBox.Show("Please, choose at least 1 order to update.");
            }
            loadOrderData();
        }

        private void lb_signOut_Click(object sender, EventArgs e)
        {
            frm_SignIn frm_SignIn = new frm_SignIn(Username, Password);
            this.Hide();
            frm_SignIn.ShowDialog();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
