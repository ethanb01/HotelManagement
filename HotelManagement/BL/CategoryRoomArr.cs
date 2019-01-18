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
    public class CategoryRoomArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = CategoryRoom_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            CategoryRoom categoryRoom;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                categoryRoom = new CategoryRoom(dataRow);
                this.Add(categoryRoom);
            }
        }

        public CategoryRoom GetCategoryRoonWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            CategoryRoom maxcategory = new CategoryRoom();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CategoryRoom).ID > maxcategory.ID)
                    maxcategory = (this[i] as CategoryRoom);
            }
            return maxcategory;
        }

        public bool IsContain(string categoryName)
        {

            //בדיקה האם יש ישוב עם אותו שם
            string curCategoryRoom;
            for (int i = 0; i < this.Count; i++)
            {
                curCategoryRoom = (this[i] as CategoryRoom).CategoryRoomName;

                
                if (curCategoryRoom == categoryName)
                    return true;

            }
            return false;
        }

    }
}
