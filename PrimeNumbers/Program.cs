using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number bigger than 1: ");
                int number = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Is it a prime number? " + IsPrime(number));
                Console.WriteLine($"Sum of primes till {number}: " + SumOfPrimes(number));
                Console.Write($"Prime numbers till {number}: ");
                PrintPrimes(number);
                Console.WriteLine("Biggest prime number as the sum of prime numbers till 100: " + BiggestPrime());
                Console.WriteLine($"Biggest prime under {number} as the sum of prime numbers: " + BiggestPrime2(number));

            }
            catch (ArgumentException)
            {

                Console.WriteLine("The entered number is not bigger than 1!");
            }


            Console.Read();
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                throw new ArgumentException();
            }

            if (number > 2 && number % 2 == 0)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }

            for (int i = 3; i < number; i += 2)  //i*i < number is faster
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static string SumOfPrimes(int n)
        {
            int sum = n < 3 ? 0 : 2;
            //int sum = 2;

            for (int i = 3; i < n; i += 2)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            string result = sum == 0 ? "there are no primes under 2" : sum.ToString();
            return result;
            //return sum;
        }

        static void PrintPrimes(int n)
        {
            if (n == 2)
            {
                Console.WriteLine("there are no primes under 2");
            }
            else
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
