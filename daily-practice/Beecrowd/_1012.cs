using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace daily_practice.Beecrowd
{
    public class _1012
    {
        public static void Areas()
        {
            string[] value = Console.ReadLine().Split(" ");
            double A = Convert.ToDouble(value[0]);
            double B = Convert.ToDouble(value[1]);
            double C = Convert.ToDouble(value[2]);

            double triangulo = (A * C) / 2;
            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");

            double circulo = 3.14159 * (Math.Pow(C, 2));
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");

            double trapezio = (A + B) * C / 2;
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");

            double quadrado = Math.Pow(B, 2);
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");

            double retangulo = A * B;
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
       
    }
}
