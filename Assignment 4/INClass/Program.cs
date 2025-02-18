//Written by Tariro Grace Shumba
//1/27/2025

namespace Assignment_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // instatiating 
            Shark aShark1 = new Shark(); //calls the empty constructor
            Shark aShark2 = new Shark("Bull Shark", 5.76); //calls constructor that is accepting species and length
            Shark aShark3 = new Shark("Tiger Shark", 7.89, true, 13); // calls the constructor that calls all 4 fields

            // property assignment 
            aShark1.Species = "Whale Shark";
            aShark1.Length = 6.78;
            aShark1.IsDangerous = false;
            aShark1.Age = 12;

            List<Shark> aListOfSharks = new List<Shark>(); //creating a list to store the sharks


            // adding the sharks and their properties in the list
            aListOfSharks.Add(aShark1);
            aListOfSharks.Add(aShark2);
            aListOfSharks.Add(aShark3);

            // looping through the list to print out the sharks and their properties  
            foreach(Shark aShark in aListOfSharks)
            {
                Console.WriteLine(aShark.ToString());

            }

        }
    }
}
