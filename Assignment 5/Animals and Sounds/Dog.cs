using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    class Dog : Animal
    {
        public Dog(string aName)
            : base(aName)
        {
            //empty
        }


        public override string MakeSound()
        {
            return $"Bark";
        }


    }
}
