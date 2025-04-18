using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParenthesis
{
    class Calc
    {
        public bool IsValid(string s)
        {
            Stack<char> brackets = new Stack<char>();

            foreach (char bracket in s)
            {
                if (bracket == '(' || bracket == '{' || bracket == '[')
                {
                    brackets.Push(bracket);
                }
                else
                {
                    if (brackets.Count == 0) return false; // Nothing to match with

                    char top = brackets.Peek();

                    if ((bracket == ')' && top == '(') ||
                        (bracket == '}' && top == '{') ||
                        (bracket == ']' && top == '['))
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return brackets.Count == 0;
        }
    }
}
