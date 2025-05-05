using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_uPayment
    {
        private DAL_uPayment dal_upayment = new DAL_uPayment();

        public void addOrder(DTO_uPayment order)
        {
            dal_upayment.addOrder(order);
        }

        public string generateOrderID()
        {
            return dal_upayment.generateOrderID();
        }

        public void addOrderDetail(DTO_uPayment orderdetail)
        {
            dal_upayment.addOrderDetail(orderdetail);
        }

    }
}
