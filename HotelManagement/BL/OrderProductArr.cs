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
    public class OrderProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = OrderProduct_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            OrderProduct orderProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                orderProduct = new OrderProduct(dataRow);
                this.Add(orderProduct);
            }
        }

        //public OrderProductArr Filter(DateTime checkin, DateTime checkout, Client client, Product product)
        //{
        ////    if (orderProduct_number == "")
        ////        orderProduct_number = "-1";
            
        //    OrderProductArr orderProductArr = new OrderProductArr();

        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        //הצבת המוצר הנוכחי במשתנה עזר - מוצר
        //        OrderProduct orderProduct = (this[i] as OrderProduct);
                
        //        if(
        //        orderProduct.Product.ProductNumber.StartsWith(product.ProductNumber)

        //        //סינון לפי החברה
        //        && (orderProduct.CheckinDate == checkin)
        //        && (orderProduct.CheckoutDate == checkout)
        //        //סינון לפי קטגוריה
        //        && (client == null || client.ID == -1 || orderProduct.Client.ID == client.ID)
        //        )
        //        {

        //            //המוצר ענה לדרישות החיפוש – הוספה שלו לאוסף המוחזר

        //            orderProductArr.Add(orderProduct);
                    

        //        }
        //    }
        //    return orderProductArr;
        //}
    }
}
