using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestMaximum
{
    public class FindMaximum
    {
        public int FindIntMax(int firstValue, int secondValue,int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                return thirdValue;
            throw new Exception("All numbers are same");
        }
        
    }
}
