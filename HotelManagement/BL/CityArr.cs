﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using HotelManagement.DAL;

namespace HotelManagement.BL
{
    public class CityArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = City_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            City city;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                city = new City(dataRow);
                this.Add(city);
            }
        }

        public City GetCityWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            City maxCity = new City();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as City).ID > maxCity.ID)
                    maxCity = (this[i] as City);
            }
            return maxCity;
        }

        public bool IsContain(string cityName)
        {

            //בדיקה האם יש ישוב עם אותו שם
            string curCityName;
            for (int i = 0; i < this.Count; i++)
            {
                curCityName = (this[i] as City).CityName;

                
                if (curCityName == cityName)
                    return true;

            }
            return false;
        }

    }
}
