using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_uMenu
    {
        public DataTable getOrderByUserId(string userId)
        {
            string sql = "SELECT RTRIM(id_order) AS id_order, RTRIM(id_user) AS id_user, Status, " +
                         "order_date, total_price, firstname, lastname, " +
                         "RTRIM(email) AS email, RTRIM(phone) AS phone, detail_address, payment_method " +
                         "FROM tb_order " +
                         $"WHERE id_user = '{userId}' " +
                         "ORDER BY order_date DESC";

            return Connection.selectQuery(sql);
        }

        public DTO_uMenu getOrderByOrderId(string orderId)
        {
            string sql = "SELECT RTRIM(id_order) AS id_order, RTRIM(id_user) AS id_user, Status, " +
                         "order_date, total_price, firstname, lastname, " +
                         "RTRIM(email) AS email, RTRIM(phone) AS phone, detail_address, payment_method " +
                         $"FROM tb_order WHERE id_order = '{orderId}'";

            DataTable dt = Connection.selectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new DTO_uMenu(
                    row["id_order"].ToString(),
                    row["id_user"].ToString(),
                    row["Status"].ToString(),
                    Convert.ToDateTime(row["order_date"]),
                    row["total_price"].ToString(),
                    row["firstname"].ToString(),
                    row["lastname"].ToString(),
                    row["email"].ToString(),
                    row["phone"].ToString(),
                    row["detail_address"].ToString()
                );
            }

            return null;
        }

        public void delOrderByOrderId(string orderID)
        {
            string sql = $"DELETE FROM tb_order WHERE id_order = '{orderID}'";
            try
            {
                Connection.actionQuery(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the order: " + ex.Message);
            }
        }

        public bool updateOrder(string orderId, string phone, string address)
        {
            string sql = $"UPDATE tb_order SET phone = N'{phone}', detail_address = N'{address}' WHERE id_order = '{orderId}'";
            try
            {
                Connection.actionQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
