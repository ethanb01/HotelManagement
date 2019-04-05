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
    public class ProductDetailsArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = ProductDetails_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            ProductDetails orderRoom;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                orderRoom = new ProductDetails(dataRow);
                this.Add(orderRoom);
            }
        }
        




        public bool Insert()
        {

            //מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            bool flag = true;
            ProductDetails productDetails = null;
            for (int i = 0; i < this.Count; i++)
            {
                productDetails = (this[i] as ProductDetails);
                if (!productDetails.Insert())
                    flag = false;

            }
            return flag;
        }

        public CategoryProductArr GetCategoryProductArr()
        {
            CategoryProductArr categoryProductArr = new CategoryProductArr();

            ProductDetails productDetails;

            for (int i = 0; i < this.Count; i++)
            {
                productDetails = (this[i] as ProductDetails); //מוסיפים רק פריטים שלא קיימים כבר באוסף 
                if (!categoryProductArr.IsContains(productDetails.ProductCategory))
                    categoryProductArr.Add(productDetails.ProductCategory);
            }

            return categoryProductArr;
        }



        public ProductDetailsArr Filter(Product product)
        {
            ProductDetailsArr productDetailsArr = new ProductDetailsArr();

            for (int i = 0; i < this.Count; i++)
            {
                ProductDetails productDetails = (this[i] as ProductDetails);

                if ((product == null) || (productDetails.Product.ID == product.ID))
                {
                    productDetailsArr.Add(productDetails);
                }
            }

            return productDetailsArr;
        }

        public bool Delete()
        {
            ProductDetails productDetails = null;

            for (int i = 0; i < this.Count; i++)
            {
                productDetails = (this[i] as ProductDetails);

                if (!productDetails.Delete())
                {
                    return false;
                }
            }
            return true;
        }


        //public ProductDetailsArr Filter(DateTime checkin, DateTime checkout, Client client, Room room)
        //{
        ////    if (orderRoom_number == "")
        ////        orderRoom_number = "-1";

        //    ProductDetailsArr orderRoomArr = new ProductDetailsArr();

        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        //הצבת המוצר הנוכחי במשתנה עזר - מוצר
        //        ProductDetails orderRoom = (this[i] as ProductDetails);

        //        if(
        //        orderRoom.Room.RoomNumber.StartsWith(room.RoomNumber)

        //        //סינון לפי החברה
        //        && (orderRoom.CheckinDate == checkin)
        //        && (orderRoom.CheckoutDate == checkout)
        //        //סינון לפי קטגוריה
        //        && (client == null || client.ID == -1 || orderRoom.Client.ID == client.ID)
        //        )
        //        {

        //            //המוצר ענה לדרישות החיפוש – הוספה שלו לאוסף המוחזר

        //            orderRoomArr.Add(orderRoom);


        //        }
        //    }
        //    return orderRoomArr;
        //}
    }
}
