using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DAL
{
    class CategoryProduct_DAL
    {
        public static bool Insert(string name,int minhour, int maxhour)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_ProductCategory"

            + "("
             + "[Name]"
             + "[MinHour]"
             + "[MaxHour]"

            + ")"
            + " VALUES "
            + "("
            + "'" + name + "'"
            + "," + minhour + ""
            + "," + maxhour + ""

            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_ProductCategory"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            if (!dataSet.Tables.Contains("Table_ProductCategory"))
            {
                Dal.FillDataSet(dataSet, "Table_ProductCategory", "[Name]");
            }            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }

        public static bool Update(int id, string name, int minhour, int maxhour)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_ProductCategory SET"
            + " " + "[Name] = " + "'" + name + "'"
            + "," + "[MinHour] = " + "" + minhour + ""
            + "," + "[MaxHour] = " + "" + maxhour + ""


            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = "DELETE FROM Table_ProductCategory"
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
