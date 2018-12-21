using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DAL
{
    class Room_DAL
    {
        public static bool Insert(string roomNumber, int category, int stage)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Room"

            + "("
            + " [RoomNumber]"
            + ",[Category]"
            + ",[Stage]"

            + ")"
            + " VALUES "
            + "("
            + "'" + roomNumber + "'"
            + "," + "" + category + ""
            + "," + "" + stage + ""

            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Room"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Room", "[RoomNumber]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            City_DAL.FillDataSet(dataSet);
            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "CategoryRoom"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_RoomCategory"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Room"].Columns["Category"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);


        }

        public static bool Update(string roomNumber, int category, int stage, int id)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Room SET"
            + " " + "[RoomNumber] = " + "'" + roomNumber + "'"
            + "," + "[Category] = " + "" + category + ""
            + "," + "[Stage] = " + "" + stage + ""
            
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = "DELETE FROM Table_Room"
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
