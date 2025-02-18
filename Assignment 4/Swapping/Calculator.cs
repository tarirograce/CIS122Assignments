using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Calculator
    {
        private string str;

        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        public string FlipEndChars()
        {
            if (str.Length < 2)
            {
                return "Incompatible.";
            }

            if (str[0] == str[^1])
            {
                return "Two's a pair.";
            }

            char first = str[0];
            char last = str[^1];

            return last + str.Substring(1, str.Length - 2) + first;
        }

        public Calculator(string aString)
        {
            str = aString;
        }
    }
}
