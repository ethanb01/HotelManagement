using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.Properties;
using HotelManagement.BL;


namespace HotelManagement.UI
{
    public partial class Form_City : Form
    {
        public Form_City()
        {
            InitializeComponent();
            CityArrToForm();
        }


        public bool CheckGood()
        {
            bool flag = true;
            if (textBox_cityname.Text.Length < 2)
            {
                flag = false;
                textBox_cityname.BackColor = Color.Red;
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
            textBox_cityname.BackColor = Color.White;
           
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
                City city = FormToCity();
                if (city.ID == 0)
                {
                    CityArr oldCityArr = new CityArr();
                    oldCityArr.Fill();
                    if (!oldCityArr.IsContain(city.CityName))
                    {
                        if (city.Insert())
                        {
                            MessageBox.Show("City Details Saved");
                            Clean_Form();
                            CityArrToForm();

                        }
                        else
                            MessageBox.Show("Cannot Save City Details");
                    }
                    else
                        MessageBox.Show("City already existing");


                }
                else
                {
                    if (city.Update())
                    {
                        MessageBox.Show("City Details UPDATED");
                        Clean_Form();
                        CityArrToForm();

                    }
                    else
                        MessageBox.Show("Cannot UPDATE City Details");
                }


            }
        }

        private City FormToCity()
        {
            City city = new City();
            city.ID = int.Parse(label_ID.Text);
            city.CityName = textBox_cityname.Text;
            return city;
        }

        private void CityArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            CityArr CityArr = new CityArr();
            CityArr.Fill();
            listBox_City.DataSource = CityArr;
        }

        private void CityToForm(City city)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס
            label_ID.Text = city.ID.ToString();
            textBox_cityname.Text = city.CityName;
        }

        private void listBox_City_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(listBox_City.SelectedItem as City);
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
            textBox_cityname.Text = "";
            label_ID.Text = "0";
        }

        private void button_deleteCity_Click(object sender, EventArgs e)
        {
            City city = FormToCity();
            if (city.ID == 0)
            {
                MessageBox.Show("Please choice a City to delete");
            }
            else
            {

                if (MessageBox.Show("Are you sure to delete the city: " + city.CityName + " " + " ? ", "Be Careful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
                {
                    city.Delete();
                    Clean_Form();
                    CityArrToForm();
                }



            }
        }

    }
}
