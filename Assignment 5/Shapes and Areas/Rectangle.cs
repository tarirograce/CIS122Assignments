using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    class Rectangle : Shape
    {
        // additional properties 
        private int width = 0;
        private int height = 0;

        //getters and setters 
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        // constructors 
        public Rectangle(string aColor, int aHeight, int aWidth)
            : base(aColor)
        {
            Width = aWidth;
            Height = aHeight;
        }
    

        // abstract method 

        public override double GetArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Color : {Color} \n Height: {Height} \n Width: {Width} \n Area: {GetArea()} ";
        }
    }
}
