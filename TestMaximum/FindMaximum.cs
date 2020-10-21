using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TestMaximum
{
    public class FindMaximum<T> where T:IComparable
    {
        //public int FindIntMax(int firstValue, int secondValue,int thirdValue)
        //{
        //    if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
        //        return firstValue;
        //    else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
        //        return secondValue;
        //    else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
        //        return thirdValue;
        //    throw new Exception("All numbers are same");
        //}
        //public float FindFloatMax(float firstValue, float secondValue, float thirdValue)
        //{
        //    if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
        //        return firstValue;
        //    else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
        //        return secondValue;
        //    else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
        //        return thirdValue;
        //    throw new Exception("All numbers are same");
        //}
        //public string FindStringMax(string firstString, string secondString, string thirdString)
        //{
        //    if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
        //        firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
        //        firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
        //    {
        //        return firstString;
        //    }

        //    if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
        //        secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
        //        secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
        //    {
        //        return secondString;
        //    }

        //    if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
        //        thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
        //        thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
        //    {
        //        return thirdString;
        //    }

        //    throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        //}
        public T GenericMax(T[] numberArray)
        {
            Array.Sort(numberArray);
            return numberArray[numberArray.Length - 1];
        }

    }
}
