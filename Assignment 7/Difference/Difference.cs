using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{
    class Difference
    {
        public class Solution
        {
            public char FindTheDifference(string s, string t)
            {
                char result = '\0'; // Initialize result as null character

                // XOR all characters of s
                foreach (char c in s)
                {
                    result ^= c;
                }

                // XOR all characters of t
                foreach (char c in t)
                {
                    result ^= c;
                }

                // The remaining character is the extra one
                return result;
            }
        }
    }
}
