using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsolouteNum
{
    class Calculator
    {
        private int[] numbers;

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        public Calculator(int[] aNumbers)
        {
            numbers = aNumbers;
        }

        public int GetAbsSum()
        {
            int sum = 0;
            int pos = 0;
            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    pos = -(num);
                    sum += pos;
                }
                else
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
