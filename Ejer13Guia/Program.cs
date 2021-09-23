using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer13Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            string numeroBi2 = "";
            int numeroDe2 = 0;

            //int numeroD = 0;
            //string numeroBi = "";
            //Console.WriteLine("Ingrese un numero decimal: ");
            //numeroD = int.Parse(Console.ReadLine());
            //numeroBi = Conversor.DecimalBinario(numeroD);
            //Console.WriteLine(numeroBi);
            Console.WriteLine("Ingrese un numero binario: ");
            numeroBi2 = Console.ReadLine();
            numeroDe2 = Conversor.BinarioDecimal(numeroBi2);
            Console.WriteLine(numeroDe2);


            Console.ReadKey();
        }
    }
}
