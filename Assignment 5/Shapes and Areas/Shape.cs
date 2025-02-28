using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    abstract class Shape
    {
        //class variables
        private string color = "n/a";

        //getters and setters
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //constructors 
        public Shape(string aColor)
        {
            Color = aColor;
        }

        public abstract double GetArea();

        public override string ToString()
        {
            return $"Color Shape";
        }

    }
}
