using System;
using System.Diagnostics;


namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch=new Stopwatch();    
            stopwatch.Start();
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Tike");
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

        }
    }
}
