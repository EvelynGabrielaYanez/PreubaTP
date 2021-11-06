using System;
using System.Text;

namespace EntidadesAsociacion
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        protected int dni;

        public Persona()
        { 
        }
        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        /// <summary>
        /// Método encargado de validar que el DNI pasado por parametro
        /// tenga un largo entre 8 y 6 caractere y que el mismo sea númerico.
        /// </summary>
        /// <param name="strDni"></param>
        /// <returns>true = Valido | false = Invalido</returns>
        public static bool ValidarDNI(string strDni)
        {
            if (strDni.Length <= 8 && strDni.Length >= 6)
            {
               return int.TryParse(strDni, out _);
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");

            return sb.ToString(); 
        }
    }
}
