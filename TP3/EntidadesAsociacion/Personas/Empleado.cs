using EntidadesAsociacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion
{
    public class Empleado : Persona
    {
        string nombreCuenta;
        string contrasenia;
        public string NombreCuenta
        {
            get { return this.nombreCuenta; }
        }
        public string Contrasenia
        {
            get { return this.contrasenia; }
        }
        protected Empleado(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
        }
        public Empleado(string nombre, string apellido, int dni, string nombreCuenta, string contraseña) : this(nombre, apellido, dni)
        {
            this.nombreCuenta = nombreCuenta;
            this.contrasenia = contraseña;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Nombre de la Cuenta: {this.NombreCuenta}");

            return sb.ToString(); 
        }
    }
}
