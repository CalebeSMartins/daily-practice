using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1SalesByMatch
    {
        public static int sockMerchant()
        {
            int n = 7;
            List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            int pair = 0;
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < n; i++) 
            {
                if (!hash.Contains(ar[i]))
                {
                    hash.Add(ar[i]);
                } 
                else
                {
                    hash.Remove(ar[i]);
                    pair++;
                }
            }
            Console.WriteLine(pair);
            return pair;
        }
    }
}

