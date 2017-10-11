using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day3_fall17
{
    class Automobile : Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }

        public Automobile (int numberOfWheels, float wheelSize, int numberOfDoors):base(4, 2000, "Blue", 65.0d)
        {
            
        }

    }
}
