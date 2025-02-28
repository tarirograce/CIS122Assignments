namespace Shapes_and_Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiating Rectangle class
            Rectangle aRectangle = new Rectangle("White", 10, 5);
            Circle aCircle = new Circle("Red", 2);
            //calling the area
            Console.WriteLine(aRectangle.GetArea());
            Console.WriteLine(aRectangle.ToString());

            Console.WriteLine(aCircle.GetArea());
            Console.WriteLine(aCircle.ToString());
        }
    }
}
