using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_FormProduct
    {
        private DAL_FormProduct dal_product = new DAL_FormProduct();

        public List<DTO_FormProduct> GetProduct()
        {
            DataTable dt = dal_product.GetProduct();
            List<DTO_FormProduct> productList = new List<DTO_FormProduct>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_FormProduct product = new DTO_FormProduct(
                    row["id_product"].ToString(),
                    row["Product_Name"].ToString(),
                    row["Prices"].ToString(),
                    row["Quantity"].ToString(),
                    row["Type"].ToString(),
                    row["Status"].ToString());
                productList.Add(product);
            }
            return productList;
        }

        public void addProduct(DTO_FormProduct product)
        {
            dal_product.addProduct(product);
        }

        public string generateProdID()
        {
            return dal_product.generateProdID();
        }

        public void delProd(List<string> ids)
        {
            dal_product.delProd(ids);
        }

        public void updateProduct(DTO_FormProduct product)
        {
            dal_product.updateProduct(product);
        }
    }
}
