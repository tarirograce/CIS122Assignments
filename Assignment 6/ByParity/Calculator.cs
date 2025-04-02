using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByParity
{
    class Calculator
    {
        public int[] sortArray(int[] nums)
        {
            int temp = 0;
            for (int i = 0; i < nums.Length ; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
