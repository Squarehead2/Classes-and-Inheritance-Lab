using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    //create class Vaccums and make it inherited from class Appliance
    class Vacuums : Appliance
    {
        //create attributes for class Vaccums
        private string grade;
        private int batteryVottage;

        //create public attributes to access private attributes
        public string Grade { get { return grade; } set { grade = value; } }
        public int BatteryVottage { get { return batteryVottage; } set { batteryVottage = value; } }
    
        //Construct
        public Vacuums() 
        {
            Grade = string.Empty;
            BatteryVottage = 0;

        }

        //create method to change the attributes type from int to String
        public override string ToString()
        {
            string BatteryVottageString = string.Empty;

            if (BatteryVottage == 18) 
            {
                BatteryVottageString = "Low";
            }

            else  BatteryVottageString = "High";

            return base.ToString() +
                $"Grade: {Grade}\n" +
                $"Battery Voltage: {BatteryVottageString}\n";
        }
    }
}
