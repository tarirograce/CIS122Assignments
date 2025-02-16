//written by Tariro Grace Shumba
//2/3/2025
namespace Buying_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompting the user
            Console.Write("The Following items are available :" + "\n" +
                "1 - Rope" + "\n" +
                "2 - Torches " + "\n" +
                "3 - Climbing equipment" + "\n" +
                "4 - Clean Water" + "\n" +
                "5 - Machete" + "\n" +
                "6 - Canoe" + "\n" +
                "7 - Food Supplies" + "\n" +
                "What number do you want to see the price of ? : ");
            // reading their input into a variable
            int inventoryNum = Convert.ToInt32(Console.ReadLine());

            //using the switch case to print out what tthey want
            switch (inventoryNum)
            {
                case 1:
                    Console.WriteLine("Rope costs 10 gold ");
                    break;
                case 2:
                    Console.WriteLine("Torches costs 15 gold ");
                    break;
                case 3:
                    Console.WriteLine("Climbing equipment costs 25 gold ");
                    break;
                case 4:
                    Console.WriteLine("Clean water costs 1 gold ");
                    break;
                case 5:
                    Console.WriteLine("Machete costs 20 gold ");
                    break;
                case 6:
                    Console.WriteLine("Canoe costs 200 gold ");
                    break;
                case 7:
                    Console.WriteLine("Food Supplies costs 1 gold ");
                    break;


            }


        }
    }
}
