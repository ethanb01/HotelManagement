using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using HotelManagement.DAL;

namespace HotelManagement.BL
{
    public class ProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Product_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Product product;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                product = new Product(dataRow);
                this.Add(product);
            }
        }

        public ProductArr Filter(string name, string quantity,CategoryProduct category_product )//add category
        {
           

            ProductArr productArr = new ProductArr();

            

            for (int i = 0; i < this.Count; i++)
            {


                Product product = (this[i] as Product);
                

                if (
                product.ProductName.StartsWith(name)
                && (((product.QuantityStock > 0) && (quantity == "Yes")) || ((product.QuantityStock <= 0) && (quantity == "No")) || (quantity == "Is in stock?"))
               // && (category_product == null || category_product.ID == -1 || productDetails.ProductCategory.ID == category_product.ID)
                )

                {
                    productArr.Add(product);

                }
                
            }
            return productArr;
        }

        public Product GetProductWithMaxId()
        {
            Product product = new Product();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Product).ID > product.ID)
                {
                    product = this[i] as Product;
                }
            }
            return product;
        }

    }
}
