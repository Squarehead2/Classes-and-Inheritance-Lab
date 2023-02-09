using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using OOB_Assignment1.Properties;

namespace OOB_Assignment1
{
    class ProblemDomain
    {

        public static List<Appliance> allApplicance = new List<Appliance>();
        public static void Main()
        {
            ReadAndCreateAList();

            Console.WriteLine("Welcome to Modern Appliances!\nHow May We Assist You \n1 – Check out appliance \n2 – Find appliances by brand \n3 – Display appliances by type\n4 – Produce random appliance list\n5 – Save & exit\n");

            Console.Write("Enter option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 3) 
            {
                SelectApplianceType();
            }

            if (option == 4) 
            {
                RandomPick();
            }

            
        }

        public static void SelectApplianceType()
        {
            Console.WriteLine("Appliance Types\r\n1 – Refrigerators\r\n2 – Vacuums\r\n3 – Microwaves\r\n4 – Dishwashers\r\n");
            Console.Write("Enter type of appliance: ");
            int option_type = Convert.ToInt32(Console.ReadLine());

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


        public static void SelectRefrigeratorWithDoors() 
        {   
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");
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


        public static void SelectVacuumsWithVoltage() 
        {
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high)");
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

        public static void SelectMircrowaveWithRoomType()
        {
            Console.WriteLine("RoomWhere the microwave will be installed: K (kitchen) or W (work site):");
            char preferRoomType = Convert.ToChar(Console.ReadLine());
            foreach (Appliance obj in allApplicance)
            {
                if (obj is Microwaves)
                {
                    Microwaves microwaves = (Microwaves)obj;

                    if (preferRoomType== microwaves.RoomType) 
                    {
                        Console.WriteLine(microwaves.ToString());
                    
                    }
                }
            }
        }

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

        public static void RandomPick()
        {
            Console.WriteLine("Enter number of appliances: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomIndex = random.Next(allApplicance.Count);
                Console.WriteLine(allApplicance[randomIndex].ToString());
            }
        }






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
