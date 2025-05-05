using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_uPayment
    {
        public void addOrder(DTO_uPayment order)
        {
            string sql = string.Format("INSERT INTO tb_order(id_order, id_user, Status, order_date, total_price, firstname, lastname, email, phone, detail_address, payment_method) VALUES(N'{0}', N'{1}', N'Chờ xử lý',N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}')",
                order.OrderID, order.userID, order.OrderDay, order.Totalprice, order.FirstName, order.LastName, order.Email, order.Phone, order.Address, order.PaymentMethod);
            Connection.actionQuery(sql);
        }

        public void addOrderDetail(DTO_uPayment orderdetail)
        {
            string sql = string.Format("INSERT INTO tb_orderdetail(id_order, id_product, Quantity, Price) VALUES(N'{0}', N'{1}', N'{2}', N'{3}')",
                 orderdetail.OrderID, orderdetail.ProductID, orderdetail.Quantity, orderdetail.Totalprice);
            Connection.actionQuery(sql);
        }

        public string generateOrderID()
        {
            string sql = "SELECT top 1 id_order FROM tb_order order by id_order desc";
            DataTable dt = Connection.selectQuery(sql);

            if (dt == null || dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            {
                return "D001";
            }

            string currentID = dt.Rows[0][0].ToString();

            int number = int.Parse(currentID.Substring(1)) + 1;
            return "D" + number.ToString("D3");
        }

    }
}
