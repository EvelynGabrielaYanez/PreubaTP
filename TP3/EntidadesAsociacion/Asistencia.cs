using EntidadesAsociacion.Interfaces;
using System;
using System.Text;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion
{
    public class Asistencia : ICsv
    {
        private Usuario usuario;
        private DateTime fecha;
        private EGrupo grupo;
        private ETipoAsistencia presente;

        public Asistencia()
        {
        }
        public Asistencia(Usuario usuario, DateTime fecha, EGrupo grupo, ETipoAsistencia presente)
        {
            this.usuario = usuario;
            this.fecha = fecha;
            this.grupo = grupo;
            this.presente = presente;
        }
        public Usuario Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public int DniUsuario
        {
            get { return this.usuario.Dni; }
            set { this.usuario.Dni = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        public EGrupo Grupo
        {
            get { return this.grupo; }
            set { this.grupo = value; }
        }

        public ETipoAsistencia Presente
        {
            get { return this.presente; }
            set { this.presente = value; }
        }

        public void EditarRegistro(Asistencia datosEditados)
        {
            this.presente = datosEditados.Presente;
        }

        public string ToStringSeparadoPorComa()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(usuario.ToStringSeparadoPorComa());
            sb.Append(";");
            sb.Append(fecha.ToString());
            sb.Append(";");
            sb.Append(grupo.ToString());
            sb.Append(";");
            sb.Append(presente.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Usuario:{this.usuario}");
            sb.AppendLine($"Fecha: {this.fecha}");
            sb.AppendLine($"Presente: {this.presente}");
            sb.AppendLine($"Grupo: {this.grupo}");

            return sb.ToString();
        }

        public static bool operator ==(Asistencia asistencia1, Asistencia asistencia2)
        {
            return asistencia1 is not null && asistencia2 is not null && asistencia1.Fecha.Date == asistencia2.Fecha.Date && asistencia1.usuario.Equals(asistencia2.usuario);
        }
        public static bool operator !=(Asistencia asistencia1, Asistencia asistencia2)
        {
            return !(asistencia1 == asistencia2);
        }
        public override bool Equals(object obj)
        {
            return obj is Asistencia && (Asistencia)obj == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
