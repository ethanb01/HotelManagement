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
    public partial class Form_Floor : Form
    {
        public Form_Floor()
        {
            InitializeComponent();
            FloorArrToForm(null);

        }



        public bool CheckGood()
        {
            bool flag = true;
            
            if (textBox_floor.Text == "")
            {
                flag = false;
                textBox_floor.BackColor = Color.Red;
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
            textBox_floor.BackColor = Color.White;
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
                Floor floor = FormToFloor();
                if (floor.ID == 0)
                {
                    FloorArr oldFloorArr = new FloorArr();
                    oldFloorArr.Fill();
                    if (!oldFloorArr.IsContain(floor.NumFloor))
                    {
                        if (floor.Insert())
                        {
                            MessageBox.Show("Floor Details Saved");
                            Clean_Form();
                            FloorArr floorArr = new FloorArr();
                            floorArr.Fill();
                            floor = floorArr.GetFloorWithMaxId();
                            FloorArrToForm(floor);
                        }
                        else
                            MessageBox.Show("Cannot Save Floor Details");
                    }
                    else
                        MessageBox.Show("Floor already existing");


                }
                else
                {
                    if (floor.Update())
                    {
                        MessageBox.Show("Floor Details UPDATED");
                        Clean_Form();
                        FloorArrToForm(null);

                    }
                    else
                        MessageBox.Show("Cannot UPDATE Floor Details");
                }


            }
        }

        private Floor FormToFloor()
        {
            Floor floor = new Floor();
            floor.ID = int.Parse(label_ID.Text);
            floor.NumFloor = textBox_floor.Text.ToString();
            return floor;
        }

        private void FloorArrToForm(Floor curFloor)
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            FloorArr FloorArr = new FloorArr();
            FloorArr.Fill();
            listBox_Floors.DataSource = FloorArr;
            listBox_Floors.ValueMember = "ID";
            listBox_Floors.DisplayMember = "NumFloor";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curFloor != null)
                listBox_Floors.SelectedValue = curFloor.ID;
        }

        private void FloorToForm(Floor floor)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_ID.Text = floor.ID.ToString();
            textBox_floor.Text = floor.NumFloor.ToString();
        }

        private void listBox_Floor_DoubleClick(object sender, EventArgs e)
        {
            FloorToForm(listBox_Floors.SelectedItem as Floor);
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
            textBox_floor.Text = "";
            label_ID.Text = "0";
        }

        private void button_deleteFloor_Click(object sender, EventArgs e)
        {
            Floor floor = FormToFloor();
            if (floor.ID == 0)
            {
                MessageBox.Show("Please choice a Floor to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete the floor: " + floor.NumFloor.ToString() + " " + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    floor.Delete();
                    Clean_Form();
                    FloorArrToForm(null);
                }

            }
        }

        public Floor SelectedFloor
        {
            get { return (listBox_Floors.SelectedItem as Floor); }
        }

        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            FloorToForm(listBox_Floors.SelectedItem as Floor);
        }
    }
}
