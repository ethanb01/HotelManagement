using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DAL
{
    class OrderRoom_DAL
    {
        public static bool Insert(int client, DateTime checkin, DateTime checkout, int room, string comment)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_OrderRoom"

            + "("
            + " [Client]"
            + ",[DateCheckin]"
            + ",[DateCheckout]"
            + ",[Room]"
            + ",[Phone]"
            + ",[Comment]"

            + ")"
            + " VALUES "
            + "("
            + "" + client + ""
            + "," + "'" + checkin + "'"
            + "," + "'" + checkout + "'"
            + "," + "" + room + ""
            + "," + "'" + comment + "'"

            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_OrderRoom"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_OrderRoom", "[Client]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            Client_DAL.FillDataSet(dataSet);
            DataRelation dataRelation1 = null;
            dataRelation1 = new DataRelation(

            //שם קשר הגומלין

            "OrderRoomClient"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Client"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderRoom"].Columns["Client"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation1);



            Room_DAL.FillDataSet(dataSet);
            DataRelation dataRelation2 = null;
            dataRelation2 = new DataRelation(

            //שם קשר הגומלין

            "OrderRoomRoom"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Room"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderRoom"].Columns["Room"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation2);


        }
    

        public static bool Update(int id, int client, DateTime checkin, DateTime checkout, int room, string comment)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_OrderRoom SET" 
            + " " + "[Client] = " + "" + client + ""
            + "," + "[DateCheckin] = " + "'" + checkin + "'"
            + "," + "[DateCheckout] = " + "'" + checkout + "'"
            + "," + "[Room] = " + "" + room+ ""
            + "," + "[Comment] = " + "'" + comment + "'"
            
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = "DELETE FROM Table_OrderRoom"
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
