using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1013
    {
        public static void O_Maior()
        {
            string[] value = Console.ReadLine().Split(" ");
            int A = Convert.ToInt32(value[0]);
            int B = Convert.ToInt32(value[1]);
            int C = Convert.ToInt32(value[2]);

            int maior = Maior(A, B, C);
            Console.WriteLine($"{maior} eh o maior");
        }
        public static int Maior(int a, int b, int c) 
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c ) 
            {
                m = b;
            }
            else
            {
                m = c;
            } 
            return m;
        }
    }
}
