using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Game
{
    class Calc
    {
        public int CalPoints(string[] operations)
        {
            List<int> scores = new List<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                if (int.TryParse(operations[i], out int number))
                {
                    // If it's a number, add it to the scores
                    scores.Add(number);
                }
                else if (operations[i] == "C")
                {
                    // If it's "C", remove the last score
                    if (scores.Count > 0)
                    {
                        scores.RemoveAt(scores.Count - 1);
                    }
                }
                else if (operations[i] == "D")
                {
                    // If it's "D", double the last score
                    if (scores.Count > 0)
                    {
                        int previous = scores[scores.Count - 1];
                        scores.Add(previous * 2); // Add the doubled value to the scores list
                    }
                }
                else if (operations[i] == "+")
                {
                    // If it's "+", sum the last two scores
                    if (scores.Count >= 2)
                    {
                        int sum = scores[scores.Count - 1] + scores[scores.Count - 2];
                        scores.Add(sum); // Add the sum of the last two scores to the scores list
                    }
                }
            }

            // Calculate the total score
            int total = scores.Sum();
            return total;
        }
    }
}
