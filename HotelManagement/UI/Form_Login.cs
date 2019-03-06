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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void LoginAdmin(object sender, EventArgs e)
        {
            Form_AdminLogin form_admin;
            form_admin = new Form_AdminLogin();
            form_admin.ShowDialog();
            Close();
        }
        private void LoginClient(object sender, EventArgs e)
        {
            Form_ClientLogin form_client;
            form_client = new Form_ClientLogin();
            form_client.ShowDialog();
            Close();
        }

       
    }
}
