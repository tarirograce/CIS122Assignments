using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    class Animal
    {
        //class variables 
        private string name = "n/a";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal(string aName)
        {
            Name = aName;
        }

        public virtual string MakeSound()
        {
            return "Some generic animsl sound";
        }

        public override string ToString()
        {
            return $"Animal: {Name}, Sound: {MakeSound()}";
        }
    }
}
