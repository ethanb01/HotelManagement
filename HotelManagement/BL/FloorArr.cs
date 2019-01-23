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
    public class FloorArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Floor_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Floor floor;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                floor = new Floor(dataRow);
                this.Add(floor);
            }
        }

        public Floor GetFloorWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Floor floor= new Floor();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Floor).ID > floor.ID)
                    floor = (this[i] as Floor);
            }
            return floor;
        }

        public bool IsContain(string floor)
        {

            //בדיקה האם יש ישוב עם אותו שם
            string curFloor;
            for (int i = 0; i < this.Count; i++)
            {
                curFloor = (this[i] as Floor).NumFloor;
                
                if (curFloor == floor)
                    return true;

            }
            return false;
        }

    }
}
