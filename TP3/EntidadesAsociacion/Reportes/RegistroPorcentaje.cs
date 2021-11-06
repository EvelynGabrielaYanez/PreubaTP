using EntidadesAsociacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion.Reportes
{
    public class RegistroPorcentaje : ICsv
    {
        int cantidad;
        double porcentaje;
        string intervalo;

        public RegistroPorcentaje()
        {
        }
        public RegistroPorcentaje(string intervalo)
        {
            this.intervalo = intervalo;
        }
        public RegistroPorcentaje(int cantidad, double porcentaje, string intervalo): this(intervalo)
        {
            this.cantidad = cantidad;
            this.porcentaje = porcentaje;
        }
        public string Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public double Porcentaje
        {
            get { return this.porcentaje; }
            set { this.porcentaje = value; }
        }

        public string ToStringSeparadoPorComa()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.intervalo.ToString());
            sb.Append(";");
            sb.Append(this.cantidad.ToString());
            sb.Append(";");
            sb.Append(this.porcentaje.ToString());
            return sb.ToString();
        }
    }
}
