using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNumber
{
    class Calc
    {
        public static string CalcSmallerNum(string word1, string word2)
        {
            if (word1.Length < word2.Length)
            {
                return word1;
            }
            if (word2.Length < word1.Length)
            {
                return word2;
            }
            else
            {
                return word1;
            }
        }
    }
}
