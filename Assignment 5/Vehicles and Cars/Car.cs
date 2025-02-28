using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    class Car : Vehicle
    {
        //additional property 
        private int numberofdoors = 0;

        //getters and setter
        public int Numberofdoors
        {
            get { return numberofdoors; }
            set { numberofdoors = value; }
        }

        //constructor
        public Car(string aMake, string aModel, int aYear, int aNumberofdoors)
            : base(aMake, aModel, aYear)
        {
            Numberofdoors = aNumberofdoors;
        }

        public override string ToString()
        {
            return $"Year: {Year} \n Make: {Make} \n Model: {Model} \n Number of doors: {Numberofdoors}"; ;
        }
    }
}
