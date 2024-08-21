using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        public string EsMayorEdad()
        {
            string mensaje = "Es menor de edad";
            if (Edad > 18)

                mensaje = "Es mayor de edad";

            return mensaje;

         void AsignarNombresCompletos()
        {
                NombresCompletos = Nombres + " " + Apellidos;

        }

        }

    }
}
