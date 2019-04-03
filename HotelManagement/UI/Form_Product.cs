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
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
            ProductArrToForm();
            CategoryProductArrToForm();
            comboBox_filter_onStock.SelectedIndex = 0;
            CategoryArrToForm(null, comboBox_filter_category, false);
        }

        private bool CapsLockChek()
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private bool flag = true;

        public bool CheckGood()

        {
            flag = true;
            if (texbox_nameProduct.Text.Length < 3)
            {
                flag = false;
                texbox_nameProduct.BackColor = Color.Red;
            }
            if (textBox_price.Text.Length == 0)
            {
                flag = false;
                textBox_price.BackColor = Color.Red;
            }
            if (listBox_category_choosed.DataSource == null)
            {
                flag = false;
                listBox_category_choosed.BackColor = Color.Red;
            }
            if (textBox_quantity.Text.Length == 0)
            {
                flag = false;
                textBox_quantity.BackColor = Color.Red;
            }

            return flag;

        }

        public bool IsEnglishLetter(char c)
        {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }

        private void Check_Name(object sender, KeyPressEventArgs e)
        {

            if (!IsEnglishLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
                e.KeyChar = char.MinValue;
            if (CapsLockChek())
            {
                MessageBox.Show("CapsLock is locked");
                e.KeyChar = char.MinValue;

            }

        }

        private void Check_Num(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        public void All_White()
        {
            textBox_price.BackColor = Color.White;
            listBox_category_choosed.BackColor = Color.White;
            textBox_quantity.BackColor = Color.White;
            texbox_nameProduct.BackColor = Color.White;
        }
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To)
        {
            CategoryProductArr categoryProductArr = null;

            //מוצאים את הפריט הנבחר

            object selectedItem = listBox_From.SelectedItem;

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים

            if (listBox_To.DataSource != null)
                categoryProductArr = listBox_To.DataSource as CategoryProductArr;
            else
                categoryProductArr = new CategoryProductArr();

            categoryProductArr.Add(selectedItem);
            CategoryProductArrToForm(categoryProductArr, listBox_To);


            ///הסרת הפריט הנבחרים מרשימת הפריטים הנבחרים

            categoryProductArr = listBox_From.DataSource as CategoryProductArr;
            categoryProductArr.Remove(selectedItem);
            CategoryProductArrToForm(categoryProductArr, listBox_From);
        }


        private void CategoryProductArrToForm(CategoryProductArr categoryProductArr, ListBox listBox)
        {
            listBox.DataSource = null;


            if (categoryProductArr == null)
            {
                categoryProductArr = new CategoryProductArr();
                categoryProductArr.Fill();
            }

            listBox.DataSource = categoryProductArr;

        }
        private Product FormToProduct()
        {
            Product product = new Product();
            product.ID = int.Parse(label_id.Text);
            product.ProductName = texbox_nameProduct.Text;
            product.Details= textBox_details.Text;
            product.Price = int.Parse(textBox_price.Text);
            product.QuantityStock = int.Parse(textBox_quantity.Text);

            return product;
        }

        private void ProductArrToForm()
        {
            //ממירה את הטנ"מ אוסף למוצרים לטופס
            ProductArr productArr = new ProductArr();
            productArr.Fill();
            listBox_product.DataSource = productArr;
        }
        private void CategoryProductArrToForm()
        {
            //ממירה את הטנ"מ אוסף למוצרים לטופס
            CategoryProductArr categoryProductArr = new CategoryProductArr();
            categoryProductArr.Fill();
            listBox_category_potential.DataSource = categoryProductArr;
        }

        private void Clean(object sender, EventArgs e)
        {
            CleanForm();
        }

        public void CleanForm()
        {
            All_White();
            texbox_nameProduct.Text = "";
            label_id.Text = "0";
            textBox_details.Text = "";
            textBox_price.Text = "";
            textBox_quantity.Text = "";
            listBox_category_choosed.DataSource = null;
            listBox_category_choosed.Items.Clear();
            listBox_category_potential.DataSource = null;
            CategoryProductArrToForm();

        }

        private void ProductToForm(Product product)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_id.Text = product.ID.ToString();
            texbox_nameProduct.Text = product.ProductName;
            textBox_price.Text = product.Price.ToString();
            textBox_details.Text = product.Details;
            textBox_quantity.Text = product.QuantityStock.ToString();
        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ProductToForm(listBox_product.SelectedItem as Product);

            CategoryProductArr categoryProductArrChoosed = new CategoryProductArr();

            ProductDetailsArr productDetailsArr = new ProductDetailsArr();
            productDetailsArr.Fill();

            productDetailsArr = productDetailsArr.Filter((listBox_product.SelectedItem as Product));

            categoryProductArrChoosed = productDetailsArr.GetCategoryProductArr();
            CategoryProductArrToForm(categoryProductArrChoosed, listBox_category_choosed);

            CategoryProductArr categoryProductArrNotChoosed = new CategoryProductArr();
            categoryProductArrNotChoosed.Fill();

            categoryProductArrNotChoosed.Remove(categoryProductArrChoosed);
            CategoryProductArrToForm(categoryProductArrNotChoosed, listBox_category_potential);
        }

        private void Delete(object sender, EventArgs e)
        {
            Product product = FormToProduct();
            if (product.ID == 0)
            {
                MessageBox.Show("Please choice a Product to delete");
            }
            else
            {

                if (MessageBox.Show("Are you sure to delete the product: " + product.ProductName + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    product.Delete();
                    CleanForm();
                    ProductArrToForm();
                }
            }
        }

        private void groupbox_productNumber_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }

        private void SetProductsByFilter()
        {
            string nameProduct = "";

            //אם המשתמש רשם ערך בשדה המזהה

            if (textbox_filter_productName.Text != "")
                nameProduct = textbox_filter_productName.Text;

            //מייצרים אוסף של כלל המוצרים
            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(nameProduct,

            comboBox_filter_onStock.Text
            //comboBox_filter_category.SelectedItem as CategoryProduct
            );
            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_product.DataSource = productArr;
        }

        public void CategoryArrToForm(CategoryProduct curCategoryProduct, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס
            CategoryProductArr catrgoryProductArr = new CategoryProductArr();
            CategoryProduct categoryProductDefault = new CategoryProduct();
            categoryProductDefault.ID = -1;
            if (isMustChoose)
                categoryProductDefault.CategoryProductName = "Choose category";
            else
                categoryProductDefault.CategoryProductName = "Every category";

            catrgoryProductArr.Add(categoryProductDefault);

            catrgoryProductArr.Fill();
            comboBox.DataSource = catrgoryProductArr;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "CategoryProductName";
            if (curCategoryProduct != null)
                comboBox.SelectedValue = curCategoryProduct.ID;
        }

        //public void FloorArrToForm(Floor curFloor, ComboBox comboBox, bool isMustChoose)
        //{
        //    //ממירה את הטנ"מ אוסף ישובים לטופס
        //    FloorArr catrgoryProductArr = new FloorArr();
        //    Floor categoryProductDefault = new Floor();
        //    categoryProductDefault.ID = -1;
        //    if (isMustChoose)
        //        categoryProductDefault.NumFloor = "Choose Floor";
        //    else
        //        categoryProductDefault.NumFloor = "Every Floor";

        //    catrgoryProductArr.Add(categoryProductDefault);

        //    catrgoryProductArr.Fill();
        //    comboBox.DataSource = catrgoryProductArr;
        //    comboBox.ValueMember = "ID";
        //    comboBox.DisplayMember = "NumFloor";
        //    if (curFloor != null)
        //        comboBox.SelectedValue = curFloor.ID;
        //}

        private ProductDetailsArr FormToProductDetailsArr(Product curProduct)
        {
            ProductDetailsArr productDetailsArr = new ProductDetailsArr();

            ProductDetails productDetails;

            for (int i = 0; i < listBox_category_choosed.Items.Count; i++)
            {
                productDetails = new ProductDetails();
                productDetails.Product = curProduct;
                productDetails.ProductCategory = listBox_category_choosed.Items[i] as CategoryProduct;

                productDetailsArr.Add(productDetails);
            }

            return productDetailsArr;
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
                Product product = FormToProduct();
                ProductDetailsArr productDetailsArr_new;
                ProductDetailsArr productDetailsArr_old = new ProductDetailsArr();

                ProductArr productArr_new = new ProductArr();
                productArr_new.Fill();

                if (product.ID == 0)
                {
                    if (product.Insert())
                    {
                        ProductArr productArr = new ProductArr();
                        productArr.Fill();
                        product = productArr.GetProductWithMaxId();
                        productDetailsArr_new = FormToProductDetailsArr(product);
                        productDetailsArr_new.Insert();                      

                        CategoryProductArr categoryProductArr = productDetailsArr_new.GetCategoryProductArr();
                        categoryProductArr.Update();

                        MessageBox.Show("Products Details Saved");
                        CleanForm();
                        ProductArrToForm();
                        CategoryProductArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot Save Products Details");
                }
                else
                {
                    if (product.Update())
                    {
                        productDetailsArr_new = FormToProductDetailsArr(product);
                        productDetailsArr_old.Fill();
                        productDetailsArr_old = productDetailsArr_old.Filter(product);

                        productDetailsArr_old.Delete();
                        productDetailsArr_new.Insert();

                        //(listBox_category_choosed.DataSource as CategoryProductArr).Update();
                        //(listBox_category_potential.DataSource as CategoryProductArr).Update();

                        MessageBox.Show("Products Details UPDATED");
                        CleanForm();
                        ProductArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot UPDATE Products Details");
                }


            }
        }

        private void AddCategoryProduct(object sender, EventArgs e)
        {
            Form_CategoryProduct form_CategoryProduct;
            form_CategoryProduct = new Form_CategoryProduct();
            form_CategoryProduct.ShowDialog();
            CategoryProductArrToForm();
        }

        private void button_new_floor_Click(object sender, EventArgs e)
        {
            Form_Floor form_Floor;
            form_Floor = new Form_Floor();
            form_Floor.ShowDialog();
            //FloorArrToForm(form_Floor.SelectedFloor, comboBox_floor, true);
        }

        private void comboBox_filter_category_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }

        private void Form_Product_Load(object sender, EventArgs e)
        {

        }

        private void listBox_category_potential_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_category_potential, listBox_category_choosed);
        }

        private void listBox_category_choosed_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_category_choosed, listBox_category_potential);
        }

        private void listBox_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
