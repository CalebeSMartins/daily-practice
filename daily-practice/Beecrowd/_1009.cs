using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace daily_practice.Beecrowd
{
    public class _1009
    {
        public static void Salario_com_Bonus()
        {
            var name = Console.ReadLine();
            decimal fixedSalary = Convert.ToDecimal(Console.ReadLine());
            decimal sales = Convert.ToDecimal(Console.ReadLine());

            decimal totalSalary = fixedSalary + (sales * (15 / 100));
            Console.WriteLine($"TOTAL = R$ {totalSalary.ToString("F2")}");
        }
    }
}
