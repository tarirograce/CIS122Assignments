using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Four_Sisters_and_the_Duckbear
{
    public class EggCalculation
    {
        //class variables
        private int numberofEggs = 0;

        //getters and setters

        public int NumberofEggs
        {
            get { return this.numberofEggs; }
            set
            {
                if(value >= 0)
                {
                    this.numberofEggs = value;
                }
                else
                {
                    this.numberofEggs = 0;
                }
            }
        }
        // methods

        public int CalcEggsForSisters()
        {
            int eggsforSisters = this.NumberofEggs / 2;
            return eggsforSisters;
            
        }
        public int Calceggsforduckbear()
        {
            int eggsforDuckbear = this.NumberofEggs % 2;
            return eggsforDuckbear;
        }

        // contstructors
        public EggCalculation(int aEgg)
        {
            this.NumberofEggs = aEgg;
        }

        public override string ToString()
        {
            string msg = " ";

            msg += "Eggs for each sister : " + CalcEggsForSisters();
            msg += "Eggs for duckbear : " + Calceggsforduckbear();
            return msg;
        }
    }
}
