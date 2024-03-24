using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1TwoSum
    {
        public static int[] TwoSum()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int value = 0;

            Dictionary<int, int> numMap = new Dictionary<int, int>();
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int complement = target - nums[i];
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[i], i };
                }
                numMap.Add(nums[i], i);
            }
            return null;
        }
    }
}
