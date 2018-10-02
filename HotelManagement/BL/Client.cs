using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.BL;
using HotelManagement.DAL;

namespace HotelManagement.BL
{
    class Client
    {

        private string m_firstName;
        public string FirstName { get => m_firstName; set => m_firstName = value; }

        private string m_lastName;
        public string LastName { get => m_lastName; set => m_lastName = value; }

        private string m_mail;
        public string Mail { get => m_mail; set => m_mail = value; }

        private string m_phone;
        public string Phone { get => m_phone; set => m_phone= value; }

        private string m_id;
        public string Id { get => m_id; set => m_id = value; }

        private string m_creditCard;
        public string CreditCard { get => m_creditCard; set => m_creditCard = value; }






        public bool Insert()
        {
            return Client_DAL.Insert(m_firstName, m_lastName, m_mail, m_id, m_phone, m_creditCard);
        }
    }
}
