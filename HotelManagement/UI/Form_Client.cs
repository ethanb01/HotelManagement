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

namespace HotelManagement
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
            //Form_Client_InputLanguageChanged(null, null);

        }


        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            InputLanguage myCurrentLang = InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() != "en-us")
                MessageBox.Show("Language not english");


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

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!CheckGood())
            {
                MessageBox.Show("You didn't write right", "TRY AGAIN", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                All_White();

            }
            else
            {
                Client client = FormToClient();

                if (client.Insert())
                {
                    MessageBox.Show("Clients Details Saved");
                }


            }
        }

        public bool CheckGood()
        {
            flag = true;
            if (textBox_first_name.Text.Length < 2)
            {
                flag = false;
                textBox_first_name.BackColor = Color.Red;
            }
            if (textBox_lastname.Text.Length < 2)
            {
                flag = false;
                textBox_lastname.BackColor = Color.Red;
            }

         
            if (textBox_phone.Text.Length != 10)
            {
                flag = false;
                textBox_phone.BackColor = Color.Red;
            }
            if (textBox_creditcard.Text.Length != 16)
            {
                flag = false;
                textBox_creditcard.BackColor = Color.Red;
            }
            if (textBox_id.Text.Length != 9)
            {
                flag = false;
                textBox_id.BackColor = Color.Red;
            }
            if (textBox_mail.Text.Length < 3)
            {
                flag = false;
                textBox_mail.BackColor = Color.Red;
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
            textBox_creditcard.BackColor = Color.White;
            textBox_first_name.BackColor = Color.White;
            textBox_mail.BackColor = Color.White;
            textBox_id.BackColor = Color.White;
            textBox_phone.BackColor = Color.White;
            textBox_lastname.BackColor = Color.White;
            
        }

        private Client FormToClient()
        {
            Client client = new Client();

            client.FirstName = textBox_first_name.Text;
            client.LastName = textBox_lastname.Text;
            client.Mail = textBox_mail.Text;
            client.Phone = textBox_phone.Text;
            client.Id = textBox_id.Text;
            client.CreditCard = textBox_creditcard.Text;
            return client;
        }

        private void ClientArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }
    }
}

