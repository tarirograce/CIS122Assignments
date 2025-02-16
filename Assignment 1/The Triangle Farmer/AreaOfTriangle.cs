using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Triangle_Farmer
{
    public class AreaOfTriangle
    {
        // class variables 
        private double trianglebase = 0.0;
        private double triangleheight = 0.0;

        // getter and setters 
        public double Trianglebase
        {
            get { return this.trianglebase; }
            set { this.trianglebase = value; }
        }
        public double Triangleheight
        {
            get { return this.triangleheight; }
            set { this.triangleheight = value; }
        }

        public double CalcArea()
        {
            double area = (this.trianglebase * this.triangleheight) / 2.0;

            return area;
        }
        // constructors 

        public AreaOfTriangle(double aTriangleheight, double aTrianglebase)
        {
            this.Trianglebase = aTrianglebase;
            this.Triangleheight = aTriangleheight;
        }
        public override string ToString()
        {
            string msg = " ";
            msg += "Triangle Area : " + CalcArea();

            return msg;
        }


    }
}
