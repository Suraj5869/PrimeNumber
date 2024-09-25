using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.Models
{
    internal class Prime
    {
        public static string CheckPrime(int number)
        {
            int exception = 1;
            int min = 0;
            //special case for prime number
            if (number == exception) return $"The entered number {number} is not a Prime Number.";

            //check if the given number is prime or not
            for (int i = 2; i <= Math.Sqrt(number) + 1; i++)
            {
                if (number % i == min)
                {
                    return $"The entered number {number} is not a Prime Number.";
                }
            }
            return $"The entered number {number} is a Prime Number.";
        }
    }
}
