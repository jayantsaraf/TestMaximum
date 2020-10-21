using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class GenericMaximum<T> where T:IComparable
    {
        public T[] numberArray;
        public GenericMaximum(params T[] givenNumbers)
        {
            this.numberArray = givenNumbers;
        }
        public T[] SortArray(params T[] valueArray)
        {
            Array.Sort(valueArray);
            return valueArray;
        }
        public T FindMax(params T[] valueArray)
        {
            var sorted_Array = SortArray(valueArray);
            return sorted_Array[sorted_Array.Length - 1];
        }

        public void PrintMaxValue()
        {
            T maxValue = FindMax(this.numberArray);
            Console.WriteLine("Max Value = " + maxValue);
        }
    }
}
