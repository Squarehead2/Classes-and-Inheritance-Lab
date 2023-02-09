using System;
using System.Collections.Generic;
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


            return
                base.ToString() +
                $"Number of Doors: {NumDoor}\n" +
                $"Height: {Height}\n" +
                $"Width: {Width}\n";
        }




    }
}
