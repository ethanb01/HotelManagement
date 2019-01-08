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
        public static bool Insert(string roomNumber, int category, int floor)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Room"

            + "("
            + " [RoomNumber]"
            + ",[Category]"
            + ",[Floor]"

            + ")"
            + " VALUES "
            + "("
            + "'" + roomNumber + "'"
            + "," + "" + category + ""
            + "," + "" + floor + ""

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
            CategoryRoom_DAL.FillDataSet(dataSet);
            DataRelation dataRelation1 = null;
            dataRelation1 = new DataRelation(

            //שם קשר הגומלין

            "CategoryRoom"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_RoomCategory"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Room"].Columns["Category"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation1);

            Floor_DAL.FillDataSet(dataSet);
            DataRelation dataRelation2 = null;
            dataRelation2 = new DataRelation(

            //שם קשר הגומלין

            "FloorRoom"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Floor"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Room"].Columns["Floor"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation2);


        }






        public static bool Update(string roomNumber, int category, int floor, int id)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Room SET"
            + " " + "[RoomNumber] = " + "'" + roomNumber + "'"
            + "," + "[Category] = " + "" + category + ""
            + "," + "[Floor] = " + "" + floor + ""
            
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
