using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            return  (Pesos)((((Dolar)e).GetCantidad())*Pesos.GetCotizacion());
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return d == (Dolar)(e.GetCantidad() * Euro.cotizRespectoDolar);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)(p.GetCantidad() * Pesos.GetCotizacion());
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(d == (Dolar)e);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static Euro operator +(Dolar d, Euro e)
        {
            return e.cantidad = +((Euro)d).cantidad;
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return e.cantidad = +((Euro)p).cantidad;
        }
        public static Euro operator -(Dolar d, Euro e)
        {
            return e.cantidad = -((Euro)e).cantidad;
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return e.cantidad = -((Euro)p).cantidad;
        }
    }
}
