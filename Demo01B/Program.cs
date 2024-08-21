using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona();
            persona.Nombres = "Jeremy Emanuel";
            persona.Apellidos = "Bellido Ñañez";

            Persona persona1 = new Persona
            {
                Nombres = "David",
                Apellidos = "Rey",
                Edad = 16
        };

            Triangulo triangulo = new Triangulo();
            triangulo.Base = 5;
            triangulo.Altura = 8;

            triangulo.CalcularArea();

            Console.WriteLine(triangulo.CalcularArea());

            Console.WriteLine("Hola Mundo");
            Console.Read();
        }
    }
}
