using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_uPayment
    {
        public string OrderID { get; set; }
        public string userID { get; set; }
        public string OrderDay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string ProductID { get; set; }
        public string Quantity { get; set; }
        public float Totalprice { get; set; }

        public DTO_uPayment(string id_order, string user_id, string oday, float totalprice, string fname, string lname, string email, string phone, string address, string paymentmethod)
        {
            this.OrderID = id_order;
            this.userID = user_id;
            this.OrderDay = oday;
            this.Totalprice = totalprice;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.PaymentMethod = paymentmethod;
        }

        public DTO_uPayment(string id_order, string id_product, string quantity, float totalprice)
        {
            this.OrderID = id_order;
            this.ProductID = id_product;
            this.Quantity = quantity;
            this.Totalprice = totalprice;
        }
    }
}
