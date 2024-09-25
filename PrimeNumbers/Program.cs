using PrimeNumbers.Models;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Prime.CheckPrime(number));
        }
    }
}
