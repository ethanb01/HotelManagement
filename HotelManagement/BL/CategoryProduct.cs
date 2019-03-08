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
    public class CategoryProduct
    {
        private int m_id;
        public int ID { get => m_id; set => m_id = value; }

        private string m_name;
        public string CategoryProductName { get => m_name; set => m_name = value; }
        
        public CategoryProduct() { }

        public CategoryProduct(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.ID = (int)dataRow["ID"];
            this.m_name = dataRow["Name"].ToString();
        }

        public bool Insert()
        {
            return CategoryProduct_DAL.Insert(m_name);
        }
        public bool Update()
        {
            return CategoryProduct_DAL.Update(m_id, m_name);
        }
        public bool Delete()
        {
            return CategoryProduct_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_name;
        }
    }
}
