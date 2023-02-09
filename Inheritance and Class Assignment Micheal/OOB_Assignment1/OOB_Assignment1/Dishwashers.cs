using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB_Assignment1
{
    class Dishwashers : Appliance
    {
        private string featureAndFinish;
        private string soundRating;

        public string FeatureAndFinish { get { return featureAndFinish; } set { featureAndFinish = value; } }
        public string SoundRating { get { return soundRating; } set { soundRating = value; } }

        public Dishwashers()
        {
            FeatureAndFinish = string.Empty;
            SoundRating = string.Empty;

        }

        public override string ToString()
        {
            return base.ToString()+
                $"Feature: {FeatureAndFinish}\n" +
                $"Sound Rating:{SoundRating}\n";
        }
    }
}
