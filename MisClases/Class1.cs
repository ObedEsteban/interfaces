using Corto.MisInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corto.MisClases
{
    internal class ClsPersona : Ipersona
    {
        public string Nombre { get; }
        public int Edad { get; }
        public int contador;


        public ClsPersona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            contador = 0;
        }

        public void cumpirAños()
        {
            contador++;
            Console.WriteLine("Feliz cumpleaños, ahora tienes {0} años.", Edad + contador);


        }

        public void DecirMiNombre()
        {
            Console.WriteLine("Mi nombre es {0}.", Nombre);
        }
    }


}