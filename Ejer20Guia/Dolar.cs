using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        double cantidad;
        private static double cotizRespectoDolar;

        public Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad) 
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        public static explicit operator Euro(Dolar d)
        {
            double valorDolar = d.cantidad / Euro.GetCotizacion();
            return new Euro(valorDolar);
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)(e.GetCantidad() * Euro.GetCotizacion());
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)(p.GetCantidad() / Pesos.GetCotizacion());
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == (Dolar)(e.GetCantidad() * Euro.GetCotizacion()));
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == (Dolar)p);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return d.cantidad =+ ((Dolar)e).cantidad;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d.cantidad =+ ((Dolar)p).cantidad;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.cantidad =- ((Dolar)e).cantidad;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d.cantidad =- ((Dolar)p).cantidad;
        }
    }
}
