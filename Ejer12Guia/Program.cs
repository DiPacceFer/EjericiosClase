using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int numero = 0;
            int suma = 0;

            Console.Title = "Ejercicio 12";

            do
            {
                numero = 0;
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;


                Console.WriteLine("Continuar? (S/N)");
                respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (ValidarRespuesta.ValidaS_N(respuesta));



            Console.ReadKey();
        }
    }
}
