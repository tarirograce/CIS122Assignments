//written by Tariro Grace Shumba
// 2/1/2025

namespace The_Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // changing the window title 
            Console.Title = "Defense of Consolas";

            // prompting the user to enter the row and column
            Console.Write("Target Row? ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Target Column? ");
            int column = Convert.ToInt32(Console.ReadLine());

            // creating an instance of the class 
            DefenseOfConsolas aDefense = new DefenseOfConsolas(row,column);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            // printing the deployment 

            Console.WriteLine(aDefense.ToString());

            // sounds for when the results have been computed and displayed
            Console.Beep(540 , 1500);





        }
    }
}
