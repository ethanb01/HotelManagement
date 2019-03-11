using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DAL
{
    class OrderProduct_DAL
    {
        public static bool Insert(int room, DateTime date_order, int total_price, string comment)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_OrderProduct"

            + "("
            + " [Product]"
            + ",[Date]"
            + ",[TotalPrice]"
            + ",[Comment]"
            
            + ")"
            + " VALUES "
            + "("
            + "" + room + ""
            + "," + "'" + date_order+ "'"
            + "," + "" + total_price + ""
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
            dataTable = dataSet.Tables["Table_OrderProduct"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_OrderProduct", "[Room]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            Room_DAL.FillDataSet(dataSet);
            DataRelation dataRelation1 = null;
            dataRelation1 = new DataRelation(

            //שם קשר הגומלין

            "OrderProductRoom"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Room"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderProduct"].Columns["Room"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation1);

            
        }


        public static bool Update(int id, int room, DateTime date_order, int total_price, string comment)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_OrderProduct SET"
            + " " + "[Room] = " + "" + room+ ""
            + "," + "[Date] = " + "'" + date_order+ "'"
            + "," + "[TotalPrice] = " + "" + total_price+ ""
            + "," + "[Comment] = " + "'" + comment + "'"

            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = "DELETE FROM Table_OrderProduct"
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
