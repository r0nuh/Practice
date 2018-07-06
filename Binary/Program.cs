using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine();
            Console.WriteLine("The maximum number of 1's in the binary number: " + MaxNumberOfOnes(n));


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

        static int MaxNumberOfOnes(int n)
        {
            List<int> binaryOfN = ToBinary(n);
            List<int> numberOfOnes = new List<int>();
            int count = 0;
            int max;

            for (int i = 0; i < binaryOfN.Count; i++)
            {
                if (binaryOfN[i] == 1)
                {
                    ++count;
                }
                else if (binaryOfN[i] == 0 && count > 0)
                {
                    numberOfOnes.Add(count);
                    count = 0;
                }

                numberOfOnes.Add(count);
            }

            //max = numberOfOnes.Max();
            max = Max(numberOfOnes);
            return max;
        }

        static int Max(List<int> values)
        {
            int max = values[0];

            for (int i = 1; i < values.Count; i++)
            {
                if (max < values[i])
                {
                    max = values[i];
                }
            }
            return max;
        }
    }
}
