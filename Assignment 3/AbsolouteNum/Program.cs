namespace AbsolouteNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, -2, 8, -3 };
            Calculator aAbsSum = new Calculator(numbers);

            int total = aAbsSum.GetAbsSum();

            Console.WriteLine($"The absolute total is : {total}");
        }
    }
}
