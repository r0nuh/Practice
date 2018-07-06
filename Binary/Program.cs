using System;
using System.Collections.Generic;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write($"The binary equivalent of {n} is: ");
            foreach (var item in ToBinary(n))
            {
                Console.Write(item);
            }
            
            Console.Read();
        }

        static List<int> ToBinary(int n)
        {
            List<int> binary = new List<int>();
            int digit;

            //while (n > 0)
            //{
            //    digit = n % 2;
            //    binary.Insert(0, digit);
            //    n /= 2;
            //}

            while (n > 0)
            {
                digit = n % 2;
                binary.Add(digit);
                n /= 2;
            }

            binary.Reverse();
            return binary;
        }
    }
}
