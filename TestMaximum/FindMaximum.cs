using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestMaximum
{
    public class FindMaximum
    {
        public int FindIntMax(int a, int b,int c)
        {
            int[] max = new int[3];
            max[0] = a;
            max[1] = b;
            max[2] = c;
            Array.Sort(max);
            return max[max.Length - 1];
        }
    }
}
