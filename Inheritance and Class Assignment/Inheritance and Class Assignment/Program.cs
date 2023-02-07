using System;
using System.Diagnostics;
using System.Drawing;

namespace program
{
    public class appliances
    {
        protected string applianceName = "appliance";
        protected long itemNumber = 0;
        protected string brand = "";
        protected int quantity = 0;
        protected double wattage = 0D;
        protected string color = "red";
        protected double price = 0D;

        public long ItemNumber
        {
            get { return itemNumber; }
            set { itemNumber = value; }
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;

            }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Wattage
        {
            get { return wattage; }
            set { wattage = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public appliances(long ItemNumber, string Brand, int Quantity, double Wattage, string Color, double Price)
        {
            itemNumber = ItemNumber;
            brand = Brand;
            quantity = Quantity;
            wattage= Wattage;
            color = Color;
            price = Price;

        }

        public bool isAvailable()
        {
            if (quantity == 0)
            {
                return false;
            }
            else return true;
        }

        public void checkout()
        {
            Console.WriteLine("Appliance " + itemNumber + " has been checked out.");
        }

        public override string ToString()
        {
            return "this appliance is a " + applianceName;
        }


        public string formatForFile()
        {
            string formattedString =
                itemNumber.ToString() + ";" +
                brand + ";" +
                quantity.ToString() + ";" +
                wattage.ToString() + ";" +
                color + ";" +
                price.ToString() + ";";
            return formattedString;
        }
     




    }
    public class refrigerators : appliances
    {
        
        int doors = 0;
        double height = 0D;
        double width = 0D;
        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public refrigerators (long ItemNumber, string Brand, int Quantity, double Wattage, string Color, double Price, int Doors, double Height, double Width) : base(ItemNumber, Brand, Quantity, Wattage, Color, Price)
        {
            doors = Doors;
            height = Height; 
            width = Width;
            applianceName = "refrigerator";

        }
        public string formatForFile()
        {
            string formattedString =
                itemNumber.ToString() + ";" +
                brand + ";" +
                quantity.ToString() + ";" +
                wattage.ToString() + ";" +
                color + ";" +
                price.ToString() + ";" +
                doors.ToString() + ";" +
                height.ToString() + ";" +
                width.ToString() + ";";

            return formattedString;
        }

    }
    public class vacuums : appliances
    {
        string grade = "";
        double batteryVoltage = 0D;
        public string Grade
        {
            get { return grade; }
            set { grade = value; } 
        }
        public double BatteryVoltage
        {
            get { return batteryVoltage; }
            set { batteryVoltage = value; }
        }

        public vacuums(long ItemNumber, string Brand, int Quantity, double Wattage, string Color, double Price, string Grade, double BatteryVoltage) : base(ItemNumber, Brand, Quantity, Wattage, Color, Price)
        {
            batteryVoltage = BatteryVoltage;
            grade = Grade;
            applianceName = "vacuum";
        }

        public string formatForFile()
        {
            string formattedString =
                itemNumber.ToString() + ";" +
                brand + ";" +
                quantity.ToString() + ";" +
                wattage.ToString() + ";" +
                color + ";" +
                price.ToString() + ";" +
                grade + ";" +
                batteryVoltage.ToString() + ";";
                
            return formattedString;
        }
    }
    public class microwaves : appliances
    {
        int capacity = 0;
        char roomType = 'K';
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }  
        }
        public char RoomType
        {
            get { return roomType; }
            set
            {
                if (value != 'K' | value != 'W')
                {
                    roomType = 'K';
                }
                else
                {
                    roomType = value;
                }
            }
        }
        public microwaves(long ItemNumber, string Brand, int Quantity, double Wattage, string Color, double Price, int Capacity, char RoomType) : base(ItemNumber, Brand, Quantity, Wattage, Color, Price)
        {
            capacity= Capacity;
            if (RoomType != 'K' | RoomType != 'W')
            {
                roomType = 'K';
            }
            else
            {
                roomType = RoomType;
            }
            applianceName = "microwave";
        }

        public string formatForFile()
        {
            string formattedString =
                itemNumber.ToString() + ";" +
                brand + ";" +
                quantity.ToString() + ";" +
                wattage.ToString() + ";" +
                color + ";" +
                price.ToString() + ";" +
                capacity.ToString() + ";" +
                roomType + ";";

            return formattedString;
        }
    }

    public class dishwashers : appliances
    {
        string soundRating = "";
        string feature = "";
        string finish = "";

        public string SoundRating
        {
            get { return soundRating; }
            set { soundRating = value; }
        }
        public string Feature
        {
            get { return feature; }
            set { feature = value; }
        }

        public string Finish
        {
            get { return finish; }
            set { finish = value; }
        }

        public dishwashers(long ItemNumber, string Brand, int Quantity, double Wattage, string Color, double Price,string SoundRating, string Feature, string Finish) : base(ItemNumber, Brand, Quantity, Wattage, Color, Price)
        {
            soundRating = SoundRating;
            feature = Feature;
            finish = Finish;
            applianceName = "dishwasher";
        }

        public string formatForFile()
        {
            string formattedString =
                itemNumber.ToString() + ";" +
                brand + ";" +
                quantity.ToString() + ";" +
                wattage.ToString() + ";" +
                color + ";" +
                price.ToString() + ";" +
                soundRating + ";" +
                feature + ";" +
                finish + ";";

            return formattedString;
        }


    }



    
    public class program
    {



        public static void Main()
        {
            refrigerators fridge = new refrigerators(1234, "test", 8, 8, "Black", 8, 4, 8, 8);
        }
    }


}


