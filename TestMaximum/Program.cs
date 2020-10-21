using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to test maximum program");
            //Console.WriteLine("Enter 3 integers");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int intMax = new FindMaximum().FindIntMax(a, b, c);
            //Console.WriteLine("Maximum integer number: "+ intMax);
            //float floatMax = new FindMaximum().FindFloatMax(a, b, c);
            //Console.WriteLine("Maximum Float number: " + floatMax);
            //string stringMax = new FindMaximum().FindStringMax("a", "b", "c");
            //Console.WriteLine("Maximum string number: " + stringMax);
            int[] arrayOfIntegers = new int[] { 10, 12, 13 };
            int maxValue = new FindMaximum<int>().GenericMax(arrayOfIntegers);
            Console.WriteLine("Maximum integer number: " + maxValue);
            double[] arrayOfDouble = new double[] { 10.1, 12.3, 13.4 };
            double maxDoubleValue = new FindMaximum<double>().GenericMax(arrayOfDouble);
            Console.WriteLine("Maximum double number: " + maxDoubleValue);
            string[] arrayOfString = new string[] { "10", "12", "13" };
            string maxStringValue = new FindMaximum<string>().GenericMax(arrayOfString);
            Console.WriteLine("Maximum string number: " + maxStringValue);

        }
    }
}
