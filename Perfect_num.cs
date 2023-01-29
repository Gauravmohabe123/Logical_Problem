using System;

namespace Perfect_Numbur
{
    internal class Perfect_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numur is a perfect numbur or not:");
            int  p= int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= p / 2; i++)
            {
                if (p % i == 0)
                {
                    sum = i + sum;


                }

            }

            if (sum == p)
            {
                Console.WriteLine(p + " Is a perfact numbur");
            }
            else
            {
                Console.WriteLine(p + " Is not a perfact numbur");
            }
        }
    }
}
