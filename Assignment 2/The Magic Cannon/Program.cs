//written by Tariro Grace Shumba
//2/3/2025
namespace The_Magic_Cannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++ )
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire and Electric");
                }
                else if (num % 3 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Fire");
                }
                else if (num % 5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Electric");
                }
                else
                {
                    Console.WriteLine("Normal");
                }
                Console.ResetColor();
            }
        }
    }
}
