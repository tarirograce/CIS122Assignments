namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            Calculator aCalculator = new Calculator();

            int results = aCalculator.RemoveElement(nums, val);
            Console.WriteLine($"k = {results}, nums = [{string.Join(", ", nums.Take(results))}]");
        }
    }
}
