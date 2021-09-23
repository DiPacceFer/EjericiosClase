using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio17Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            string gastoDeTinta;

            Boligrafo.Boligrafo boliAzul = new Boligrafo.Boligrafo(100, ConsoleColor.Blue);
            Boligrafo.Boligrafo boliRojo = new Boligrafo.Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("El color del primer boligrafo es {0} y del segundo es {1}", 
                boliAzul.GetColor(), boliRojo.GetColor());
            Console.WriteLine("La cantidad de tinta del primer boligrafo es {0} y del segundo es {1}",
                boliAzul.GetTinta(), boliRojo.GetTinta());
            if (boliAzul.Pintar(-4, out gastoDeTinta))
            {
                Console.ForegroundColor = boliAzul.GetColor();
                Console.WriteLine("Se pudo pintar");
            }
            else
            {
                Console.WriteLine("No se pudo pintar");
            }
            Console.ResetColor();
            Console.WriteLine(gastoDeTinta);
            boliRojo.Recargar();
            Console.WriteLine(boliRojo.GetTinta());


            Console.ReadKey();
        }
    }
}
