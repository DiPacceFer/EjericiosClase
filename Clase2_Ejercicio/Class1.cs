using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio
{
    class Sello
    {
        public static string mensaje;
        public static string Imprimir()
        {
            Console.WriteLine(Sello.ArmarFormatoMensaje());
            return Sello.mensaje;
            
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static ConsoleColor color;

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Sello.Imprimir();
            Console.ResetColor();
        }
        static string ArmarFormatoMensaje()
        {
            string signo= "";
            string mensaje = Sello.mensaje;
            string sello;
            
            foreach(char letra in Sello.mensaje)
            {
                signo += "*";
            }
            sello = signo + "\n" + mensaje + "\n" + signo;

            return sello;
        }
        /*static string ArmarFormatoMensaje() 
        {
            int tam; string borde = "";
            string mensaje;
            string sellito;
            tam = Sello.mensaje.Length;
            for (int i = 0; i<tam+2; i++)
            { 
                borde += "*"; 
            } 
            mensaje = "\n" + Sello.mensaje + "\n";
            sellito = borde + mensaje + borde;
            return sellito;
        }*/
    }
}
