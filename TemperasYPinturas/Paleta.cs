using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperasYPinturas
{
    class Paleta
    {
        private Tempera[] temperas;
        private int cantidadMaximaColores;

        private Paleta() : this(5)
        {
        }
        private Paleta(int cantidadMax)
        {
            this.cantidadMaximaColores = cantidadMax;
            this.temperas = new Tempera[this.cantidadMaximaColores];
        }
        public static implicit operator Paleta(int cantidadMax)
        {
            return new Paleta(cantidadMax);
        }
        string Mostrar()
        {
            StringBuilder paleta = new StringBuilder();
            paleta.Append("La capacidad maxima de esta paleta es: ");
            paleta.AppendLine(this.cantidadMaximaColores.ToString());
            paleta.AppendLine("Las temperas son: ");

            foreach (Tempera item in this.temperas)
            {
                if(item != null)
                {
                    paleta.AppendLine(Tempera.Mostrar(item));
                }
            }
            return paleta.ToString();
        }
        public static explicit operator string(Paleta unaPaleta)
        {
            return unaPaleta.Mostrar();
        }
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool rta = false;
            for(int i=0; i<paleta.cantidadMaximaColores;i++)
            {
                if(paleta.temperas[i] == tempera)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }
        public int ObtenerIndice()
        {
            int indice = -1;
            for(int i = 0; i < this.cantidadMaximaColores; i++)
            {
                if(this.temperas[i] == null)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        public int ObtenerIndice(Tempera tempera)
        {
            int indice = -1;
            for (int i = 0; i < this.cantidadMaximaColores; i++)
            {
                if (this.temperas[i] == tempera)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int i = paleta.ObtenerIndice(tempera);
            int totalCantidadTempera = 0;

            if (i > -1)
            {
                totalCantidadTempera = paleta.temperas[i].GetCantidad() + tempera.GetCantidad();
                paleta.temperas[i].SetCantidad(totalCantidadTempera);
            }
            else
            {
                i = paleta.ObtenerIndice();
                paleta.temperas[i] = tempera;
            }

            return paleta;
        }
        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int i = paleta.ObtenerIndice(tempera);
            int totalCantidadTempera = 0;
            if (i > -1)
            {
                totalCantidadTempera = paleta.temperas[i].GetCantidad() - tempera.GetCantidad();
                if (totalCantidadTempera <= 0)
                {
                    paleta.temperas[i] = null;
                }
                else
                    paleta.temperas[i].SetCantidad(totalCantidadTempera);
            }

            return paleta;
        }
        public static Paleta operator +(Paleta pal1, Paleta pal2)
        {
            Paleta nuevaPaleta = new Paleta();
            int indice;
            if((object)pal1 != null && (object)pal2 != null)
            {
                nuevaPaleta = pal1.cantidadMaximaColores + pal2.cantidadMaximaColores;
                //foreach (Tempera item in pal1.temperas)
                //{
                //    if(item != null)
                //    {
                //        nuevaPaleta.temperas.SetValue(item, nuevaPaleta.ObtenerIndice());
                //    }
                //}
                pal1.temperas.CopyTo(nuevaPaleta.temperas, 0)
                foreach (Tempera item in pal2.temperas)
                {
                    if(item != null)
                    {
                        indice = nuevaPaleta.ObtenerIndice(item);
                        if(indice == -1)
                        {
                            nuevaPaleta.temperas.SetValue(item, nuevaPaleta.ObtenerIndice());
                            //nuevaPaleta.temperas[nuevaPaleta.ObtenerIndice()] = item;
                        }
                        else
                        {
                            nuevaPaleta.temperas[indice] += item;
                        }
                    }
                }
            }
            return nuevaPaleta;
        }
    }
}
