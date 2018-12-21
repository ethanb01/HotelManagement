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
    public class RoomArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Room_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Room room;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                room = new Room(dataRow);
                this.Add(room);
            }
        }
        //to change 
        public RoomArr Filter(string id, string lastName, string cellNumber)
        {
            ClientArr clientArr = new ClientArr();
            Room room;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                room = (this[i] as Room);
                if
                (

                //מזהה 0 – כלומר, לא נבחר מזהה בסינון
                
                ((room.Taz.StartsWith(id)) || (room.Taz == id)||(int.Parse(id)==0))
                && room.LastName.StartsWith(lastName.ToUpper())
                && room.Phone.Contains(cellNumber)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    clientArr.Add(room);
            }
            return clientArr;
        }
    }
}
