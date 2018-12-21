using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DAL
{
    class CategoryRoom_DAL
    {
        public static bool Insert(string name, int maxPlace)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_RoomCategory"

            + "("
             + "[Name]"
             + "[MaxPlace]"

            + ")"
            + " VALUES "
            + "("
            + "'" + name + "'"
            + "" + maxPlace + ""
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_RoomCategory"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_RoomCategory", "[Name]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            
        }

        public static bool Update(int id, string name, int maxPlace)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_RoomCategory SET"
            + " " + "[Name] = " + "'" + name + "'"
            + " " + "[MaxPlace] = " + "'" + maxPlace + "'"
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = "DELETE FROM Table_RoomCategory"
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
