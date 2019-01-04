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

        public RoomArr Filter(string room_number, Stage stage, CategoryRoom category_room)
        {
            RoomArr roomArr = new RoomArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Room room = (this[i] as Room);
                if (

                //סינון לפי מזהה המוצר

                //סינון לפי שם המוצר

                room.RoomNumber.StartsWith(room_number)

                //סינון לפי החברה
                && (room.StageNum.NumStage == stage.NumStage)
                //סינון לפי קטגוריה
                && (category_room == null || category_room.ID == -1 || room.CategoryRoom.ID == category_room.ID)
                )
                {

                    //המוצר ענה לדרישות החיפוש – הוספה שלו לאוסף המוחזר

                    roomArr.Add(room);
                    

                }
            }
            return roomArr;
        }
    }
}
