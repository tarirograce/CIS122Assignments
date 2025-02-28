using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    class Cat : Animal
    {
        public Cat(string aName)
           : base(aName)
        {
            //empty
        }


        public override string MakeSound()
        {
            return $"Meow";
        }
    }
}
