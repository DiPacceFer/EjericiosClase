using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alum1 = new Alumno();
            alum1.nombre = "Fernando";
            alum1.apellido = "Di Pacce";
            alum1.legajo = 111;
            alum1.Estudiar(4, 7);
            alum1.CalcularFinal();

            Alumno alum2 = new Alumno();
            alum2.nombre = "Eugenia";
            alum2.apellido = "Cabaleiro";
            alum2.legajo = 112;
            alum2.Estudiar(2, 1);
            alum2.CalcularFinal();

            Alumno alum3 = new Alumno();
            alum3.nombre = "Delfina";
            alum3.apellido = "Di Pacce";
            alum3.legajo = 113;
            alum3.Estudiar(8, 10);
            alum3.CalcularFinal();

            Console.WriteLine(alum1.Mostrar());
            Console.WriteLine(alum2.Mostrar());
            Console.WriteLine(alum3.Mostrar());

            Console.ReadKey();
        }
    }
}
