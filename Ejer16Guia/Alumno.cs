using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16Guia
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            int semilla = DateTime.Now.Millisecond;
            Random rnd = new Random(semilla);
            this.notaFinal = rnd.Next(0,10);
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string notaFinal;
            if(this.notaFinal != -1)
            {
                notaFinal = this.notaFinal.ToString();
            }
            else
            {
                notaFinal = "Alumno desaprobado";
            }
            return "Apellido, nombre: " + this.apellido + ", " + this.nombre + "\n" +
                "Nota1: " + this.nota1 + "\n" + "Nota2: " + this.nota2 + "\n" +
                "Nota final: " + notaFinal;
            //Console.WriteLine("Apellido, nombre: {0}, {1}", this.apellido, this.nombre);
            //Console.WriteLine("Nota1: {0}", this.nota1);
            //Console.WriteLine("Nota2: {1}", this.nota2);
            
        }
    }
}
