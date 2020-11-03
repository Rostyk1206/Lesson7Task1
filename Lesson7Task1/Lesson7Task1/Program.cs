using System;

namespace Lesson7Task1
{
    class Program
    {
        static int Calculate (byte a, sbyte k)
        {
            return a + k;
        }
        static long Calculate(int a, uint k)
        {
            return a + k;
        }
        static int Calculate(short a, ushort k)
        {
            return a + k;
        }
        static long Calculate(long a, ulong k)
        {
            return a + (long)k;
        }
        static void Main(string[] args)
        {
            short m = 1;
            ushort z = 2;
            byte k = 9;
            sbyte j = 0;
            int f = 3;
            uint l = 10;
            long q = -20;
            ulong s = 34;
            Console.WriteLine(Calculate(m,z));
            Console.WriteLine(Calculate(k, j));
            Console.WriteLine(Calculate(f, l));
            Console.WriteLine(Calculate(q, s));
        }
    }
}
