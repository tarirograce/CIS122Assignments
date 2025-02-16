namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an object of the Replicator class
            Replicator aReplicator = new Replicator(5);
            Console.WriteLine("Enter 5 numbers to store in the Replicator:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                aReplicator.OgArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n" + aReplicator.ToString());
        }
    }
}
