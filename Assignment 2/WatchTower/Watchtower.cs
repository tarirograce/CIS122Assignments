//written by Tariro Grace Shumba
//2/3/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower
{
    public class Watchtower
    {
        // declaring the class variables
        private int xvalue = 0;
        private int yvalue = 0;

        //getters amd setters
        public int Xvalue
        {
            get { return this.xvalue; }
            set { this.xvalue = value; }
        }
        public int Yvalue
        {
            get { return this.yvalue; }
            set { this.yvalue = value; }
        }
        // methods
        public string CalcCoordinates()
        {

            if (this.Yvalue > 0 && this.Xvalue < 0)
            {
                return "NW";
            }

            if (this.Yvalue > 0 && this.Xvalue == 0)
            {
                return "N";
            }
            if (this.Yvalue > 0 && this.Xvalue > 0)
            {
                return "North East";
            }

            if (this.Yvalue == 0 && this.Xvalue == 0)
            {
                return "Here";
            }
            if (this.Yvalue == 0 && this.Xvalue > 0)
            {
                return "East";
            }
            if (this.Yvalue == 0 && this.Xvalue < 0)
            {
                return "West";
            }
            if (this.Yvalue < 0 && this.Xvalue == 0)
            {
                return "South";
            }
            if (this.Yvalue < 0 && this.Xvalue > 0)
            {
                return "South Eeast";
            }
            if (this.Yvalue < 0 && this.Xvalue < 0)
            {
                return "South West";
            }

            return "unknown";
        }
        // constructor

        public Watchtower(int aX, int aY)
        {
            this.Xvalue = aX;
            this.Yvalue = aY;
        }

        public override string ToString()
        {
            string msg = " ";

            msg += $" The enemy is {CalcCoordinates()}";

            return msg;
        }

    }
}
