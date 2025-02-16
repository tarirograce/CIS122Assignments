//written by Tariro Grace Shumba
//2/3/2025 
namespace WatchTower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompting the user to enter the x and y value and reading them into a variable
            Console.Write("Enter X value : ");
            int xValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y value : ");
            int yValue = Convert.ToInt32(Console.ReadLine());

            // creating an object of the class
            Watchtower aDirection = new Watchtower(xValue,yValue);

            // outputting the direction using tstring
            Console.WriteLine(aDirection.ToString());
        }
    }
}
