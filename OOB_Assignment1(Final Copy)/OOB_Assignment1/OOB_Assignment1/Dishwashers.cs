using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    // create class Dishwashers and make it inherited from class Appliance
    class Dishwashers : Appliance
    {
        //create attributes for class Dishwashers
        private string featureAndFinish;
        private string soundRating;

        //create public attributes to access private attributes
        public string FeatureAndFinish { get { return featureAndFinish; } set { featureAndFinish = value; } }
        public string SoundRating { get { return soundRating; } set { soundRating = value; } }

        //create method to change the data value
        public Dishwashers()
        {
            FeatureAndFinish = string.Empty;
            SoundRating = string.Empty;

        }

        public override string ToString()
        {
            string SoundRatingString = string.Empty;

            if (SoundRating == "Qt")
            {
                SoundRatingString = "Quietest";
            }
            else if (SoundRating == "Qr") 
            {
                SoundRatingString = "Quieter";
            }

            else if (SoundRating == "Qu") 
            {
                SoundRatingString = "Quiet";
            }

            else if (SoundRating == "M") 
            {
                SoundRatingString = "Moderate";
            }

            return base.ToString()+
                $"Feature: {FeatureAndFinish}\n" +
                $"Sound Rating:{SoundRatingString}\n";
        }
    }
}
