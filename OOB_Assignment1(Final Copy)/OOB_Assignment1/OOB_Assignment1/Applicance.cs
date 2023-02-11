using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    //create a Appliance Class
    class Appliance
    {
        //create attributes
        private long itemNum;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        //create public attributes access the private attributes in the class
        public long ItemNumber { get { return itemNum; } set { itemNum = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public double Wattage { get { return wattage; } set { wattage = value; } }
        public string Color { get { return color; } set { color = value; } }
        public double Price { get { return price; } set { price = value; } }

        //Construct 
        public Appliance()
        {
            ItemNumber = 0;
            Brand = string.Empty;
            Quantity = 0;
            Wattage = 0;
            Color = string.Empty;
            Price = 0;
        }

       
        // create method to change the type of attributes to string
        public override string ToString()
        {
            return
                $"Item Number:{ItemNumber}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}\n" +
                $"Color:{Color}\n" +
                $"Price: {Price}\n";
        }
    }
}
