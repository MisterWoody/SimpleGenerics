using System;
using System.Runtime.CompilerServices;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("MaxInteger");
            int a = 10;
            int b = 20;
            Console.WriteLine();
            Console.WriteLine($"Max integer of a: {a} and b: {b} is {Utility.MaxInteger(a, b)}");
            Console.WriteLine();
            Console.WriteLine($"Generic max integer is {Utility.Max<int>(a, b)}");

            Console.WriteLine("MaxFloat");
            float f = 10.2f;
            float g = 20.5f;
            Console.WriteLine();
            Console.WriteLine($"Max float of f: {f} and g: {g} is {Utility.MaxFloat(f, g)}");
            Console.WriteLine();
            Console.WriteLine($"Generic max float is {Utility.Max<float>(f, g)}");

            Console.WriteLine("MaxDouble");
            double p = 45.6;
            double q = 25.1;
            Console.WriteLine();
            Console.WriteLine($"Max double of p: {p} and q: {q} is {Utility.MaxDouble(p, q)}");
            Console.WriteLine();
            Console.WriteLine($"Generic max double is {Utility.Max<double>(p, q)}");
        }
    }

    public class Utility
    {
        // This method only works for integer parameterss
        public static int MaxInteger(int x, int y)
        {
            return x > y ? x : y;
        }

        // This method only works for doubles
        public static double MaxDouble(double x, double y)
        {
            return x > y ? x : y;
        }

        // This method only works for floating point numbers
        public static float MaxFloat(float x, float y)
        {
            return x > y ? x : y;
        }

        // This methow will work for any object that has the property 
        // that it can be compared to another object of the same type
        public static T Max<T>(T x, T y) where T : IComparable
        {
            return x.CompareTo(y) > 0 ? x : y;
        }
    }
}
