using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot_Index
{
    class Pivot
    {
        public int PivotIndex(int[] nums)
        {
            int sumRight = nums.Sum();
            int sumLeft = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sumRight -= nums[i];

                if (sumLeft == sumRight)
                {
                    return i;
                }

                sumLeft += nums[i];
            }
            return -1;
        }
    }
}
