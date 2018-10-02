using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
