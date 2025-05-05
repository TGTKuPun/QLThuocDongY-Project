using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_FormProduct
    {
        public DataTable GetProduct()
        {
            string sql = "SELECT RTRIM(id_product) AS id_product, Product_Name, Prices, Quantity, Type, Status FROM tb_product";
            return Connection.selectQuery(sql);
        }

        public void addProduct(DTO_FormProduct product)
        {
            string sql = string.Format("INSERT INTO tb_product(id_product, Product_Name, Prices, Quantity, Type, Status) VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')",
                product.DrugID, product.DrugName, product.Price, product.Quantity, product.Type, product.Status);
            Connection.actionQuery(sql);
        }
        public string generateProdID()
        {
            string sql = "SELECT top 1 id_product FROM tb_product order by id_product desc";
            DataTable dt = Connection.selectQuery(sql);

            if (dt == null || dt.Rows.Count == 0 || dt.Rows[0][0] == DBNull.Value)
            {
                return "T001";
            }

            string currentID = dt.Rows[0][0].ToString();

            int number = int.Parse(currentID.Substring(1)) + 1;
            return "T" + number.ToString("D3");
        }

        public void delProd(List<string> ProductIDs)
        {
            string ids = string.Join("','", ProductIDs);
            string sql = $"DELETE FROM tb_product WHERE id_product IN ('{ids}')";

            Connection.actionQuery(sql);
        }

        public void updateProduct(DTO_FormProduct product)
        {
            string sql = string.Format("UPDATE tb_product SET Product_Name = N'{1}', Prices = N'{2}', Quantity = N'{3}', Type = N'{4}', Status = N'{5}' WHERE id_product = N'{0}'",
                                        product.DrugID, product.DrugName, product.Price, product.Quantity, product.Type, product.Status);
            Connection.actionQuery(sql);
        }
    }
}
