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
    public class Product
    {
        private int m_id;
        public int ID { get => m_id; set => m_id = value; }

        private string m_name;
        public string ProductName { get => m_name; set => m_name = value; }

        private int m_price;
        public int Price { get => m_price; set => m_price = value; }

        private string m_details;
        public string Details { get => m_details; set => m_details = value; }
        

        private int m_quantityStock;
        public int QuantityStock{ get => m_quantityStock; set => m_quantityStock = value; }

        public Product() { }

        public Product(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.m_id= (int)dataRow["ID"];
            this.m_name = dataRow["Name"].ToString();
            this.m_price = (int)dataRow["Price"];
            this.m_details = dataRow["Details"].ToString();
            this.m_quantityStock= (int)dataRow["QuantityStock"];
        }

        public bool Insert()
        {
            return Product_DAL.Insert(m_name,m_price,m_details,m_quantityStock);
        }

        public bool Update()
        {
            return Product_DAL.Update(m_id, m_name,m_price, m_details,m_quantityStock );
        }

        public bool Delete()
        {
            return Product_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_name +" : " + m_price + "[NIS]";
        }
    }
}
