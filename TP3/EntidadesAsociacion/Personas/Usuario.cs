using EntidadesAsociacion.Interfaces;
using EntidadesAsociacion.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion
{
    public class Usuario : Persona, ICsv
    {
        DateTime fechaIngreso;
        List<ETipoCausaIngreso> listadoDeDelitos;
        int denunciasRegistradas;
        int numeroTelefonico;
        bool activo;
        EGrupo grupo;
        public Usuario() : base()
        {
        }

        protected Usuario(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.activo = true;
        }
        public Usuario(string nombre, string apellido, int dni, DateTime fechaIngreso, EGrupo grupo, int denunciasRegistradas, int numeroTelefonico, List<ETipoCausaIngreso> listadoDeDelitos) : this(nombre, apellido, dni)
        {
            this.fechaIngreso = fechaIngreso;
            this.grupo = grupo;
            this.denunciasRegistradas = denunciasRegistradas;
            this.numeroTelefonico = numeroTelefonico;
            this.listadoDeDelitos = listadoDeDelitos;
        }
        public DateTime FechaIngreso
        {
            get { return this.fechaIngreso; }
            set { this.fechaIngreso = value; }
        }
        public List<ETipoCausaIngreso> ListadoDeDelitos
        {
            get { return this.listadoDeDelitos; }
            set { this.listadoDeDelitos = value; }
        }

        public int DenunciasRegistradas
        {
            get { return this.denunciasRegistradas; }
            set { this.denunciasRegistradas = value; }
        }

        public int NumeroTelefonico 
        {
            get { return this.numeroTelefonico; }
            set { this.numeroTelefonico = value; }
        }
        public bool Activo
        {
            get { return this.activo; }
            set { this.activo = value; }
        }
        public EGrupo Grupo
        {
            get { return this.grupo; }
            set { this.grupo = value; }
        }

        public void  EditarDatos(Usuario usuario)
        {
            this.Nombre = usuario.Nombre;
            this.Apellido = usuario.Apellido;
            this.dni = usuario.Dni;

            this.fechaIngreso = usuario.FechaIngreso;
            this.listadoDeDelitos = usuario.ListadoDeDelitos;
            this.denunciasRegistradas = usuario.denunciasRegistradas;
            this.numeroTelefonico = usuario.NumeroTelefonico;
            this.activo = usuario.Activo;
        }

        public string ToStringSeparadoPorComa()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Nombre);
            sb.Append(";");
            sb.Append(this.Apellido);
            sb.Append(";");
            sb.Append(this.Dni);
            sb.Append(";");
            sb.Append(this.FechaIngreso);
            sb.Append(";");
            List<string> stringDelitos = new List<string>();
            foreach (ETipoCausaIngreso causaIngreso in this.ListadoDeDelitos)
            {
                stringDelitos.Add(causaIngreso.ToString());
            }
            sb.Append(string.Join(" - ", stringDelitos));
            sb.Append(";");
            sb.Append(this.denunciasRegistradas);
            sb.Append(";");
            sb.Append(this.NumeroTelefonico);
            _ = sb.Append(";");
            sb.Append(this.Activo ? "SI" : "NO");

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.Append($"Grupo: {this.grupo}");
            sb.Append($"Fecha de ingreso: {this.fechaIngreso}");
            sb.Append($"Motivos de Ingreso: {this.listadoDeDelitos.Mostar()}");
            sb.Append($"Cantidad de denunciar registradas: {this.denunciasRegistradas}");
            sb.Append($"Número telefonico: {this.numeroTelefonico}");

            return base.ToString();
        }

        public bool ValidarLasCausaDeIngreso(List<ETipoCausaIngreso> filtroCausaDeIngreso)
        {
            bool retorno = false;
            foreach (ETipoCausaIngreso causaDeIngresoAValidar in filtroCausaDeIngreso)
            {
                retorno = false;
                foreach (ETipoCausaIngreso causaDeIngreso in this.listadoDeDelitos)
                {
                    if (causaDeIngreso == causaDeIngresoAValidar)
                    {
                        retorno = true;
                    }
                }
                if (!retorno)
                {
                    break;
                }
            }
            return retorno;
        }
        public static bool operator ==(Usuario usuario1, Usuario usuario2)
        {
            return usuario1.Dni == usuario2.Dni;
        }
        public static bool operator !=(Usuario usuario1, Usuario usuario2)
        {
            return !(usuario1 == usuario2);
        }
        public override bool Equals(object obj)
        {
            return obj is Usuario && (Usuario)obj == this;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
