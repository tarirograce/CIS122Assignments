using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    class Motorcycle : Vehicle
    {
        //additional properties 
        private bool hassidecar = false;
        //getter and setter
        public bool Hassidecar
        {
            get { return hassidecar; }
            set { hassidecar = value;  }
        }

        public Motorcycle(string aMake, string aModel, int aYear, bool aHassidecar)
            : base(aMake, aModel, aYear)
        {
            Hassidecar = aHassidecar;
        }
        public override string ToString()
        {
            return $"Year: {Year} \n Make: {Make} \n Model: {Model} \n Has side car: {Hassidecar}"; ;
        }
    }
}
