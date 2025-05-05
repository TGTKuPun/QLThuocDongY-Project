using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_FormProduct
    {
        public string DrugID { get; set; }
        public string DrugName { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DTO_FormProduct(string Drug_id, string Drug_name, string price, string quantity, string type, string status)
        {
            this.DrugID = Drug_id;
            this.DrugName = Drug_name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
            this.Status = status;
        }
    }
}
