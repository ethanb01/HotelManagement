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
    public partial class Form_OrderRoom : Form
    {
        public Form_OrderRoom()
        {
            InitializeComponent();
            OrderRoomArrToForm();
            ClientArrToForm();
            RoomArrToForm();

            FloorArrToForm(null, comboBox_filter_floor, false);
            CategoryArrToForm(null, comboBox_filter_category, false);
            RoomArrToForm(null,comboBox_filter_room,false);
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
            label_order_roomNumber.Text = "Choose Room";
            label_order_id.Text = "0";
            label_order_price.Text = "0";
        }
        #endregion

        #region Order Page

        private void Button_Delete_Order(object sender, EventArgs e)
        {
            OrderRoom orderRoom = FormToOrderRoom();
            if (orderRoom.ID == 0)
            {
                MessageBox.Show("Please choice an order to delete");
            }
            else
            {

                if (MessageBox.Show("Are you sure to delete the order: " + orderRoom.ID + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    orderRoom.Delete();
                    Clean_Form();
                    OrderRoomArrToForm();
                }
            }
        }

        private void Button_Save(object sender, EventArgs e)
        {
            if (!CheckGood())
            {
                MessageBox.Show("You didn't write right,\n You need to: \n " + to_change , "TRY AGAIN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                All_White();
                to_change = "";
            }
            else
            {
                OrderRoom orderRoom = FormToOrderRoom();
                if (orderRoom.ID == 0)
                {
                    if (orderRoom.Insert())
                    {
                        MessageBox.Show("Order Details Saved");
                        Clean_Form();
                        OrderRoomArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot Save Order Details");
                }
                else
                {
                    if (orderRoom.Update())
                    {
                        MessageBox.Show("Order Details UPDATED");
                        Clean_Form();
                        OrderRoomArrToForm();

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
            if (label_client_id.Text == "")
            {
                to_change += "Select a Client\n";
                flag = false;
            }


            return flag;

        }

        private OrderRoom FormToOrderRoom()
        {
            OrderRoom orderRoom = new OrderRoom();
            orderRoom.ID = int.Parse(label_order_id.Text);
            orderRoom.Room = (listBox_Rooms.SelectedItem as Room);
            orderRoom.CheckinDate = date_checkin.Value.Date;
            orderRoom.CheckoutDate = date_checkout.Value.Date;
            orderRoom.OrderDate = order_date.Value.Date;
            orderRoom.Client = (listBox_Clients.SelectedItem as Client);
            orderRoom.Comment = textBox_comment.Text;
            return orderRoom;
        }

        private void OrderRoomArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            OrderRoomArr orderRoomArr = new OrderRoomArr();
            orderRoomArr.Fill();
            listBox_orders.DataSource = orderRoomArr;
        }

        private void OrderRoomToForm(OrderRoom orderRoom)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_order_id.Text = orderRoom.ID.ToString();
            label_order_roomNumber.Text = orderRoom.Room.RoomNumber;
            date_checkin.Value = orderRoom.CheckinDate;
            date_checkout.Value = orderRoom.CheckoutDate;
            order_date.Value = orderRoom.OrderDate;
            textBox_comment.Text = orderRoom.Comment;
            label_order_price.Text = orderRoom.TotalPrice.ToString();
        }

        private void Click_ListBoxOrder(object sender, EventArgs e)
        {
            OrderRoomToForm(listBox_orders.SelectedItem as OrderRoom);
            ClientToForm((listBox_orders.SelectedItem as OrderRoom).Client);
            RoomToForm((listBox_orders.SelectedItem as OrderRoom).Room);
        }

        public void ClientArrToForm(Client curClient, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס
            ClientArr clientArr= new ClientArr();
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
            comboBox.DisplayMember = "FirstName "+"LastName: "+ "Taz";
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

        #region Client page


        private void ClientArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client);
        }

        private void ClientToForm(Client client)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_client_id.Text = client.ID.ToString();
            label_client_firstname.Text = client.FirstName;
            label_client_lastname.Text = client.LastName;
            label_client_phone.Text = client.Phone;
            label_client_mail.Text = client.Mail;
            label_client_taz.Text = client.Taz;
            label_client_creditcard.Text = client.CreditCard;
            label_client_city.Text = client.City.ToString();
        }

        private void FilterClient(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (groupbox_taz.Text != "")
                id = int.Parse(groupbox_taz.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id.ToString(), groupbox_lastname.Text, groupbox_phone.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }


        #endregion

        #region Room page
        private void RoomArrToForm()
        {
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
            SetProductsByFilter();
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

        private void SetProductsByFilter()
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







        private void groupbox_roomNumber_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }

        //private void SetProductsByFilter()
        //{
        //    string numRoom = "";

        //    //אם המשתמש רשם ערך בשדה המזהה


        //    if (textbox_filter_room_number.Text != "")
        //        numRoom = textbox_filter_room_number.Text;

        //    //מייצרים אוסף של כלל המוצרים
        //    RoomArr roomArr = new RoomArr();
        //    roomArr.Fill();

        //    //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

        //    roomArr = roomArr.Filter(numRoom,

        //    comboBox_filter_room.SelectedItem as Floor,
        //    comboBox_filter_category.SelectedItem as CategoryRoom);
        //    //מציבים בתיבת הרשימה את אוסף המוצרים

        //    listBox_orders.DataSource = roomArr;
        //} 
        //2 checkkkk


        private void comboBox_filter_category_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }

      
        //private void button_add_category_Click(object sender, EventArgs e)
        //{
        //    Form_CategoryRoom form_CategoryRoom;
        //    form_CategoryRoom = new Form_CategoryRoom();
        //    form_CategoryRoom.ShowDialog();
        //    CategoryArrToForm(form_CategoryRoom.SelectedCategoryRoom, comboBox_checkin, true);
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
