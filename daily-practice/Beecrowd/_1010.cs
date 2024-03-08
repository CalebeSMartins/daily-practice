using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1010
    {
        public static void CalculoSimples()
        {
            string[] entrada1 = Console.ReadLine().Split(" ");
            int code1 = Convert.ToInt32(entrada1[0]);
            int quantity1 = Convert.ToInt32(entrada1[1]);
            double value1 = Convert.ToDouble(entrada1[2]);

            string[] entrada2 = Console.ReadLine().Split(" ");
            int code2 = Convert.ToInt32(entrada2[0]);
            int quantity2 = Convert.ToInt32(entrada2[1]);
            double value2 = Convert.ToDouble(entrada2[2]);

            double totalValue = Calc(quantity1, value1, quantity2, value2);
            Console.WriteLine($"VALOR A PAGAR: R$ {totalValue.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static double Calc(int a, double b, int c, double d) 
        {
            double value = a * b + c * d;
            return value;
        }
    }
}
