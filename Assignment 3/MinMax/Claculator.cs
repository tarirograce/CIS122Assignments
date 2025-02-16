using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Claculator
    {
        //class attributes
        private int[] numbers;

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        public (int min, int max) FindMinMax()
        {
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return (min, max) ;
        }
        public Claculator(int[] aNumber)
        {
            numbers = aNumber;
        }
    }
}
