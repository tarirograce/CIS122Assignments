using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class OrderChecker
    {
        private string input;

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public bool IsInOrder()
        {
            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            return new string(chars) == input;
        }


        public OrderChecker(string inputString)
        {
            input = inputString;
        }
    }
}
