using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio de la clase 1";
            //printf();
            Console.Write("Hola mundo!!!\n");
            Console.WriteLine("Ingrese su nombre: ");


            //scanf("mascara", &variable);
            //gets();
            string nombre = Console.ReadLine();

            Console.WriteLine(nombre);

            Console.WriteLine("Ingrese su edad: ");
            string edad_cadena = Console.ReadLine();

            Int32 edad = int.Parse(edad_cadena);

            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("su nombre es {1} y su edad es {0}", edad, nombre);

            //system("pause");
            Console.ReadKey();
        }
    }
}
