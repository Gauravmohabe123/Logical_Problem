using System;

namespace Fibonacci_series
{
    internal class Fibonacci_series
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            for(int i=0; i<=10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b=c;
            }

        }
       
    }
}
