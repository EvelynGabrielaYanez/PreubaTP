using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, string apellido, int dni, string nombreCuenta, string contraseña) : base(nombre, apellido, dni, nombreCuenta,contraseña)
        {
        }
    }
}
