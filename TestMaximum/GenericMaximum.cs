using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class GenericMaximum<T> where T:IComparable
    {
        public T[] numberArray;
        public GenericMaximum(T[] givenNumbers)
        {
            this.numberArray = givenNumbers;
        }
        public T FindMax()
        {
            Array.Sort(this.numberArray);
            return this.numberArray[this.numberArray.Length - 1];
        }

        public void PrintMaxValue()
        {
            T maxValue = FindMax();
            Console.WriteLine("Max Value = " + maxValue);
        }
    }
}
