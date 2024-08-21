using System;

namespace Demo01B
{
    internal class Triangulo
    {

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }


        public double CalcularDistancia(int a1, int b1, int a2, int b2)
        {
            return Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
        }


        public double CalcularArea()
        {
            return 0.5 * Math.Abs(X1 * (Y2 - Y3) + X2 * (Y3 - Y1) + X3 * (Y1 - Y2));
        }


        public double CalcularPerimetro()
        {
            double lado1 = CalcularDistancia(X1, Y1, X2, Y2);
            double lado2 = CalcularDistancia(X2, Y2, X3, Y3);
            double lado3 = CalcularDistancia(X3, Y3, X1, Y1);
            return lado1 + lado2 + lado3;
        }
    }
}
