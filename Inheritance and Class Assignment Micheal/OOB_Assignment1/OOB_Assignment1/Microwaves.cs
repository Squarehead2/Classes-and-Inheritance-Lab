using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    class Microwaves : Appliance
    {
        private double capacity;
        private char roomType;

        public double Capacity { get { return capacity; } set { capacity = value; } }
        public char RoomType { get { return roomType; } set { roomType = value; } }

        public Microwaves() 
        {
            Capacity = 0;
            RoomType = char.MinValue;
        }

        public override string ToString()
        {
            bool result;
            string RoomTypeString = string.Empty;

            if (result = RoomType.Equals('K'))
            { RoomTypeString = "Kitchen"; }

            else if (result = RoomType.Equals('W'))
            {
                RoomTypeString = "Work Site";
            }
            
            return base.ToString()+
                $"Capacity: {Capacity}\n" +
                $"Room Type:{RoomType}\n" ;
        }


    }
}
