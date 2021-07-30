using System;
using System.Globalization;

namespace ExercicioPoo_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo a, b;

            a = new Triangulo();
            b = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo A:");
            a.LADO1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.LADO2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.LADO3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo B:");
            b.LADO1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.LADO2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.LADO3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaA = a.Area();

            double areaB = b.Area();

            Console.WriteLine("Área do triângulo A = " + areaA.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triângulo B = " + areaB.ToString("F4", CultureInfo.InvariantCulture));
            if (areaA > areaB)
            {
                Console.WriteLine("Triângulo de maior área: A");
            }
            else
            {
                Console.WriteLine("Triângulo de maior área: B");
            }
        }
    }
}