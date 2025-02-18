using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterShift
{
    class LetterMover
    {
        private string input;

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public string Move()
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (char)(input[i] + 1);
            }

            return new string(result);
        }



        public LetterMover(string aString)
        {
            input = aString;
        }
    }
}
