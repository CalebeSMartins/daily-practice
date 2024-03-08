using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1011
    {
        public static void Esfera()
        {
            int r = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14159;

            double volume = CalcVolume(pi, r);
            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        public static double CalcVolume(double a, int b)
        {
            double volume = 4.0 * Math.Pow(b, 3) * a / 3.0;
            return volume;
        }
    }
}
