using System;

namespace Prime_Num
{
    internal class Prime_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numbur it is a prime numbur or not");

            int b = int.Parse(Console.ReadLine());
            bool check = false;


            for (int i = 2; i <= b/2; i++) 


            {
                if (b % i == 0)
                {
                    check = true;
                    break;

                }
            }
            if (check == true)
            {
                Console.WriteLine(b+ " is not prime number ");
            }
            else
            {
                Console.WriteLine(b + " is  prime number ");
            }
        }
    }
}
