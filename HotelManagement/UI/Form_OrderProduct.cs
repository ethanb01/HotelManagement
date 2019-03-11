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
    public partial class Form_OrderProduct : Form
    {
        public Form_OrderProduct()
        {
            InitializeComponent();
            OrderProductArrToForm();
            //ClientArrToForm();
            RoomArrToForm();

            FloorArrToForm(null, comboBox_filter_floor, false);
            CategoryArrToForm(null, comboBox_filter_category, false);
            //ProductArrToForm(null, comboBox_filter_product, false);
        }

        #region General Functions
        private bool CapsLockChek()
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }

        private void exit_button(object sender, EventArgs e)
        {
            Close();
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
            label_order_roomNumber.BackColor = Color.White;
            //date to white
        }

        private void button_clean_form(object sender, EventArgs e)
        {
            Clean_Form();
        }

        private void Clean_Form()
        {
            All_White();
            label_order_roomNumber.Text = "Choose Product";
            label_order_id.Text = "0";
            label_order_price.Text = "0";
        }
        #endregion

        #region Order Page

        private void Button_Delete_Order(object sender, EventArgs e)
        {
            OrderProduct orderProduct = FormToOrderProduct();
            if (orderProduct.ID == 0)
            {
                MessageBox.Show("Please choice an order to delete");
            }
            else
            {

                if (MessageBox.Show("Are you sure to delete the order: " + orderProduct.ID + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    orderProduct.Delete();
                    Clean_Form();
                    OrderProductArrToForm();
                }
            }
        }

        private void Button_Save(object sender, EventArgs e)
        {
            if (!CheckGood())
            {
                MessageBox.Show("You didn't write right,\n You need to: \n " + to_change, "TRY AGAIN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                All_White();
                to_change = "";
            }
            else
            {
                OrderProduct orderProduct = FormToOrderProduct();
                if (orderProduct.ID == 0)
                {
                    if (orderProduct.Insert())
                    {
                        MessageBox.Show("Order Details Saved");
                        Clean_Form();
                        OrderProductArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot Save Order Details");
                }
                else
                {
                    if (orderProduct.Update())
                    {
                        MessageBox.Show("Order Details UPDATED");
                        Clean_Form();
                        OrderProductArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot UPDATE order Details");
                }


            }
        }

        private bool flag = true;
        private string to_change = "";

        public bool CheckGood()

        {
            flag = true;
            if (label_order_roomNumber.Text.Length != 3)
            {
                flag = false;
                to_change += "Select a Room\n";
            }
            

            return flag;

        }

        private OrderProduct FormToOrderProduct()
        {
            OrderProduct orderProduct = new OrderProduct();
            orderProduct.ID = int.Parse(label_order_id.Text);
            orderProduct.Room = (listBox_Rooms.SelectedItem as Room);
            orderProduct.OrderDate = order_date.Value.Date;
            orderProduct.Comment = textBox_comment.Text;
            orderProduct.TotalPrice = int.Parse(label_order_price.Text);
            return orderProduct;
        }

        private void OrderProductArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();
            listBox_orders.DataSource = orderProductArr;
        }

        private void OrderProductToForm(OrderProduct orderProduct)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_order_id.Text = orderProduct.ID.ToString();
            order_date.Value = orderProduct.OrderDate;
            textBox_comment.Text = orderProduct.Comment;
            label_order_price.Text = orderProduct.TotalPrice.ToString();
            RoomToForm(orderProduct.Room);
            label_order_roomNumber.Text = orderProduct.Room.RoomNumber.ToString();
        }

        private void Click_ListBoxOrder(object sender, EventArgs e)
        {
            OrderProductToForm(listBox_orders.SelectedItem as OrderProduct);
            RoomToForm((listBox_orders.SelectedItem as OrderProduct).Room);
        }//listbox_cart

        public void ClientArrToForm(Client curClient, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס
            ClientArr clientArr = new ClientArr();
            Client clientDefault = new Client();
            clientDefault.ID = -1;
            if (isMustChoose)
                clientDefault.FirstName = "Choose category";
            else
                clientDefault.FirstName = "Every category";

            clientArr.Add(clientDefault);

            clientArr.Fill();
            comboBox.DataSource = clientArr;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "FirstName " + "LastName: " + "Taz";
            if (curClient != null)
                comboBox.SelectedValue = curClient.ID;
        }

        public void RoomArrToForm(Room curRoom, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס
            RoomArr roomArr = new RoomArr();
            Room roomDefault = new Room();
            roomDefault.ID = -1;
            if (isMustChoose)
                roomDefault.RoomNumber = "Choose category";
            else
                roomDefault.RoomNumber = "Every category";

            roomArr.Add(roomDefault);

            roomArr.Fill();
            comboBox.DataSource = roomArr;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "RoomNumber";
            if (curRoom != null)
                comboBox.SelectedValue = curRoom.ID;
        }



        #endregion


        
        #region Room page
        private void RoomArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            RoomArr roomArr = new RoomArr();
            roomArr.Fill();
            listBox_Rooms.DataSource = roomArr;
        }

        private void RoomToForm(Room room)
        {
            label_room_id.Text = room.ID.ToString();
            label_room_number.Text = room.RoomNumber;
            label_room_floor.Text = room.FloorNum.NumFloor.ToString();
            label_roon_category.Text = room.CategoryRoom.CategoryRoomName;
            label_room_price.Text = room.CategoryRoom.Price.ToString();
        }

        
        private void listBox_Room_DoubleClick(object sender, EventArgs e)
        {
            label_order_roomNumber.Text = (listBox_Rooms.SelectedItem as Room).RoomNumber;
            RoomToForm(listBox_Rooms.SelectedItem as Room);
        }
        private void RoomFilter(object sender, EventArgs e)
        {
            SetRoomsByFilter();
        }

        public void CategoryArrToForm(CategoryRoom curCategoryRoom, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס
            CategoryRoomArr catrgoryRoomArr = new CategoryRoomArr();
            CategoryRoom categoryRoomDefault = new CategoryRoom();
            categoryRoomDefault.ID = -1;
            if (isMustChoose)
                categoryRoomDefault.CategoryRoomName = "Choose category";
            else
                categoryRoomDefault.CategoryRoomName = "Every category";

            catrgoryRoomArr.Add(categoryRoomDefault);

            catrgoryRoomArr.Fill();
            comboBox.DataSource = catrgoryRoomArr;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "CategoryRoomName";
            if (curCategoryRoom != null)
                comboBox.SelectedValue = curCategoryRoom.ID;
        }

        public void FloorArrToForm(Floor curFloor, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס
            FloorArr catrgoryRoomArr = new FloorArr();
            Floor categoryRoomDefault = new Floor();
            categoryRoomDefault.ID = -1;
            if (isMustChoose)
                categoryRoomDefault.NumFloor = "Choose Floor";
            else
                categoryRoomDefault.NumFloor = "Every Floor";

            catrgoryRoomArr.Add(categoryRoomDefault);

            catrgoryRoomArr.Fill();
            comboBox.DataSource = catrgoryRoomArr;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "NumFloor";
            if (curFloor != null)
                comboBox.SelectedValue = curFloor.ID;
        }

        private void SetRoomsByFilter()
        {
            string numRoom = "";

            if (textbox_filter_room_number.Text != "")
                numRoom = textbox_filter_room_number.Text;

            RoomArr roomArr = new RoomArr();
            roomArr.Fill();

            roomArr = roomArr.Filter(numRoom,

            comboBox_filter_floor.SelectedItem as Floor,
            comboBox_filter_category.SelectedItem as CategoryRoom);

            listBox_Rooms.DataSource = roomArr;
        }
        #endregion







        private void groupbox_productNumber_KeyUp(object sender, KeyEventArgs e)
        {
            SetRoomsByFilter();
        }

        //private void SetProductsByFilter()
        //{
        //    string numProduct = "";

        //    //אם המשתמש רשם ערך בשדה המזהה


        //    if (textbox_filter_product_number.Text != "")
        //        numProduct = textbox_filter_product_number.Text;

        //    //מייצרים אוסף של כלל המוצרים
        //    ProductArr productArr = new ProductArr();
        //    productArr.Fill();

        //    //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

        //    productArr = productArr.Filter(numProduct,

        //    comboBox_filter_product.SelectedItem as Floor,
        //    comboBox_filter_category.SelectedItem as CategoryProduct);
        //    //מציבים בתיבת הרשימה את אוסף המוצרים

        //    listBox_orders.DataSource = productArr;
        //} 
        //2 checkkkk


        private void comboBox_filter_category_TextChanged(object sender, EventArgs e)
        {
            SetRoomsByFilter();
        }


        //private void button_add_category_Click(object sender, EventArgs e)
        //{
        //    Form_CategoryProduct form_CategoryProduct;
        //    form_CategoryProduct = new Form_CategoryProduct();
        //    form_CategoryProduct.ShowDialog();
        //    CategoryArrToForm(form_CategoryProduct.SelectedCategoryProduct, comboBox_checkin, true);
        //}

        //private void button_new_floor_Click(object sender, EventArgs e)
        //{
        //    Form_Floor form_Floor;
        //    form_Floor = new Form_Floor();
        //    form_Floor.ShowDialog();
        //    FloorArrToForm(form_Floor.SelectedFloor, comboBox_checkout, true);
        //}




    }
}
