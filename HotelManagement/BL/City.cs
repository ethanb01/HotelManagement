﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.BL;
using HotelManagement.DAL;
using System.Data;

namespace HotelManagement.BL
{
    public class City
    {

        private string m_cityName;
        public string CityName { get => m_cityName; set => m_cityName = value; }

        private int m_id;
        public int ID { get => m_id; set => m_id = value; }




        public City() { }

        public City(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.ID = (int)dataRow["ID"];
            this.m_cityName = dataRow["Name"].ToString();
        }

        public bool Insert()
        {
            return City_DAL.Insert(m_cityName);
        }

        public bool Update()
        {
            return City_DAL.Update(m_id, m_cityName);
        }


        public bool Delete()
        {
            return City_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_cityName;
        }
    }
}
