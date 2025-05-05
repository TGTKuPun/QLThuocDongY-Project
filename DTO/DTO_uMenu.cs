using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_uMenu
    {
        public string ORDER_ID { get; set; }
        public string USER_ID { get; set; }
        public string STATUS { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public string TOTAL { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public DTO_uMenu (string order_id, string user_id, string status, 
                DateTime order_date, string total, string firstname, string lastname, 
                string email, string phone, string address)
        {
            this.ORDER_ID = order_id;
            this.USER_ID = user_id;
            this.STATUS = status;
            this.ORDER_DATE = order_date;
            this.TOTAL = total;
            this.FIRSTNAME = firstname;
            this.LASTNAME = lastname;
            this.EMAIL = email;
            this.PHONE = phone;
            this.ADDRESS = address;
        }

        public DTO_uMenu(string orderId, string phone, string address)
        {
            ORDER_ID = orderId;
            PHONE = phone;
            ADDRESS = address;
        }

    }
}
