using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber_of_Ballons
{
    class Balloon
    {
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> counts = new Dictionary<char, int> 
            {
                {'b', 0}, {'a', 0}, {'l', 0}, {'o', 0}, {'n', 0}
            };

            foreach (char c in text)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
            }

            // Divide 'l' and 'o' counts by 2
            counts['l'] /= 2;
            counts['o'] /= 2;

            return counts.Values.Min();
        }
    }
}
