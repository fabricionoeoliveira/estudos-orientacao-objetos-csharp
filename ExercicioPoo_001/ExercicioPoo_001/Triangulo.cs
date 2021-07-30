using System;

namespace ExercicioPoo_001
{
    class Triangulo
    {
        public double LADO1;
        public double LADO2;
        public double LADO3;

        public double Area()
        {
            double p = (LADO1 + LADO2 + LADO3) / 2.0;
            double raiz = Math.Sqrt(p * (p - LADO1) * (p - LADO2) * (p - LADO3));
            return raiz;
        }
    }
}