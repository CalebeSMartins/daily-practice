using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1_TwoSum
    {
        public static void TwoSum()
        {
            string[] entrada = Console.ReadLine().Split(",");
            int[] sums = Array.ConvertAll(entrada, Convert.ToInt32);
            int target = Convert.ToInt32(Console.ReadLine());
            int calc = 0;

            for (int i = 0; calc != target; i++)
            {
                for (int y = 1; calc != target; y++)
                {
                    calc = sums[i] + sums[y];

                    if (calc == target)
                    {
                        Console.WriteLine($"Because {sums[i]} + {sums[y]} = {target}, we return [{i}, {y}]");
                    }
                }
            }
        }
    }
}
