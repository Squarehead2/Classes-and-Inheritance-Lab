using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using OOB_Assignment1.Properties;
/*  
    Class and Inheritance Lab Assignment
    Programmed 2023-02-10
    Programmed by, William Black, Dorian Laycock and Micheal Ngan


    This program takes data from a .txt file and organizes the information so users can checkout appliances, find appliances by brand, find appliances by type and produce a random list of appliances
    The Program takes specific integer inputs and converts uses if else statements to organize what functions to run and how to organize the data
 */

namespace OOB_Assignment1
{
    // create class ProblemDomain to run the program
    class ProblemDomain
    {
        //create a list to access the data
        public static List<Appliance> allApplicance = new List<Appliance>();
        
        // put all methods into Main() method
        public static void Main()
        {
            //start the program with a list
            ReadAndCreateAList();
            
            //loops start
            int option = 0;
            while (option != 5)
            {
                //ask the user to give and input and display different results accordingly
                Console.WriteLine("Welcome to Modern Appliances!\nHow May We Assist You \n1 – Check out appliance \n2 – Find appliances by brand \n3 – Display appliances by type\n4 – Produce random appliance list\n5 – Save & exit\n");
                Console.Write("Enter option: \n");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    checkoutAppliance();
                }

                else if (option == 2)
                {
                    SelectBrand();
                }

                else if (option == 3)
                {
                    SelectApplianceType();
                }

                else if (option == 4)
                {
                    RandomPick();
                }
            }
        }

        public static void SelectBrand() //This function takes an input from the user and converts it to a string that the function uses to compare it against a list of brand names that exist in the applianceList
        {
            Console.Write("Enter brand to search for: \n");
            string input = Console.ReadLine();
            string brandSearch = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());

