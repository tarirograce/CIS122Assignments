namespace Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderChecker checker = new OrderChecker("abc");
            Console.WriteLine(checker.IsInOrder()); 

            OrderChecker anotherChecker = new OrderChecker("edabit");
            Console.WriteLine(anotherChecker.IsInOrder()); 
        }
    }
}
