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
            Console.WriteLine("Biggest prime number as the sum of prime numbers till 100: " + BiggestPrime());
            Console.WriteLine($"Biggest prime under {number} as the sum of prime numbers: " + BiggestPrime2(number));

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
            Console.WriteLine();
            Console.WriteLine("Sum of the primes: " + sum);
        }

        static int BiggestPrime()
        {
            int biggestPrime = 2;
            int sum = 2;

            for (int i = 3; i < 100; i += 2)
            {
                if (IsPrime(i))
                {
                    sum += i;
                    if (IsPrime(sum))
                    {
                        biggestPrime = sum;
                    }
                }
            }

            return biggestPrime;
        }

        static int BiggestPrime2(int n)
        {
            int biggestPrime = 2;
            int sum = 2;
            int i = 3;

            while (2 * biggestPrime < n)
            {

                if (IsPrime(i))
                {
                    sum += i;
                    if (IsPrime(sum))
                    {
                        biggestPrime = sum;
                    }
                }

                i += 2;
            }

            return biggestPrime;
        }
    }
}
