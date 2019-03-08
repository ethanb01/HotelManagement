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

        public ProductArr Filter(string name, string quantity, CategoryProduct category_product)
        {
            //    if (product_number == "")
            //        product_number = "-1";
            int quantity_one_zero;
            if (quantity == "Yes")
                quantity_one_zero = 1;
            else
                quantity_one_zero = 0;

            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                
                if(
                product.ProductName.StartsWith(name)
                &&((product.QuantityStock >0) && (quantity == "Yes"))||((product.QuantityStock == 0) && (quantity == "No") || (quantity=="Is in stock?"))
                //סינון לפי קטגוריה
                && (category_product == null || category_product.ID == -1 || product.CategoryProduct.ID == category_product.ID)
                )
                {

                    //המוצר ענה לדרישות החיפוש – הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
                    

                }
            }
            return productArr;
        }
    }
}
