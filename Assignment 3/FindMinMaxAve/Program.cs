// written by Grace
// 02/11/2025

namespace FindMinMaxAve
{
    public class Program
    {
        static void Main(string[] args)
        {
            //starting with a list find min, max and average 
            List<int> aList = new List<int> { 9, 8, 7, 6, 5 , 4, 3, 2, 1, 6 };

            // creating an object of the class 
            Calculator aCalculator = new Calculator();
            Calculator aCalculator1 = new Calculator();
            Calculator aCalculator2 = new Calculator();

            int minimum = aCalculator.FindMin(aList);
            int maximum = aCalculator.FindMax(aList);
            int average = aCalculator.FindAve(aList);

            Console.WriteLine("The minimum of our list is: " + minimum);
            Console.WriteLine("The maximum of our list is: " + maximum);
            Console.WriteLine("The average of our list is: " + average);

        }
    }
}
