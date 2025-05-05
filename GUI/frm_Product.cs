using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class frm_Product : Form
    {   
        private frm_Menu menu;
        private BUS_FormProduct bus_product = new BUS_FormProduct();
        int dk = 0;

        public frm_Product(frm_Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
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

        public void styleGRD()
        {
            grd.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Regular);
            grd.DefaultCellStyle.ForeColor = Color.Black;
            grd.DefaultCellStyle.BackColor = Color.White;

            /*Automatically resize the columns to fill all available space*/
            grd.Dock = DockStyle.Fill;
            grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in grd.Columns)
            {
                col.MinimumWidth = 100;
            }
        }

        public void initGRD()
        {
            grd.Rows.Clear();
            grd.Columns.Clear();
            grd.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn col_id = new DataGridViewTextBoxColumn();
            col_id.Name = "id_product";
            col_id.HeaderText = "ID Product"; // Tên tiêu đề cho cột trong DataGridView
            col_id.DataPropertyName = "DrugID"; // Tên cột trong DTO_FormProduct
            grd.Columns.Add(col_id);

            DataGridViewTextBoxColumn col_ten_thuoc = new DataGridViewTextBoxColumn();
            col_ten_thuoc.Name = "Product_Name";
            col_ten_thuoc.HeaderText = "Product Name";  // Tên tiêu đề cho cột trong DataGridView
            col_ten_thuoc.DataPropertyName = "DrugName"; // Tên cột trong DTO_FormProduct
            grd.Columns.Add(col_ten_thuoc);

            DataGridViewTextBoxColumn col_gia_thuoc = new DataGridViewTextBoxColumn();
            col_gia_thuoc.Name = "Prices";
            col_gia_thuoc.HeaderText = "Price"; // Tên tiêu đề cho cột trong DataGridView
            col_gia_thuoc.DataPropertyName = "Price"; // Tên cột trong DTO_FormProduct
            grd.Columns.Add(col_gia_thuoc);

            DataGridViewTextBoxColumn col_soluong = new DataGridViewTextBoxColumn();
            col_soluong.Name = "Quantity";
            col_soluong.HeaderText = "Quantity"; // Tên tiêu đề cho cột trong DataGridView
            col_soluong.DataPropertyName = "Quantity"; // Tên cột trong DTO_FormProduct
            grd.Columns.Add(col_soluong);

            DataGridViewColumn col_type = new DataGridViewTextBoxColumn();
            col_type.Name = "Type";
            col_type.HeaderText = "Type"; // Tên tiêu đề cho cột trong DataGridView
            col_type.DataPropertyName = "Type"; // Tên cột trong DTO_FormProduct
            grd.Columns.Add(col_type);

            DataGridViewColumn col_status = new DataGridViewTextBoxColumn();
            col_status.Name = "Status";
            col_status.HeaderText = "Status"; // Tên tiêu đề cho cột trong DataGridView
            col_status.DataPropertyName = "Status"; // Tên cột trong DTO_FormProduct
            grd.Columns.Add(col_status);

            loadProductData();
        }

        private void frm_Product_Load(object sender, EventArgs e)
        {
            initGRD();
            styleGRD();
            enable(grp_product, false);
            bDel.Enabled = false;
            bEdit.Enabled = false;
            bSave.Enabled = false;
            /*For convenience, this assists for selecting more than one row*/
            grd.MultiSelect = true;
            /*For convenience, this selects the row of the chosen cell.*/
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtType.SelectedIndex = 0;
            txtStatus.SelectedIndex = 0;
        }

        private void loadProductData()
        {
            List<DTO_FormProduct> productList = bus_product.GetProduct();
            grd.AutoGenerateColumns = false;
            grd.DataSource = productList;
        }

        public void enable(Guna2GroupBox grp, bool b)
        {
            foreach (Control ctrl in grp.Controls)
            {
                /*To exclude btn_Exit for being false*/
                if (ctrl != btn_exit && ctrl != lb_goBack)
                {
                    ctrl.Enabled = b;
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            enable(grp_product, true);
            txtPID.Text = bus_product.generateProdID();
            txtPName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtPName.Focus();

            txtType.SelectedIndex = 0;
            txtStatus.SelectedIndex = 0;

            bSave.Enabled = true;
            dk = 1;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            List<string> ProductIDs = new List<string>();

            foreach (DataGridViewRow row in grd.SelectedRows)
            {
                if (row.Cells["id_product"].Value != null)
                {
                    ProductIDs.Add(row.Cells["id_product"].Value.ToString());
                }
            }

            if (ProductIDs.Count > 0)
            {
                try
                {
                    bus_product.delProd(ProductIDs);
                    MessageBox.Show("Successfully deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadProductData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            enable(grp_product, true);
            txtPID.Text = bus_product.generateProdID();
            txtPName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            txtType.SelectedIndex = 0;
            txtStatus.SelectedIndex = 0;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in grd.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    string PID = row.Cells["id_product"].Value.ToString();
                    string PName = row.Cells["Product_Name"].Value.ToString();
                    string Price = row.Cells["Prices"].Value.ToString();
                    string Quantity = row.Cells["Quantity"].Value.ToString();
                    string Type = row.Cells["Type"].Value.ToString();
                    string Status = row.Cells["Status"].Value.ToString();

                    txtPID.Text = PID;
                    txtPName.Text = PName;
                    txtPrice.Text = Price;
                    txtQuantity.Text = Quantity;
                    txtType.Text = Type;
                    txtStatus.Text = Status;

                    enable(grp_product, true);
                    bSave.Enabled = true;
                    dk = 2;
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (dk == 1)
            {
                if (string.IsNullOrWhiteSpace(txtPName.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                    string.IsNullOrWhiteSpace(txtStatus.Text) ||
                    string.IsNullOrWhiteSpace(txtType.Text))
                {
                    MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtStatus.SelectedIndex == 0 || txtType.SelectedIndex == 0)
                {
                    MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_FormProduct newProduct = new DTO_FormProduct(
                    txtPID.Text,
                    txtPName.Text,
                    txtPrice.Text,
                    txtQuantity.Text,
                    txtType.Text,
                    txtStatus.Text
                );

                try
                {
                    bus_product.addProduct(newProduct);
                    MessageBox.Show("Product added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadProductData();
                    enable(grp_product, false);
                    bSave.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dk == 2)
            {
                if (string.IsNullOrWhiteSpace(txtPName.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                    string.IsNullOrWhiteSpace(txtStatus.Text) ||
                    string.IsNullOrWhiteSpace(txtType.Text))
                {
                    MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtStatus.SelectedIndex == 0 || txtType.SelectedIndex == 0)
                {
                    MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_FormProduct updatedProduct = new DTO_FormProduct(
                    txtPID.Text,
                    txtPName.Text,
                    txtPrice.Text,
                    txtQuantity.Text,
                    txtType.Text,
                    txtStatus.Text
                );

                try
                {
                    bus_product.updateProduct(updatedProduct);
                    MessageBox.Show("Product information updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadProductData();
                    enable(grp_product, false);
                    bSave.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Print
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float yPosition = 50;
            float cellPadding = 8;
            Pen borderPen = new Pen(Color.Black, 1);

            using (System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold))
            using (System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold))
            using (System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular))
            {

                string titleText = "Product List";
                SizeF titleSize = g.MeasureString(titleText, titleFont);
                float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
                g.DrawString(titleText, titleFont, Brushes.Black, new PointF(titleX, yPosition));
                yPosition += 40;


                int[] columnWidths = { 100, 150, 100, 100, 100, 100 };
                string[] headers = { "Product ID", "Product Name", "Price", "Quantity", "Type", "Status" };

                float tableStartX = (e.PageBounds.Width - columnWidths.Sum()) / 2;
                float currentX = tableStartX;
                float headerY = yPosition;


                for (int i = 0; i < headers.Length; i++)
                {
                    RectangleF headerRect = new RectangleF(currentX, headerY, columnWidths[i], 30);
                    g.DrawRectangle(borderPen, headerRect.X, headerRect.Y, headerRect.Width, headerRect.Height);
                    g.DrawString(headers[i], headerFont, Brushes.Black, new PointF(headerRect.X + cellPadding, headerRect.Y + 5));
                    currentX += columnWidths[i];
                }

                yPosition += 30;


                foreach (DataGridViewRow row in grd.Rows)
                {
                    if (row.IsNewRow) continue;
                    currentX = tableStartX;

                    float maxRowHeight = 25;
                    List<string> rowData = new List<string>();

                    for (int i = 0; i < headers.Length; i++)
                    {
                        string cellText = row.Cells[i].Value?.ToString() ?? "";
                        rowData.Add(cellText);


                        SizeF textSize = g.MeasureString(cellText, contentFont, (int)(columnWidths[i] - 2 * cellPadding));
                        int requiredLines = (int)Math.Ceiling(textSize.Height / contentFont.Height);
                        maxRowHeight = Math.Max(maxRowHeight, requiredLines * contentFont.Height + 8);
                    }

                    for (int i = 0; i < headers.Length; i++)
                    {
                        string cellText = rowData[i];
                        RectangleF cellRect = new RectangleF(currentX, yPosition, columnWidths[i], maxRowHeight);
                        g.DrawRectangle(borderPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Near;
                        format.LineAlignment = StringAlignment.Near;
                        format.Trimming = StringTrimming.Word;
                        format.FormatFlags = StringFormatFlags.LineLimit;

                        g.DrawString(cellText, contentFont, Brushes.Black, new RectangleF(cellRect.X + cellPadding, cellRect.Y + cellPadding, cellRect.Width - 2 * cellPadding, cellRect.Height - 2 * cellPadding), format);

                        currentX += columnWidths[i];
                    }

                    yPosition += maxRowHeight;
                }
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 800,
                Height = 600
            };

            previewDialog.ShowDialog();
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grd.Columns.Contains("id_product"))
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                txtPID.Text = row.Cells["id_product"].Value.ToString();
                txtPName.Text = row.Cells["Product_Name"].Value?.ToString();
                txtPrice.Text = row.Cells["Prices"].Value?.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
                txtType.Text = row.Cells["Type"].Value?.ToString();
                txtStatus.Text = row.Cells["Status"].Value?.ToString();

                enable(grp_product, true);
                bEdit.Enabled = true;
                bDel.Enabled = true;
                bSave.Enabled = false;
            }
        }

        private void lb_goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
