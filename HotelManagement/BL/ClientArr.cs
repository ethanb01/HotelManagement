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
    public class ClientArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Client_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Client client;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                client = new Client(dataRow);
                this.Add(client);
            }
        }

        public ClientArr Filter(string id, string lastName, string cellNumber)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                client = (this[i] as Client);
                if
                (

                //מזהה 0 – כלומר, לא נבחר מזהה בסינון
                
                ((client.Taz.StartsWith(id)) || (client.Taz == id)||(int.Parse(id)==0))
                && client.LastName.StartsWith(lastName.ToUpper())
                && client.Phone.Contains(cellNumber)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    clientArr.Add(client);
            }
            return clientArr;
        }
    }
}
