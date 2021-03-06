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
    public class Room
    {

        private string m_roomNumber;
        public string RoomNumber { get => m_roomNumber; set => m_roomNumber = value; }

        private Floor m_floor;
        public Floor FloorNum
        {
            get { return m_floor; }
            set { m_floor = value; }
        }
        
        private CategoryRoom m_CategoryRoom;
        public CategoryRoom CategoryRoom
        {
            get { return m_CategoryRoom; }
            set { m_CategoryRoom = value; }
        }

        private int m_id;
        public int ID { get => m_id; set => m_id = value; }

        public Room() { }

        public Room(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח
            this.ID = (int)dataRow["ID"];
            this.m_roomNumber = dataRow["RoomNumber"].ToString();
            this.m_CategoryRoom= new CategoryRoom(dataRow.GetParentRow("CategoryRoom"));
            this.m_floor = new Floor(dataRow.GetParentRow("FloorRoom"));
        }

        public bool Insert()
        {
            return Room_DAL.Insert(m_roomNumber, m_CategoryRoom.ID, m_floor.ID);
        }

        public bool Update()
        {
            return Room_DAL.Update(m_roomNumber, m_CategoryRoom.ID, m_floor.ID, m_id);
        }


        public bool Delete()
        {
            return Room_DAL.Delete(m_id);
        }
        public override string ToString()
        {
            return " Room:" + m_roomNumber;
        }
    }
}
