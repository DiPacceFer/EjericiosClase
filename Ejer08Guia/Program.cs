using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer08Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            float ValorHora = 0;
            string Nombre;
            int Antiguedad = 0;
            int HorasTrabajadas = 0;
            float ImporteACobrar = 0;
            int ImporteAntiguedad = 0;
            char respuesta = 's';


            while(respuesta == 's')
            {
                Console.WriteLine("Ingrese nombre empleado: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese antiguedad en años: ");
                Antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese horas trabajadas: ");
                HorasTrabajadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor por hora: ");
                ValorHora = float.Parse(Console.ReadLine());

                ImporteACobrar = ValorHora * HorasTrabajadas;
                ImporteAntiguedad = Antiguedad * 150;
                ImporteACobrar = ImporteACobrar + ImporteAntiguedad;
                Console.WriteLine("{0:.00}", ImporteACobrar);

                Console.WriteLine("Desea Ingresar otro empleado?: s/n ");
                respuesta = (char)Console.Read();
            }


            Console.ReadKey();
        }
    }
}
