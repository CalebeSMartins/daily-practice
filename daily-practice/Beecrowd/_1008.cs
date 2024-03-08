using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1008
    {
        public static void Salario()
        {
            int employee = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double totalSalary = salary * hours;

            Console.WriteLine($"NUMBER = {employee}");
            Console.WriteLine($"SALARY = U$ {totalSalary.ToString("F2")}");
        }
    }
}
