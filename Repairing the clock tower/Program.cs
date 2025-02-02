// written by Tariro Grace Shumba
//2/1/2025
namespace Repairing_the_clock_tower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //promptimg the user to enter the ticktock
            Console.Write("Enter the input: ");

            // reading the input into the variable
            int ticktock = Convert.ToInt32(Console.ReadLine());

            // creating an instance of the class 
            ClockTower aClock = new ClockTower(ticktock);

            //printing the output
            Console.WriteLine(aClock.ToString());


        }
    }
}
