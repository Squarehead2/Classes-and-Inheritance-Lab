using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    // create class Microwaves and make it inherited from class Appliance
    class Microwaves : Appliance
    {
        // create attributes for class Microwaves
        private double capacity;
        private char roomType;

        // create public attributes to access private attributes
        public double Capacity { get { return capacity; } set { capacity = value; } }
        public char RoomType { get { return roomType; } set { roomType = value; } }

        //Construct
        public Microwaves() 
        {
            Capacity = 0;
            RoomType = char.MinValue;
        }

        // create method to change the attributes' type from char/double to string
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
                $"Room Type:{RoomTypeString}\n" ;
        }
    }
}
