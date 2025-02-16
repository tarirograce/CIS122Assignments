namespace The_Four_Sisters_and_the_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many eggs where collected today? :"); // prompting the user

            //putting the users input into a variable and converted the input to integer from string
            int numberofEggs = Convert.ToInt32(Console.ReadLine()); // putting the users input into a variable
         

            // creating an instance of egg calculation
            EggCalculation eggCalculation1 = new EggCalculation(numberofEggs);

            //printong the results using tostring
            Console.WriteLine(eggCalculation1.ToString());



        }
    }
}
