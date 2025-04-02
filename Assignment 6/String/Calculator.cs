using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Calculator
    {
        // Function to find the first index of the needle in haystack
        public int StrStr(string haystack, string needle)
        {
            // Length of the needle and haystack
            int needleLength = needle.Length;
            int haystackLength = haystack.Length;

            // Loop through haystack while ensuring there's enough room for needle
            for (int i = 0; i <= haystackLength - needleLength; i++)
            {
                int j;
                // Compare characters of needle with corresponding part of haystack
                for (j = 0; j < needleLength; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break; // If mismatch, stop checking and move to the next starting index
                    }
                }

                // If all characters matched, return the starting index
                if (j == needleLength)
                {
                    return i;
                }
            }

            // If no match is found, return -1
            return -1;
        }
    }
}