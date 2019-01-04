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
    public class StageArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Stage_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Stage stage;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                stage = new Stage(dataRow);
                this.Add(stage);
            }
        }

        public Stage GetStageWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Stage stage= new Stage();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Stage).ID > stage.ID)
                    stage = (this[i] as Stage);
            }
            return stage;
        }

        public bool IsContain(string stage)
        {

            //בדיקה האם יש ישוב עם אותו שם
            string curStage;
            for (int i = 0; i < this.Count; i++)
            {
                curStage = (this[i] as Stage).NumStage;
                
                if (int.Parse(curStage) == int.Parse(stage))
                    return true;

            }
            return false;
        }

    }
}
