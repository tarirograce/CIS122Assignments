// written by Tariro Grace Shumba
//2/1/2025
using System;
namespace The_Dominion_Of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompting the kings to enter their names and how homuch stuff they have

            Console.Write("Enter The Kings Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter The Kings Estates : ");
            int estates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Kings Duchies : ");
            int duchy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Kings Province : ");
            int province = Convert.ToInt32(Console.ReadLine());

            // creating a list to put all the information in

            List<DominionOfKings> aListOfKings = new List<DominionOfKings>();

            // creating instances of your class 

            DominionOfKings aKing1 = new DominionOfKings(name, estates, duchy, province);



            // populating the list
            aListOfKings.Add(aKing1);

            // printing each item in the list according to our ToString)

            foreach(DominionOfKings aKing in aListOfKings)
            {
                Console.WriteLine(aKing.ToString());
            }

        }
    }
}
