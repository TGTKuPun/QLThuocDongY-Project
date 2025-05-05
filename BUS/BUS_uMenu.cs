using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_uMenu
    {
        private DAL_uMenu dal_uMenu = new DAL_uMenu();

        public List<DTO_uMenu> getOrderByUserId(string userId)
        {
            DataTable dt = dal_uMenu.getOrderByUserId(userId);
            List<DTO_uMenu> userList = new List<DTO_uMenu>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_uMenu uOrder = new DTO_uMenu(
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
                userList.Add(uOrder);
            }

            return userList;
        }

        public bool cancelOrder(string orderID) {

            DTO_uMenu order = dal_uMenu.getOrderByOrderId(orderID);
            if (order != null && order.STATUS == "Chờ xử lý")
            {
                dal_uMenu.delOrderByOrderId(orderID);
                return true;
            }
            return false;
        }

        public bool updateOrder(string orderID, string phone, string address)
        {
            DTO_uMenu order = dal_uMenu.getOrderByOrderId(orderID);
            if (order == null)
                return false;

            // Chỉ chỉnh sửa nếu đơn hàng đang ở trạng thái "Chờ xử lý"
            if (order.STATUS != "Chờ xử lý")
                return false;

            return dal_uMenu.updateOrder(orderID, phone, address);
        }
    }
}
