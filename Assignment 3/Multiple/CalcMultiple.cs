using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple
{
    class CalcMultiple
    {
        private int[] numbers;

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        
        public CalcMultiple(int[] aNumber)
        {
            Numbers = aNumber;
        }

        public int[] Calc()
        {
            int length = Numbers.Length;
            if (length == 0)
            {
                return new int[0];
            }
            int[] result = new int[length];
            for(int i = 0; i < length; i++)
            {
                result[i] = Numbers[i] * length;
            }
            return result;
        }
    }
}
