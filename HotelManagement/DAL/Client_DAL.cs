using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.DAL
{
    class Client_DAL
    {
        public static bool Insert(string firstName, string lastName, string mail, string id, string phone, string creditCard)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"

            + "("
            + " [IdNum]"
            + ",[FirstName]"
            + ",[LastName]"
            + ",[Mail]"
            + ",[Phone]"
             + ",[CreditCard]"
            + ")"
            + " VALUES "
            + "("
            + "'" + id + "'"
            + "," + "'" + firstName + "'"
            + "," + "'" + lastName + "'"
            + "," + "'" + mail + "'"
            + "," + "'" + phone + "'"
            + "," + "'" + creditCard + "'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName],[FirstName]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }
    }
}