            foreach (Appliance obj in allApplicance)
            {
                if (brandSearch == obj.Brand)
                {
                    Console.WriteLine($"Matching Appliances:\n{obj}");
                }
            }
        }
        public static void checkoutAppliance() //This function takes an item number input from the user which the function uses to compare against a list created from the .txt file
        {
            Appliance checkOutAppliance = new Appliance();
            Console.WriteLine("Enter the item number of an Appliance:");
            string numberString = Console.ReadLine();
            List<string> dataList = new List<string>();
            List<string> lineList = new List<string>();
            List<string> firstWordList = new List<string>();
            long itemNumber = long.Parse(numberString);
            long itemNumberInList;

            string[] data = Resources.appliances.Split(Environment.NewLine);
            foreach (string line in data)
            {
                string[] lineArray = line.Split(';');
                dataList.Add(lineArray[0]);
            }

            if (dataList.Contains(itemNumber.ToString()))//If statements makes sure the appliance exists
            {

                foreach (string line in data) //loops through all the data provided in the file
                {

                    lineList.Clear();
                    foreach (string word in line.Split(';')) //Appends first word of the function
                    {
                        lineList.Add(word);
                        firstWordList.Add(lineList[0]);
                    }

                    itemNumberInList = long.Parse(lineList[0]);

                    if (firstWordList.Contains(itemNumber.ToString()))
                    {
                        if (itemNumberInList == itemNumber)
                        {
                            checkOutAppliance.ItemNumber = itemNumber;
                            checkOutAppliance.Quantity = int.Parse(lineList[2]);
                            checkOutAppliance.Price = double.Parse(lineList[5]);
                            if (checkOutAppliance.Quantity > 0)
                            {
                                Console.WriteLine("Appliance \"" + itemNumber.ToString() + "\" has been checked out.");
                                break;
                            }
                            else if (checkOutAppliance.Quantity == 0)
                            {
                                Console.WriteLine("Appliance is not available to be checked out.");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No appliance found with that item number.");
            }
        }
        
        // create method to ask users to select the appliance type
        public static void SelectApplianceType()
        {
            Console.WriteLine("Appliance Types\r\n1 – Refrigerators\r\n2 – Vacuums\r\n3 – Microwaves\r\n4 – Dishwashers\r\n");
            Console.Write("Enter type of appliance: \n");
            int option_type = Convert.ToInt32(Console.ReadLine());
            
            // reading users' input and provide the relevant result
            if (option_type == 1) 
            {
                SelectRefrigeratorWithDoors();
            }

            else if (option_type == 2) 
            {
                SelectVacuumsWithVoltage();
            }

            else if (option_type == 3) 
            { 
                SelectMircrowaveWithRoomType();
            }

            else SelectDishwasher();
        }
        
        // create a method to ask user to select refrigeratos doors and display result accordingly
        public static void SelectRefrigeratorWithDoors() 
        {   
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
            int preferNumOfDoor = Convert.ToInt32(Console.ReadLine());
            foreach (Appliance obj in allApplicance) 
            {
                if (obj is Refrigerators)
                {
                    Refrigerators refrigerators = (Refrigerators)obj;

                    if(preferNumOfDoor == refrigerators.NumDoor) 
                    {                    
                        Console.WriteLine(refrigerators.ToString()); 
                    }              
                }
            }

        }
        
        // create a method to ask user to select vaccums voltage and display result accordingly
        public static void SelectVacuumsWithVoltage() 
        {
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high):");
            int preferVoltage = Convert.ToInt32(Console.ReadLine());
            foreach (Appliance obj in allApplicance)
            {
                if (obj is Vacuums) 
                {
                    Vacuums vaccums = (Vacuums)obj;

                    if (preferVoltage == vaccums.BatteryVottage) 
                    {
                        Console.WriteLine(vaccums.ToString());
                    }
                }
            }
        }
        
        //create a method to ask user to select microwaves room type and display result accordingly
        public static void SelectMircrowaveWithRoomType()
        {
            Console.WriteLine("RoomWhere the microwave will be installed: K (kitchen) or W (work site):");
            char preferRoomType = Console.ReadLine()[0];

            foreach (Appliance obj in allApplicance)
            {
                if (obj is Microwaves)
                {
                    Microwaves microwaves = (Microwaves)obj;

                    if (preferRoomType == microwaves.RoomType) 
                    {
                        Console.WriteLine(microwaves.ToString());
                    
                    }
                }
            }
        }
        
        // create a method to ask user to select dishwashers sound rating and display result accordingly
        public static void SelectDishwasher() 
        {
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
            string preferSoundRating = Console.ReadLine();
            foreach (Appliance obj in allApplicance)
            {
                if (obj is Dishwashers)
                {
                    Dishwashers dishwashers = (Dishwashers)obj;
                    if (preferSoundRating == dishwashers.SoundRating) 
                    {
                        Console.WriteLine(dishwashers.ToString()); 
                    }
                }
            }
        }
        
        // create method to allow user to randomly pick the appliance
        public static void RandomPick()
        {
            Console.WriteLine("Enter number of appliances:");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomIndex = random.Next(allApplicance.Count);
                Console.WriteLine(allApplicance[randomIndex].ToString());
            }
        }
        
        // create a method to read the data and make it as a list
        public static void ReadAndCreateAList()
        {
            string[] data = Resources.appliances.Split(Environment.NewLine);

            foreach (string line in data)
            {
                string[] details = line.Split(";");
                if (details.Length >= 9 && details[0][0].ToString() == "1")
                {
                    Refrigerators refrigerator = new Refrigerators();
                    refrigerator.ItemNumber = long.Parse(details[0]);
                    refrigerator.Brand = details[1];
                    refrigerator.Quantity = int.Parse(details[2]);
                    refrigerator.Wattage = int.Parse(details[3]);
                    refrigerator.Color = details[4];
                    refrigerator.Price = double.Parse(details[5]);
                    refrigerator.NumDoor = int.Parse(details[6]);
                    refrigerator.Height = int.Parse(details[7]);
                    refrigerator.Width = int.Parse(details[8]);
                    allApplicance.Add(refrigerator);
                }

                else if (details.Length >= 8 && details[0][0].ToString() == "2")
                {
                    Vacuums vaccum = new Vacuums();
                    vaccum.ItemNumber = long.Parse(details[0]);
                    vaccum.Brand = details[1];
                    vaccum.Quantity = int.Parse(details[2]);
                    vaccum.Wattage = int.Parse(details[3]);
                    vaccum.Color = details[4];
                    vaccum.Price = double.Parse(details[5]);
                    vaccum.Grade = details[6];
                    vaccum.BatteryVottage = int.Parse(details[7]);
                    allApplicance.Add(vaccum);
                }

                else if (details.Length >= 8 && details[0][0].ToString() == "3")
                {
                    Microwaves microwave = new Microwaves();
                    microwave.ItemNumber = long.Parse(details[0]);
                    microwave.Brand = details[1];
                    microwave.Quantity = int.Parse(details[2]);
                    microwave.Wattage = int.Parse(details[3]);
                    microwave.Color = details[4];
                    microwave.Price = double.Parse(details[5]);
                    microwave.Capacity = double.Parse(details[6]);
                    microwave.RoomType = char.Parse(details[7]);
                    allApplicance.Add(microwave);
                }

                else if (details.Length >= 8 && (details[0][0].ToString() == "4" || details[0][0].ToString() == "5"))
                {
                    Dishwashers dishwasher = new Dishwashers();
                    dishwasher.ItemNumber = long.Parse(details[0]);
                    dishwasher.Brand = details[1];
                    dishwasher.Quantity = int.Parse(details[2]);
                    dishwasher.Wattage = int.Parse(details[3]);
                    dishwasher.Color = details[4];
                    dishwasher.Price = double.Parse(details[5]);
                    dishwasher.FeatureAndFinish = details[6];
                    dishwasher.SoundRating = details[7];
                    allApplicance.Add(dishwasher);
                }
            }

        }
    }
}
