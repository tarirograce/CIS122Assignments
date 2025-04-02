namespace ByParity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bubble");

            int[] nums = { 3, 1, 2, 4 };

            Calculator array = new Calculator();

            int[] results = array.sortArray(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(results[i]);
            }


        }
    }
}
