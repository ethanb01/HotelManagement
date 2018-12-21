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
    public class CategoryRoom
    {

        private string m_name;
        public string CategoryRoomName { get => m_name; set => m_name = value; }

        private int m_maxPlace;
        public int MaxPlace { get => m_maxPlace; set => m_maxPlace = value; }

        private int m_id;
        public int ID { get => m_id; set => m_id = value; }




        public CategoryRoom() { }

        public CategoryRoom(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.ID = (int)dataRow["ID"];
            this.m_name = dataRow["Name"].ToString();
        }

        public bool Insert()
        {
            return CategoryRoom_DAL.Insert(m_name,m_maxPlace);
        }

        public bool Update()
        {
            return CategoryRoom_DAL.Update(m_id, m_name,m_maxPlace);
        }


        public bool Delete()
        {
            return CategoryRoom_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_name;
        }
    }
}
