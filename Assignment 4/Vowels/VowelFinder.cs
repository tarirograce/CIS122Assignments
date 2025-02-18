using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    class VowelFinder
    {
        private string text;
        private int n;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public string FirstNVowels()
        {
            string vowels = "aeiou";
            string result = "";
            int count = 0;

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                {
                    result += c;
                    count++;
                    if (count == n)
                    {
                        return result;
                    }
                }
            }

            return "invalid";
        }
        public VowelFinder(string inputText, int vowelCount)
        {
            text = inputText;
            n = vowelCount;
        }
    }
}
