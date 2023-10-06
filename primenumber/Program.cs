using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prime number between zero to one hundred");

            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);


                }

            }



        }
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {

                    return false;
                }
            }
            return true;
        }
    }
}