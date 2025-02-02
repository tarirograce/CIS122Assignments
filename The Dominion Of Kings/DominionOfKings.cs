// written by Tariro Grace Shumba
//2/1/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Dominion_Of_Kings
{
    public class DominionOfKings
    {
        // class variables 
        private string name = "n/a";
        private int estate = 0;
        private int province = 0;
        private int duchy = 0;


        //getters and setters 

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Estate
        {
            get { return this.estate; }
            set { this.estate = value; }
        }

        public int Duchy
        {
            get { return this.duchy; }
            set { this.duchy = value; }
        }


        public int Province
        {
            get { return this.province; }
            set { this.province = value; }
        }

        //methods 

        public int CalcTotal()
        {
            return (Estate * 1) + (Duchy * 3) + (Province * 6);
        }

        // constructors

        public DominionOfKings(string aName, int aEstate, int aDuchy, int aProvince)
        {
            this.name = aName;
            this.estate = aEstate;
            this.duchy = aDuchy;
            this.province = aProvince;
        }

        // overriding to string

        public override string ToString()
        {
            string msg = " ";
            msg += " King : " + this.Name + " Total points : " + CalcTotal();
            return msg;
        }

    }
      

}
