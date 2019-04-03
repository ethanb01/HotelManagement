using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAL
{
    class ProductDetails_DAL
    {

        public static bool Insert(int product, int category_product)
        {
            string str = "INSERT INTO Table_ProductDetails"
                + "("
                + "[Product]"
                + ",[Category]"
                + ")"

                + " VALUES "
                + "("
                + "" +product + ""
                + "," + "" + category_product+ ""
                + ")";

            return Dal.ExecuteSql(str);

        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();

            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_ProductDetails"];

            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        { //ממלאת את אוסף הטבלאות בטבלת הלקוחות 

            Dal.FillDataSet(dataSet, "Table_ProductDetails", "[ID]");

            CategoryProduct_DAL.FillDataSet(dataSet);
            DataRelation dataRelation = null;
            dataRelation = new DataRelation("ProductDetailsCategoryProduct", dataSet.Tables["Table_ProductCategory"].Columns["ID"],
                dataSet.Tables["Table_ProductDetails"].Columns["Category"]);
            dataSet.Relations.Add(dataRelation);



            Product_DAL.FillDataSet(dataSet);
            DataRelation dataRelation_V2 = null;
            dataRelation_V2 = new DataRelation("ProductDetailsProduct", dataSet.Tables["Table_Product"].Columns["ID"],
                dataSet.Tables["Table_ProductDetails"].Columns["Product"]);
            dataSet.Relations.Add(dataRelation_V2);

        }

        public static bool Update(int id, int product, int category_product)
        {
            string str = "Update Table_OrderDetailsBuy SET"
                + "" + "[Product] = " + "" + product+ ""
                + "," + "[Category] = " + "" + category_product+ ""

                + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את הלקוח ממסד הנתונים 
            string str = "DELETE FROM Table_ProductDetails" + " WHERE ID = " + id;

            return Dal.ExecuteSql(str);
        }
    }
}
