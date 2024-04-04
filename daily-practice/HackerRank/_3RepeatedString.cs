using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _3RepeatedString
    {
        public static int repeatedString()
        {
            long n = 10;
            string s = "aba";

            long numA = 0;
            long totalString = n / s.Length;
            long r = n % s.Length;
            char[] ch = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (ch[i] == 'a')
                {
                    numA++;
                }
            }
            numA *= totalString;

            for (int i = 0; i < r; i++)
            {
                if (ch[i] == 'a')
                {
                    numA++;
                }
            }
            return (int)numA;
        }
    }
}

