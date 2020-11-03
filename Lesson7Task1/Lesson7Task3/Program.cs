using System;

namespace Lesson7Task3
{
    class Program
    {
        static int Recursion(int a)
        {
            int result = a + Recursion(a - 1);
            return result;
        }
        static void Main(string[] args)
        {
            int result=Recursion(4);
            Console.WriteLine(result);
        }
    }
}
