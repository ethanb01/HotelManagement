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
    public class OrderRoomArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = OrderRoom_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            OrderRoom orderRoom;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                orderRoom = new OrderRoom(dataRow);
                this.Add(orderRoom);
            }
        }

        public OrderRoomArr Filter(DateTime checkin, DateTime checkout, Client client, Room room)
        {
        //    if (orderRoom_number == "")
        //        orderRoom_number = "-1";
            
            OrderRoomArr orderRoomArr = new OrderRoomArr();

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת המוצר הנוכחי במשתנה עזר - מוצר
                OrderRoom orderRoom = (this[i] as OrderRoom);
                
                if(
                orderRoom.Room.RoomNumber.StartsWith(room.RoomNumber)

                //סינון לפי החברה
                && (orderRoom.CheckinDate == checkin)
                && (orderRoom.CheckoutDate == checkout)
                //סינון לפי קטגוריה
                && (client == null || client.ID == -1 || orderRoom.Client.ID == client.ID)
                )
                {

                    //המוצר ענה לדרישות החיפוש – הוספה שלו לאוסף המוחזר

                    orderRoomArr.Add(orderRoom);
                    

                }
            }
            return orderRoomArr;
        }
    }
}
