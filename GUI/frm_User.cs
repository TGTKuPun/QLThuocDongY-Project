using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Guna.UI2.WinForms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Printing;


namespace GUI
{
    public partial class frm_User : Form
    {   
        private frm_Menu menu;
        private BUS_FormUser bus_user = new BUS_FormUser();
        int dk = 0;

        public frm_User(frm_Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
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
            col_id.Name = "id_user"; 
            col_id.HeaderText = "ID User"; // Tên tiêu đề cho cột trong DataGridView
            col_id.DataPropertyName = "USERID"; // Tên cột trong DTO_FormUser
            grd.Columns.Add(col_id);

            DataGridViewTextBoxColumn col_role = new DataGridViewTextBoxColumn();
            col_role.Name = "user_role";
            col_role.HeaderText = "Role";
            col_role.DataPropertyName = "ROLE"; // Tên cột trong DTO_FormUser
            grd.Columns.Add(col_role);

            DataGridViewTextBoxColumn col_username = new DataGridViewTextBoxColumn();
            col_username.Name = "username";
            col_username.HeaderText = "Username"; // Tên tiêu đề cho cột trong DataGridView
            col_username.DataPropertyName = "USERNAME"; // Tên cột trong DTO_FormUser
            grd.Columns.Add(col_username);

            DataGridViewTextBoxColumn col_email = new DataGridViewTextBoxColumn();
            col_email.Name = "email";
            col_email.HeaderText = "Email"; // Tên tiêu đề cho cột trong DataGridView
            col_email.DataPropertyName = "EMAIL"; // Tên cột trong DTO_FormUser
            grd.Columns.Add(col_email);

            DataGridViewColumn col_pass = new DataGridViewTextBoxColumn();
            col_pass.Name = "Pass";
            col_pass.HeaderText = "Password"; // Tên tiêu đề cho cột trong DataGridView
            col_pass.DataPropertyName = "PASSWORD"; // Tên cột trong DTO_FormUser
            col_pass.Visible = false;
            grd.Columns.Add(col_pass);

            loadUserData();
        }

        private void loadUserData()
        {
            List<DTO_FormUser> userList = bus_user.getUser();

            foreach (var user in userList)
            {
                user.PASSWORD = "******";
            }

            txt_id.ReadOnly = true;
            grd.AutoGenerateColumns = false;
            grd.DataSource = userList;
        }   
        public void enable(Guna2GroupBox grp, bool b)
        {
            foreach (Control ctrl in grp.Controls)
            {
                /*To exclude btn_Exit for being false*/
                if (ctrl != btn_Exit && ctrl != lb_goBack)
                {
                    ctrl.Enabled = b;
                }
            }
        }
        private void frm_User_Load(object sender, EventArgs e)
        {
            initGRD();
            styleGRD();
            enable(grp_user, false);
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            btn_save.Enabled = false;
            /*For convenience, this assists for selecting more than one row*/
            grd.MultiSelect = true;
            /*For convenience, this selects the row of the chosen cell.*/
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            enable(grp_user, true);
            txt_id.Text = bus_user.generateUserID();
            txt_id.ReadOnly = true;
            txt_username.Clear();
            cb_role.SelectedIndex = 0;
            txt_email.Clear();
            txt_password.Clear();
            txt_username.Focus();
            btn_save.Enabled = true;
            dk = 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dk == 1)
            {
                if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                    string.IsNullOrWhiteSpace(cb_role.Text) ||
                    string.IsNullOrWhiteSpace(txt_email.Text) || cb_role.Text == "-- Select Role --") 
                {
                    MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_FormUser newUser = new DTO_FormUser(
                    txt_id.Text,
                    txt_username.Text,
                    txt_password.Text,
                    txt_email.Text,
                    cb_role.Text
                );

                try
                {
                    bus_user.addUser(newUser);
                    MessageBox.Show("User added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadUserData();
                    enable(grp_user, false);
                    btn_save.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dk == 2)
            {
                if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                    string.IsNullOrWhiteSpace(cb_role.Text) ||
                    string.IsNullOrWhiteSpace(txt_email.Text) || cb_role.Text == "-- Select Role --")
                {
                    MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTO_FormUser updatedUser = new DTO_FormUser(
                    txt_id.Text,
                    txt_username.Text,
                    txt_password.Text,
                    txt_email.Text,
                    cb_role.Text
                );

                try
                {
                    bus_user.updateUser(updatedUser);
                    MessageBox.Show("User information updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadUserData();
                    enable(grp_user, false);
                    btn_save.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grd.Columns.Contains("id_user"))
            {
                DataGridViewRow row = grd.Rows[e.RowIndex];

                txt_id.Text = row.Cells["id_user"].Value?.ToString();
                cb_role.Text = row.Cells["user_role"].Value?.ToString();
                txt_username.Text = row.Cells["username"].Value?.ToString();
                txt_email.Text = row.Cells["email"].Value?.ToString();

                txt_password.Text = (btn_edit.Enabled) ? "******" : "";

                enable(grp_user, true);
                btn_edit.Enabled = true;
                btn_del.Enabled = true;
                btn_save.Enabled = false;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (grd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            List<string> userIDs = new List<string>();

            foreach (DataGridViewRow row in grd.SelectedRows)
            {
                if (row.Cells["id_user"].Value != null)
                {
                    userIDs.Add(row.Cells["id_user"].Value.ToString());
                }
            }

            if (userIDs.Count > 0)
            {
                try
                {
                    bus_user.delUser(userIDs);
                    MessageBox.Show("Successfully deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUserData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
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
                    string userId = row.Cells["id_user"].Value.ToString();
                    string role = row.Cells["user_role"].Value.ToString();
                    string username = row.Cells["username"].Value.ToString();
                    string email = row.Cells["email"].Value.ToString();

                    txt_id.Text = userId;
                    cb_role.Text = role;
                    txt_username.Text = username;
                    txt_email.Text = email;
                    txt_password.Text = "******"; 

                    enable(grp_user, true);
                    btn_save.Enabled = true;
                    dk = 2;
                }
            }
        }

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

                string titleText = "User List";
                SizeF titleSize = g.MeasureString(titleText, titleFont);
                float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
                g.DrawString(titleText, titleFont, Brushes.Black, new PointF(titleX, yPosition));
                yPosition += 40;


                int[] columnWidths = { 100, 150, 150, 200 }; 
                string[] headers = { "ID", "Role", "Username", "Email" };

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

        List<string> linesToPrint = new List<string>();
        int currentLine = 0;

        private void btn_print_Click(object sender, EventArgs e)
        {
            linesToPrint = new List<string>
            {
                "Line 1", "Line 2", "Line 3", "Line 4", "Line 5",
                "Line 6", "Line 7", "Line 8", "Line 9", "Line 10",
                "Line 11", "Line 12", "Line 13", "Line 14", "Line 15"
            };
            currentLine = 0;

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

        private void lb_goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
