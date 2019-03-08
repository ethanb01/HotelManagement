using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DAL
{
    class Product_DAL
    {
        public static bool Insert(string name,int price, string details, int category, int quantityStock)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Product"

            + "("
            + " [Name]"
            + ",[Price]"
            + ",[Details]"
            + ",[CategoryProduct]"
            + ",[QuantityStock]"

            + ")"
            + " VALUES "
            + "("
            + "'" + name + "'"
            + "," + "" + price + ""
            + "," + "'" + details + "'"
            + "," + "" + category+ ""
            + "," + "" + quantityStock + ""

            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Product"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Product", "[Name]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            CategoryProduct_DAL.FillDataSet(dataSet);
            DataRelation dataRelation1 = null;
            dataRelation1 = new DataRelation(

            //שם קשר הגומלין

            "CategoryProduct"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_ProductCategory"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["CategoryProduct"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation1);
            
        }


        public static bool Update(int id , string name, int price, string details, int category, int quantityStock)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Product SET"
            + " " + "[Name] = " + "'" + name + "'"
            + "," + "[CategoryProduct] = " + "" + category + ""
            + "," + "[Price] = " + "" + price + ""
            + "," + "[Details] = " + "'" + details + "'"
            + "," + "[QuantityStock] = " + "" + quantityStock + ""

            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = "DELETE FROM Table_Product"
            + " WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
