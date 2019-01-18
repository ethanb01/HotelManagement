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
    public partial class Form_CategoryRoom : Form
    {
        public Form_CategoryRoom()
        {
            InitializeComponent();
            CategoryRoomArrToForm(null);

        }

        public bool CheckGood()
        {
            bool flag = true;
            if (textBox_maxplace.Text.Length > 2)
            {
                flag = false;
                textBox_maxplace.BackColor = Color.Red;
            }
            if (textBox_price.Text.Length ==0)
            {
                flag = false;
                textBox_price.BackColor = Color.Red;
            }
            if (textBox_category.Text == "")
            {
                flag = false;
                textBox_category.BackColor = Color.Red;
            }
            return flag;

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
            textBox_maxplace.BackColor = Color.White;
            textBox_price.BackColor = Color.White;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!CheckGood())
            {
                MessageBox.Show("You didn't write right", "TRY AGAIN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                All_White();

            }
            else
            {
                CategoryRoom categoryRoom = FormToCategoryRoom();
                if (categoryRoom.ID == 0)
                {
                    CategoryRoomArr oldCategoryRoomArr = new CategoryRoomArr();
                    oldCategoryRoomArr.Fill();
                    if (!oldCategoryRoomArr.IsContain(categoryRoom.CategoryRoomName))
                    {
                        if (categoryRoom.Insert())
                        {
                            MessageBox.Show("CategoryRoom Details Saved");
                            Clean_Form();
                            CategoryRoomArr categoryRoomArr = new CategoryRoomArr();
                            categoryRoomArr.Fill();
                            categoryRoom = categoryRoomArr.GetCategoryRoonWithMaxId();
                            CategoryRoomArrToForm(categoryRoom);
                        }
                        else
                            MessageBox.Show("Cannot Save CategoryRoom Details");
                    }
                    else
                        MessageBox.Show("CategoryRoom already existing");


                }
                else
                {
                    if (categoryRoom.Update())
                    {
                        MessageBox.Show("CategoryRoom Details UPDATED");
                        Clean_Form();
                        CategoryRoomArrToForm(null);

                    }
                    else
                        MessageBox.Show("Cannot UPDATE CategoryRoom Details");
                }


            }
        }

        private CategoryRoom FormToCategoryRoom()
        {
            CategoryRoom categoryRoom = new CategoryRoom();
            categoryRoom.ID = int.Parse(label_ID.Text);
            categoryRoom.CategoryRoomName = textBox_category.Text;
            categoryRoom.MaxPlace = int.Parse(textBox_maxplace.Text);
            categoryRoom.Price = int.Parse(textBox_price.Text);
            return categoryRoom;
        }

        private void CategoryRoomArrToForm(CategoryRoom curCategoryRoom)
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            CategoryRoomArr CategoryRoomArr = new CategoryRoomArr();
            CategoryRoomArr.Fill();
            listBox_Category.DataSource = CategoryRoomArr;
            listBox_Category.ValueMember = "ID";
            listBox_Category.DisplayMember = "CategoryRoomName";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCategoryRoom != null)
                listBox_Category.SelectedValue = curCategoryRoom.ID;
        }

        private void CategoryRoomToForm(CategoryRoom categoryRoom)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_ID.Text = categoryRoom.ID.ToString();
            textBox_category.Text = categoryRoom.CategoryRoomName;
            textBox_maxplace.Text = categoryRoom.MaxPlace.ToString();
            textBox_price.Text = categoryRoom.Price.ToString();
        }

        private void listBox_CategoryRoom_DoubleClick(object sender, EventArgs e)
        {
            CategoryRoomToForm(listBox_Category.SelectedItem as CategoryRoom);
        }

        private void Cancel_Button(object sender, EventArgs e)
        {
            Close();
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            Clean_Form();
        }

        private void Clean_Form()
        {

            All_White();
            textBox_category.Text = "";
            label_ID.Text = "0";
            textBox_price.Text = "";
            textBox_maxplace.Text = "";
        }

        private void button_deleteCategoryRoom_Click(object sender, EventArgs e)
        {
            CategoryRoom categoryRoom = FormToCategoryRoom();
            if (categoryRoom.ID == 0)
            {
                MessageBox.Show("Please choice a CategoryRoom to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete the categoryRoom: " + categoryRoom.CategoryRoomName + " " + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    categoryRoom.Delete();
                    Clean_Form();
                    CategoryRoomArrToForm(null);
                }

            }
        }
        public CategoryRoom SelectedCategoryRoom
        {
            get { return (listBox_Category.SelectedItem as CategoryRoom); }
        }

        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            CategoryRoomToForm(listBox_Category.SelectedItem as CategoryRoom);
        }
    }
}
