﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.BL;
using HotelManagement.DAL;
using System.Data;

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

        private string m_taz;
        public string Taz { get => m_taz; set => m_taz = value; }

        private string m_creditCard;
        public string CreditCard { get => m_creditCard; set => m_creditCard = value; }

        private string m_id;
        public string ID { get => m_id; set => m_id = value; }




        public Client() { }

        public Client(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח

            this.m_taz = dataRow["IdNum"].ToString();
            this.m_firstName= dataRow["FirstName"].ToString();
            this.m_lastName = dataRow["LastName"].ToString();
            this.m_phone= dataRow["Phone"].ToString();
            this.m_mail = dataRow["Mail"].ToString();
            this.m_creditCard = dataRow["CreditCard"].ToString();
        }

        public bool Insert()
        {
            return Client_DAL.Insert(m_firstName, m_lastName, m_mail, m_taz, m_phone, m_creditCard);
        }

        public bool Update()
        {
            return Client_DAL.Update(m_id, m_firstName, m_lastName, m_mail , m_taz, m_phone , m_creditCard);
        }

        public override string ToString()
        {
            return m_firstName + " " + m_lastName;
        }
    }
}
