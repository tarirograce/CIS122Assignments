using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Segment
{
    class Calc
    {
        public int CountSegments(string s)
        {
            int count = 0;
            bool inWord = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    if (!inWord)
                    {
                        count++;       // we just entered a word
                        inWord = true; // flag that we in a word now
                    }
                }
                else
                {
                    inWord = false; // we hit a space, so we're out of the word
                }
            }

            return count;
        }
    }
}
