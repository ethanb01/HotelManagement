using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UI
{
    public partial class Form_AdminLogin : Form
    {
        public Form_AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginButton(object sender, EventArgs e)
        {
            Form_AdminMenu form_menu;
            form_menu = new Form_AdminMenu();
            form_menu.ShowDialog();
            Close();
        }

       
    }
}
