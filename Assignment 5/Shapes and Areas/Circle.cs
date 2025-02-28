using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    class Circle : Shape
    {
        // additional properties
        private double radius = 0;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //constructors
        public Circle(string aColor, double aRadius)
            : base(aColor)
        {
            Radius = aRadius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return $"Color: {Color} \nRadius: {Radius}  \nArea: {GetArea()} ";
        }

    }
}
