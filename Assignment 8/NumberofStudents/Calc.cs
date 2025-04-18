using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberofStudents
{
    class Calc
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            var queue = new Queue<int>(students);
            var counter = 0;
            var index = 0;

            while (index < sandwiches.Length)
            {
                if (sandwiches[index] == queue.Peek())
                {
                    queue.Dequeue();
                    index++;
                    counter = 0;
                    continue;
                }

                if (sandwiches[index] != queue.Peek())
                {
                    var student = queue.Dequeue();
                    queue.Enqueue(student);
                    counter++;
                }

                if (counter == queue.Count)
                {
                    return queue.Count;
                }
            }

            return queue.Count;
        }
    }
}
