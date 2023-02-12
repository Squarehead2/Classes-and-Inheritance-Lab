using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    class Refrigerators : Appliance
    {

        
        private int numDoor;
        private int height;
        private int width;

        
        public int NumDoor { get { return numDoor; } set { numDoor = value; } }
        public int Height { get { return height; } set { height = value; } }
        public int Width { get { return width; } set { width = value; } }


        public Refrigerators() 
        {
            NumDoor = 0;
            Height = 0;
            Width = 0;
        }

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

        public string formatForFile()
        {
            string formattedString =
                numDoor.ToString() + ";" +
                height.ToString() + ";" +
                width.ToString() + ";";

            return formattedString;
        }



    }
}
