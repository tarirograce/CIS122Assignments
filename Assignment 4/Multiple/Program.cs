namespace Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 2, 4, 6 };

            CalcMultiple calculator = new CalcMultiple(myNumbers);

            int[] result = calculator.Calc();

            Console.WriteLine("Result: " + string.Join(", ", result));
        }
    }
}
