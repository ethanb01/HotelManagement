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
    public partial class Form_Room : Form
    {
        public Form_Room()
        {
            InitializeComponent();
            RoomArrToForm();
            FloorArrToForm(null, comboBox_floor, true);
            CategoryArrToForm(null,comboBox_category,true);
            FloorArrToForm(null, comboBox_filter_floor, false);
            CategoryArrToForm(null, comboBox_filter_category, false);
            
        }

        private bool CapsLockChek()
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool flag = true;

        public bool CheckGood()
        
        {
            flag = true;
            if (textBox_room_number.Text.Length != 3)
            {
                flag = false;
                textBox_room_number.BackColor = Color.Red;
            }
            if (comboBox_floor.Text.Length != 1)
            {
                flag = false;
                comboBox_floor.BackColor = Color.Red;
            }
            if (comboBox_category.Text.Length < 2)
            {
                flag = false;
                comboBox_category.BackColor = Color.Red;
            }
            int max = int.Parse(comboBox_floor.Text) * 100 + 100;
            int min = int.Parse(comboBox_floor.Text) * 100;
            int roomNum = int.Parse(textBox_room_number.Text);
            if (roomNum < min || roomNum >= max)
            {
                flag = false;
                textBox_room_number.BackColor = Color.Red;
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
            textBox_room_number.BackColor = Color.White;
            comboBox_category.BackColor = Color.White;
            comboBox_floor.BackColor = Color.White;
        }

        private Room FormToRoom()
        {
            Room room = new Room();
            room.ID = int.Parse(label_ID.Text);
            room.RoomNumber= textBox_room_number.Text;
            room.FloorNum = (comboBox_floor.SelectedItem as Floor);
            room.CategoryRoom = (comboBox_category.SelectedItem as CategoryRoom);
            return room;
        }

        private void RoomArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            RoomArr roomArr = new RoomArr();
            roomArr.Fill();
            listBox_Rooms.DataSource = roomArr;
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            Clean_Form();
        }

        private void Clean_Form()
        { 
            All_White();
            textBox_room_number.Text = "";
            comboBox_category.Text = "";
            comboBox_floor.Text = "";
            label_ID.Text = "0";
            label_price.Text = "0";
        }

        private void RoomToForm(Room room)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_ID.Text = room.ID.ToString();
            textBox_room_number.Text = room.RoomNumber;
            comboBox_floor.Text = room.FloorNum.NumFloor.ToString();
            comboBox_category.Text = room.CategoryRoom.CategoryRoomName;
            label_price.Text = room.CategoryRoom.Price.ToString();
        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            RoomToForm(listBox_Rooms.SelectedItem as Room);
        }

        private void button_deleteClient_Click(object sender, EventArgs e)
        {
            Room room = FormToRoom();
            if (room.ID == 0)
            {
                MessageBox.Show("Please choice a Room to delete");
            }
            else
            {

                if (MessageBox.Show("Are you sure to delete the room: " + room.RoomNumber + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    room.Delete();
                    Clean_Form();
                    RoomArrToForm();
                }
            }
        }

        private void groupbox_roomNumber_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }

        private void SetProductsByFilter()
        {
            string numRoom = "";

            //אם המשתמש רשם ערך בשדה המזהה


            if (textbox_filter_room_number.Text != "")
                numRoom = textbox_filter_room_number.Text;

            //מייצרים אוסף של כלל המוצרים
            RoomArr roomArr = new RoomArr();
            roomArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            roomArr = roomArr.Filter(numRoom,

            comboBox_filter_floor.SelectedItem as Floor,
            comboBox_filter_category.SelectedItem as CategoryRoom);
            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Rooms.DataSource = roomArr;
        }

        public void CategoryArrToForm(CategoryRoom curCategoryRoom, ComboBox comboBox , bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס
            CategoryRoomArr catrgoryRoomArr = new CategoryRoomArr();
            CategoryRoom categoryRoomDefault = new CategoryRoom();
            categoryRoomDefault.ID = -1;
            if(isMustChoose)
                categoryRoomDefault.CategoryRoomName = "Choice category";
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
                categoryRoomDefault.NumFloor = "Choice Floor";
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

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!CheckGood())
            {
                MessageBox.Show("You didn't write right", "TRY AGAIN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                All_White();
            }
            else
            {
                Room room = FormToRoom();
                if (room.ID == 0)
                {
                    if (room.Insert())
                    {
                        MessageBox.Show("Rooms Details Saved");
                        Clean_Form();
                        RoomArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot Save Rooms Details");
                }
                else
                {
                    if (room.Update())
                    {
                        MessageBox.Show("Rooms Details UPDATED");
                        Clean_Form();
                        RoomArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot UPDATE Rooms Details");
                }


            }
        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_filter_category_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }

        private void button_add_category_Click(object sender, EventArgs e)
        {
            Form_CategoryRoom form_CategoryRoom;
            form_CategoryRoom = new Form_CategoryRoom();
            form_CategoryRoom.ShowDialog();
            CategoryArrToForm(form_CategoryRoom.SelectedCategoryRoom,comboBox_category,true);
        }

        private void button_new_floor_Click(object sender, EventArgs e)
        {
            Form_Floor form_Floor;
            form_Floor = new Form_Floor();
            form_Floor.ShowDialog();
            FloorArrToForm(form_Floor.SelectedFloor,comboBox_floor,true);
        }
    }
}
