using System;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr =
            {
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 1, 0, 0, 0, 0},
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 0, 2, 4, 4, 0},
                new int[] {0, 0, 0, 2, 0, 0},
                new int[] {0, 0, 1, 2, 4, 0}
            };

            Console.WriteLine(HourglassSum(arr));
            Console.Read();
        }

        static int HourglassSum(int[][] arr)
        {            
            int max = 0;
            int sum = 0;
            int startI = 0;
            int endI = 3;
            int startJ = 0;
            int endJ = 3;

            while (endI <= 6)
            {
                for (int i = startI; i < endI; i++)
                {
                    if (i == startI + 1)
                    {
                        sum += arr[i][endJ - 2];
                    }
                    else
                    {
                        for (int j = startJ; j < endJ; j++)
                        {
                            sum += arr[i][j];
                        }
                    }
                }
                if (endJ < 6)
                {
                    ++startJ;
                    ++endJ;
                }
                else
                {
                    startJ = 0;
                    endJ = 3;
                    ++startI;
                    ++endI;
                }
                
                max = Math.Max(max, sum);                
                sum = 0;
            }
            return max;
        }
    }
}
