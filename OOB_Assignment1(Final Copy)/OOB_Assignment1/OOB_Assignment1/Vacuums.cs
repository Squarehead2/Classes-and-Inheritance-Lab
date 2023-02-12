using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    class Vacuums : Appliance
    {
        
        private string grade;
        private int batteryVottage;

        
        public string Grade { get { return grade; } set { grade = value; } }
        public int BatteryVottage { get { return batteryVottage; } set { batteryVottage = value; } }

        public Vacuums() 
        {
            Grade = string.Empty;
            BatteryVottage = 0;

        }

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

        public string formatForFile()
        {
            string formattedString =

                batteryVottage.ToString() + ";" +
                grade + ";";
                

            return formattedString;
        }




    }
}
