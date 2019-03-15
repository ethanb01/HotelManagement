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
    public class ProductDetails
    {
        private int m_id;
        public int ID { get => m_id; set => m_id = value; }
		
        private Product m_product;
        public Product Product
        {
            get { return m_product; }
            set { m_product = value; }
        }

        private CategoryProduct m_categoryProduct;
        public CategoryProduct ProductCategory
        {
            get { return m_categoryProduct; }
            set { m_categoryProduct = value; }
        }
        
        public ProductDetails() { }

        public ProductDetails(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.m_id = (int)dataRow["ID"];
            this.m_categoryProduct = new CategoryProduct(dataRow.GetParentRow("ProductDetailsCategoryProduct"));
            this.m_product = new Product(dataRow.GetParentRow("ProductDetailsProduct"));
        }

        public bool Insert()
        {
            return ProductDetails_DAL.Insert(m_product.ID,m_categoryProduct.ID);
        }

        public bool Update()
        {
            return ProductDetails_DAL.Update(m_id,m_product.ID, m_categoryProduct.ID);
        }


        public bool Delete()
        {
            return ProductDetails_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return m_product +" : "+ m_categoryProduct;
        }
    }
}
