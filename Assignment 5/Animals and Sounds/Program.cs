namespace Animals_and_Sounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog aDog = new Dog("Scott");
            Console.WriteLine(aDog.ToString());

            Cat aCat = new Cat("April");
            Console.WriteLine(aCat.ToString());
        }
    }
}
