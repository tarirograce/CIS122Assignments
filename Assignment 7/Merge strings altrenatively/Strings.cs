using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_strings_altrenatively
{
    class Strings
    {
        public string MergeAlternately(string word1, string word2)
        {
            int i = 0, j = 0;
            int len1 = word1.Length, len2 = word2.Length;
            List<char> result = new List<char>();

            while (i < len1 || j < len2)
            {
                if (i < len1)
                {
                    result.Add(word1[i]);
                    i++;
                }
                if (j < len2)
                {
                    result.Add(word2[j]);
                    j++;
                }
            }

            return new string(result.ToArray());
        }
    }

}
