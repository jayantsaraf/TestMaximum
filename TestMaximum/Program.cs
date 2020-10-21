using System;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to test maximum program");
            Console.WriteLine("Enter 3 integers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int intMax = new FindMaximum().FindIntMax(a, b, c);
            Console.WriteLine("Maximum integer number: "+ intMax);
        }
    }
}
