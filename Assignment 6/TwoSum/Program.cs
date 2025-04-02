namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Sum");

            //create an object of the class
            Calculator aCalculator = new Calculator();
            //create an array
            int[] nums = [3, 2, 4];

            //create the target
            int target = 6;

            //create a list to store the result 
            List<int> result = aCalculator.TwoSum(nums, target);

            //print the result
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");

        }
    }
}
