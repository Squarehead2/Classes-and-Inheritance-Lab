using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    //create class Refrigerators and make it inherited from the class Appliance
    class Refrigerators : Appliance
    {

        // create attributes for class Refrigerators
        private int numDoor;
        private int height;
        private int width;


        //create public attributes to access the private attributes
        public int NumDoor { get { return numDoor; } set { numDoor = value; } }
        public int Height { get { return height; } set { height = value; } }
        public int Width { get { return width; } set { width = value; } }

        //Construct
        public Refrigerators() 
        {
            NumDoor = 0;
            Height = 0;
            Width = 0;
        }

        //create method to change the attributes' type from int to string for displaying information
        public override string ToString()
        {
            string NumDoorString = string.Empty;

            if (NumDoor == 2)
            {
                NumDoorString = "Double Doors";
            }
            else if (NumDoor == 3)
            {
                NumDoorString = "Three Doors";
            }


            else if (NumDoor == 4)
            {
                NumDoorString = "Four Doors";
            }

            return
                base.ToString() +
                $"Number of Doors: {NumDoorString}\n" +
                $"Height: {Height}\n" +
                $"Width: {Width}\n";
        }
    }
}
