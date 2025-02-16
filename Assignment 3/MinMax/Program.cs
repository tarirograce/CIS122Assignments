namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 9, 5, 2, 12 };
            Claculator aMinMax = new Claculator(number);

            var (min, max) = aMinMax.FindMinMax();
            Console.WriteLine($"Min: {min}, Max: {max}");

        }
    }
}
