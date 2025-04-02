using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Calculator
    {
        //function

        public List<int> TwoSum(int[] nums, int target)
        {
            // Creating a list to store the indices of the two numbers that sum up to the target
            List<int> answers = new List<int>();

            // Checking each number in the given array
            for (int i = 0; i < nums.Length; i++)
            {
                // Comparing the current number with every other number in the array
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // If the sum of the two numbers equals the target, store their indices
                    if (nums[i] + nums[j] == target)
                    {
                        answers.Add(i);
                        answers.Add(j);
                        return answers; // Return immediately after finding a valid pair
                    }
                }
            }

            // Return an empty list if no valid pair is found
            return answers;

        }
}
