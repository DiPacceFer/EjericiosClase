using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejer20Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            Euro billeteEuro = new Euro(1);
            Pesos billetePeso = new Pesos(1);
            Pesos billetePeso2 = new Pesos(71.28);
            Dolar billeteDolar = new Dolar(1.08);
            billetePeso = (Pesos)billeteEuro;

            Console.WriteLine(billetePeso.GetCantidad());

            if(billetePeso2 == billeteEuro)
            {
                Console.WriteLine("es igual 66 pesos a 0.92 Euro");
            }

            Console.ReadKey();

        }
    }
}
