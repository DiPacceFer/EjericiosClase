using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase01_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa algo = new Cosa();
            DateTime a = new DateTime(2019, 10, 18);
            //algo.EstablecerValor(18);
            //algo.EstablecerValor("Delfi");
            algo.EstablecerValor(a);

            Console.WriteLine(Cosa.mostrar(algo));

            Cosa algo1 = new Cosa(18, "Delfi");
            Cosa algo2 = new Cosa("Euge");
            Cosa algo3 = new Cosa(DateTime.Now, 4, "Fer");
            Console.WriteLine(Cosa.mostrar(algo1));
            Console.WriteLine(Cosa.mostrar(algo2));
            Console.WriteLine(Cosa.mostrar(algo3));
            Console.ReadKey();
        }
    }
}
