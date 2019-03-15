using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BL;

namespace HotelManagement.UI
{
    public partial class Form_CategoryProduct : Form
    {
        public Form_CategoryProduct()
        {
            InitializeComponent();
            CategoryProductArrToForm(null);
        }
        public bool CheckGood()
        {
            bool flag = true;
            if (textBox_category.Text.Length < 2)
            {
                flag = false;
                textBox_category.BackColor = Color.Red;
            }
            return flag;

        }

        private void Check_Name(object sender, KeyPressEventArgs e)
        {
            //
        }
        //checknum

        public bool IsEnglishLetter(char c)
        {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }

        private bool CapsLockChek()
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }

        public void All_White()
        {
            textBox_category.BackColor = Color.White;
        }

        private void Save(object sender, EventArgs e)
        {
            if (!CheckGood())
            {
                MessageBox.Show("You didn't write right", "TRY AGAIN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                All_White();

            }
            else
            {
                CategoryProduct categoryProduct = FormToCategoryProduct();
                if (categoryProduct.ID == 0)
                {
                    CategoryProductArr oldCategoryProductArr = new CategoryProductArr();
                    oldCategoryProductArr.Fill();
                    if (!oldCategoryProductArr.IsContains(categoryProduct))
                    {
                        if (categoryProduct.Insert())
                        {
                            MessageBox.Show("CategoryProduct Details Saved");
                            Clean_Form();
                            CategoryProductArr categoryProductArr = new CategoryProductArr();
                            categoryProductArr.Fill();
                            categoryProduct = categoryProductArr.GetCategoryRoonWithMaxId();
                            CategoryProductArrToForm(categoryProduct);
                            Close();

                        }
                        else
                            MessageBox.Show("Cannot Save CategoryProduct Details");
                    }
                    else
                        MessageBox.Show("CategoryProduct already existing");


                }
                else
                {
                    if (categoryProduct.Update())
                    {
                        MessageBox.Show("CategoryProduct Details UPDATED");
                        Clean_Form();
                        CategoryProductArrToForm(null);

                    }
                    else
                        MessageBox.Show("Cannot UPDATE CategoryProduct Details");
                }


            }
        }

        private CategoryProduct FormToCategoryProduct()
        {
            CategoryProduct categoryProduct = new CategoryProduct();
            categoryProduct.ID = int.Parse(label_id.Text);
            categoryProduct.CategoryProductName = textBox_category.Text;
            
            return categoryProduct;
        }

        private void CategoryProductArrToForm(CategoryProduct curCategoryProduct)
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            CategoryProductArr CategoryProductArr = new CategoryProductArr();
            CategoryProductArr.Fill();
            listBox_Category.DataSource = CategoryProductArr;
            listBox_Category.ValueMember = "ID";
            listBox_Category.DisplayMember = "CategoryProductName";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCategoryProduct != null)
                listBox_Category.SelectedValue = curCategoryProduct.ID;
        }

        private void CategoryProductToForm(CategoryProduct categoryProduct)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_id.Text = categoryProduct.ID.ToString();
            textBox_category.Text = categoryProduct.CategoryProductName;
            
        }

        private void listBox_CategoryProduct_DoubleClick(object sender, EventArgs e)
        {
            CategoryProductToForm(listBox_Category.SelectedItem as CategoryProduct);
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Clean(object sender, EventArgs e)
        {
            Clean_Form();
        }

        private void Clean_Form()
        {

            All_White();
            textBox_category.Text = "";
            label_id.Text = "0";
        }

        private void button_deleteCategoryProduct_Click(object sender, EventArgs e)
        {
            CategoryProduct categoryProduct = FormToCategoryProduct();
            if (categoryProduct.ID == 0)
            {
                MessageBox.Show("Please choice a CategoryProduct to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete the categoryProduct: " + categoryProduct.CategoryProductName + " " + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    categoryProduct.Delete();
                    Clean_Form();
                    CategoryProductArrToForm(null);
                }

            }
        }
        public CategoryProduct SelectedCategoryProduct
        {
            get { return (listBox_Category.SelectedItem as CategoryProduct); }
        }

        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            CategoryProductToForm(listBox_Category.SelectedItem as CategoryProduct);
        }
    }
}
