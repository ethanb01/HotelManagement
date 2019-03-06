using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.BL;
using HotelManagement.DAL;
using System.Data;

namespace HotelManagement.BL
{
    public class OrderRoom
    {
        private int m_id;
        public int ID { get => m_id; set => m_id = value; }

        private Client m_client;
        public Client Client{ get => m_client; set => m_client= value; }

        private DateTime m_checkin;
        public DateTime CheckinDate
        {
            get { return m_checkin; }
            set { m_checkin = value; }
        }

        private DateTime m_checkout;
        public DateTime CheckoutDate
        {
            get { return m_checkout; }
            set { m_checkout = value; }
        }

        private Room m_room;
        public Room Room
        {
            get { return m_room; }
            set { m_room = value; }
        }

        private DateTime m_dateOrder;
        public DateTime OrderDate
        {
            get { return m_dateOrder; }
            set { m_dateOrder = value; }
        }

        private string m_comment;
        public string Comment { get => m_comment; set => m_comment = value; }

        private int m_totalPrice;
        public int TotalPrice { get => m_totalPrice; set => m_totalPrice = value; }


        public OrderRoom() { }

        public OrderRoom(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.ID = (int)dataRow["ID"];
            this.m_client = new Client(dataRow.GetParentRow("OrderRoomClient"));
            this.m_checkout = (DateTime)dataRow["DateCheckout"];
            this.m_checkin = (DateTime)dataRow["DateCheckin"];
            this.m_dateOrder = (DateTime)dataRow["DateOrder"];
            this.m_room = new Room(dataRow.GetParentRow("OrderRoomRoom"));
            this.m_comment = dataRow["Comment"].ToString();
            this.m_totalPrice = (int)dataRow["TotalPrice"];
        }

        public bool Insert()
        {
            return OrderRoom_DAL.Insert(m_client.ID,m_checkin,m_checkout,m_room.ID,m_comment,m_dateOrder,m_totalPrice);
        }

        public bool Update()
        {
            return OrderRoom_DAL.Update(m_id, m_client.ID, m_checkin, m_checkout, m_room.ID, m_comment, m_dateOrder, m_totalPrice);
        }


        public bool Delete()
        {
            return OrderRoom_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return " OrderRoom: " + m_dateOrder.ToString();
        }
    }
}
