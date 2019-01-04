using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.BL;
using HotelManagement.DAL;
using System.Data;

namespace HotelManagement.BL
{
    public class Stage
    {

        private string m_numstage;
        public string NumStage { get => m_numstage; set => m_numstage = value; }

        private int m_id;
        public int ID { get => m_id; set => m_id = value; }




        public Stage() { }

        public Stage(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.ID = (int)dataRow["ID"];
            this.m_numstage = dataRow["Stage"].ToString();
        }

        public bool Insert()
        {
            return Stage_DAL.Insert(m_numstage);
        }

        public bool Update()
        {
            return Stage_DAL.Update(m_id,m_numstage);
        }


        public bool Delete()
        {
            return Stage_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_numstage.ToString();
        }
    }
}
