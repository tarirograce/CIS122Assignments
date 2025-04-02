using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Calculator
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0; // Count of elements not equal to val

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i]; // Move non-val elements to the front
                    k++;
                }
            }

            return k; // Return the count of elements not equal to val
        }
    }
}
