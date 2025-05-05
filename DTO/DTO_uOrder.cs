using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_uOrder
    {
        public string PID { get; set; }
        public string PNAME { get; set; }
        public int PRICE { get; set; }
        public string UNIT { get; set; }

        public float QUANTITY { get; set; }

        public DTO_uOrder(string pid, string pname, int price, string unit, float quantity)
        {
            this.PID = pid;
            this.PNAME = pname;
            this.PRICE = price;
            this.UNIT = unit;
            this.QUANTITY = quantity;
        }
    }
}
