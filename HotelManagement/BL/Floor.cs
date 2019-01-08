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
    public class Floor
    {

        private string m_numfloor;
        public string NumFloor { get => m_numfloor; set => m_numfloor = value; }

        private int m_id;
        public int ID { get => m_id; set => m_id = value; }




        public Floor() { }

        public Floor(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.ID = (int)dataRow["ID"];
            this.m_numfloor = dataRow["Floor"].ToString();
        }

        public bool Insert()
        {
            return Floor_DAL.Insert(m_numfloor);
        }

        public bool Update()
        {
            return Floor_DAL.Update(m_id,m_numfloor);
        }


        public bool Delete()
        {
            return Floor_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_numfloor.ToString();
        }
    }
}
