using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Replicator_of_D_To
{
    public class Replicator
    {
        //class variables
        private int[] ogArray;
        private int[] repArray;

        // getters and setters 
        public int[] OgArray
        {
            get { return ogArray; }
            set { ogArray = value; }
        }
        public int[] RepArray
        {
            get { return repArray; }
            set { repArray = value; }
        }

        //constructors 
        public Replicator(int size)
        {
            ogArray = new int[size];
            repArray = new int[size];
        }

        public int[] Replicate()
        {
            for (int i = 0; i < ogArray.Length; i++)
            {
                repArray[i] = ogArray[i];
            }
            return repArray;
        }

        // Override ToString to display array contents
        public override string ToString()
        {
            return "Original Array: [" + string.Join(", ", ogArray) + "]\n" +
                   "Replicated Array: [" + string.Join(", ", Replicate()) + "]";
        }

    }
}
