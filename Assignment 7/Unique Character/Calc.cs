using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Character
{
    class Calc
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> countMap = new Dictionary<char, int>();

            // Step 1: Count occurrences of each char
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (countMap.ContainsKey(c))
                {
                    countMap[c]++;
                }
                else
                {
                    countMap[c] = 1;
                }
            }

            // Step 2: Find the first char with count == 1
            for (int i = 0; i < s.Length; i++)
            {
                if (countMap[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1; // no non-repeating character found
        }
    }
}
