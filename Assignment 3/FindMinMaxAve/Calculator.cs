// written by Grace
// 02/11/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinMaxAve
{
    internal class Calculator
    {
        // creating 3 methods
        public int FindMin(List<int> aList)
        {

            // start by assuming the first item in the list list is the lowest one
            int min = aList[0];

            // we do not know how long the least
            // we loop through the list and compare each value to min, if the number is less than the min that becomes the min
            foreach (int i in aList)
            {
                if( i < min)
                {
                    min = i;
                }
            }

            return min;
        }

        public int FindMax(List<int> aList)
        {

            // start by assuming the first item in the list list is the lowest one
            int max = aList[0];

            // we do not know how long the least
            // we loop through the list and compare each value to min, if the number is less than the min that becomes the min
            foreach (int i in aList)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }
        public int FindAve(List<int> aList)
        {

            // start by assuming the first item in the list list is the lowest one

            int total = 0;
            int ave = 0;
            // we do not know how long the least
            // we loop through the list and compare each value to min, if the number is less than the min that becomes the min
            foreach (int i in aList)
            {
                total += i;
            }
            ave = total / aList.Count;
            

            return ave;
        }


    }
}
