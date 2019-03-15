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
    public class CategoryProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = CategoryProduct_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            CategoryProduct categoryProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                categoryProduct = new CategoryProduct(dataRow);
                this.Add(categoryProduct);
            }
        }

        public bool IsContains(CategoryProduct categoryProduct)
        {
            //מחזירה האם האוסף מכיל כבר את המוצר 
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CategoryProduct).ID == categoryProduct.ID)
                    return true;

            }
            return false;
        }

        public CategoryProduct GetCategoryRoonWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            CategoryProduct maxcategory = new CategoryProduct();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as CategoryProduct).ID > maxcategory.ID)
                    maxcategory = (this[i] as CategoryProduct);
            }
            return maxcategory;
        }
        public void Update()
        {
            //מעדכנת את אוסף המוצרים 
            for (int i = 0; i < this.Count; i++)
            {
                (this[i] as CategoryProduct).Update();
            }
        }
        //public bool IsContain(string categoryName)
        //{

        //    //בדיקה האם יש ישוב עם אותו שם
        //    string curCategoryProduct;
        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        curCategoryProduct = (this[i] as CategoryProduct).CategoryProductName;


        //        if (curCategoryProduct == categoryName)
        //            return true;

        //    }
        //    return false;
        //}

    }
}
