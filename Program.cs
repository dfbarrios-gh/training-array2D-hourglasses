using System;
using System.Linq;
using System.Collections.Generic;

namespace HourGlasses
{
    class Program
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            if (arr != null && arr[0] != null)
            {
                int sum;
                int limit = 4;
                List<int> allSum = new List<int>();

                for (int i = 0; i < limit; i++)
                {
                    for (int j = 0; j < limit; j++)
                    {
                        sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                            + arr[i + 1][j + 1]
                            + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                        allSum.Add(sum);
                    }
                }
                return allSum.Max();
            }
            return 0;
        }

        class Solution
        {
            public static void Main(string[] args)
            {
                List<List<int>> arr = new List<List<int>>();
                arr.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
                arr.Add(new List<int> { 0, 1, 0, 0, 0, 0 });
                arr.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
                arr.Add(new List<int> { 0, 0, 2, 4, 4, 0 });
                arr.Add(new List<int> { 0, 0, 0, 2, 0, 0 });
                arr.Add(new List<int> { 0, 0, 1, 2, 4, 0 });
                int result = Program.hourglassSum(arr);
                Console.WriteLine("Result Hour Glass Sum: " + result);
                Console.ReadKey();
            }
        }
    }
}
