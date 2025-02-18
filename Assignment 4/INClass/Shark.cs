// written by Tariro Grace Shumba
//1/27/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Shark
    {
        // class variables
        private string species = "n/a";
        private double length = -1.00;
        private bool isDangerous = true;
        private int age = -1;

        // getters and setters 
        public string Species
        {
            get { return this.species; }
            set { this.species = value; }

        }

        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public bool IsDangerous
        {
            get { return this.isDangerous; }
            set { this.isDangerous = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        // constructors
        public Shark() : this("n/a", -1.00, true, -1) { } //empty constructors with chaining to reduce duplication

        public Shark(string aSpecies, double aLength) : this(aSpecies, aLength, true, -1) { } // constructor accepting species and length

        public Shark(string aSpecies, double aLength, bool aIsDangerous, int aAge) 
        {
            Species = aSpecies;
            Length = aLength;
            IsDangerous = aIsDangerous;
            Age = aAge;

        
        }
        
        // override toString
        public override string ToString()
        {
            string message = "";
            message = message + " Species = " + this.species + " length :" + this.length + " Is Dangerous :" + this.isDangerous + " Age :" + this.age;



            return message;
        }






    }


}
