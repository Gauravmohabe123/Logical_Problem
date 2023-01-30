using System;
using System.Transactions;

namespace Reverse_num
{
    internal class Reverse_num
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter the to reverse numbur");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (num>0)
            {
                int remainder= num % 10;
                reverse = (reverse * 10) + remainder;

                num = num / 10;
            }
            Console.WriteLine("Reverse numbur is: " +reverse);

            
        }
    }
}
