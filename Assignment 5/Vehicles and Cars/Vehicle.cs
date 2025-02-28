using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    class Vehicle
    {
        //class variables
        private string make = "n/a";
        private string model = "n/a";
        private int year = 0;

        //getters and setters 
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        // constructor that initializes these properties 
        public Vehicle(string aMake, string aModel, int aYear)
        {
            Make = aMake;
            Model = aModel;
            Year = aYear;
        }

        public override string ToString()
        {
            return $"Year: {Year} \n Make: {Make} \n Model: {Model}";
        }
    }
}
