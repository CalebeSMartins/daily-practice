using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1007
    {
        public static void Diferenca()
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diff = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {diff}");

        }
    }
}
