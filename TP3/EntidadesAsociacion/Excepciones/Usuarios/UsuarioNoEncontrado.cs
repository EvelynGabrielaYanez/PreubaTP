using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Excepciones.Usuarios
{
    public class UsuarioNoEncontrado : Exception
    {
        public UsuarioNoEncontrado(string mensaje) : base(mensaje)
        { 
        }
    }
}
