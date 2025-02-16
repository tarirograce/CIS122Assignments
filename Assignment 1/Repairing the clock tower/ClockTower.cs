// written by Tariro Grace Shumba
//2/1/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repairing_the_clock_tower
{
    public class ClockTower
    {
        // class variable
        private int ticktock = 0;

        //getters and setters 
        public int Ticktock
        {
            get { return this.ticktock; }
            set { this.ticktock = value; }
        }
        //methods
        public string CalctickTock()
        {
            if (this.Ticktock % 2 == 0)
            {

                return $"Tick";
            }
            else
            {
                 return $"Tock";
            }
        }
        // constructor
        public ClockTower(int aTicktock)
        {
            this.Ticktock = aTicktock;
        }
        // overriding tostring

        public override string ToString()
        {
            string msg = " ";
            msg += $" {CalctickTock()} ";
            return msg;
        }

    }

}
