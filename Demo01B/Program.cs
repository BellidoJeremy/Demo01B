using Demo01B;
using System;

namespace Demo01B
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo triangulo = new Triangulo
            {
                X1 = 1,
                Y1 = 1,
                X2 = 4,
                Y2 = 5,
                X3 = 7,
                Y3 = 2
            };


            double area = triangulo.CalcularArea();
            double perimetro = triangulo.CalcularPerimetro();


            Console.WriteLine($"Área del triángulo: {area}");
            Console.WriteLine($"Perímetro del triángulo: {perimetro}");
            Console.Read();
        }
    }
}
