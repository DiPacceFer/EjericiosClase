using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer07Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            DateTime FechaNac;
            DateTime FechaActual;
            TimeSpan resultado;
     
            Console.WriteLine("Ingrese fecha de nacimiento: ");
            FechaNac = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Fecha de nacimiento: {0:dd/MM/yyyy}", FechaNac);
            FechaActual = DateTime.Now;
            resultado = FechaActual - FechaNac;
            
            Console.WriteLine("Vivio {0} dias hasta el dia de hoy", resultado.Days);

            Console.ReadKey();
        }
    }
}
