using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola mundo";
            //Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();

            //Console.WriteLine(Sello.Imprimir());

            Sello.color = ConsoleColor.Red;
            Sello.mensaje = "Hola mundo c#";
            //Sello.ImprimirEnColor();
            Sello.ImprimirEnColor();
            


            Console.ReadKey();

        }
    }
}
