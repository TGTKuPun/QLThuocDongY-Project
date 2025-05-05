using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_uOrder
    {
        public DataTable getProduct ()
        {
            string sql = "SELECT RTRIM(id_product) AS id_product, Product_Name, Prices, Type, Quantity FROM tb_product";

            return Connection.selectQuery(sql);
        }
    }
}
