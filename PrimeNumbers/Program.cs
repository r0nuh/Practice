using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number bigger than 1: ");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Is it a prime number? " + IsPrime(number));
            Console.WriteLine($"Sum of primes till {number}: " + SumOfPrimes(number));
            Console.Write($"Prime numbers till {number}: ");
            PrintPrimes(number);

            Console.Read();
        }

        static bool IsPrime(int number)
        {
            if (number > 2 && number % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int SumOfPrimes(int n)
        {
            int sum = 2;

            for (int i = 3; i < n; i += 2)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        static void PrintPrimes(int n)
        {
            Console.Write(2 + " ");
            int sum = 2;

            for (int i = 3; i < n; i += 2)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }

            Console.WriteLine("Sum of the primes: " + sum);
        }
    }
}
