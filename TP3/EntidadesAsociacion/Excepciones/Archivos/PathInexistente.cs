using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Excepciones.Archivos
{
    public class PathInexistente : Exception
    {
        public PathInexistente(string mensaje): base(mensaje)
        { 
        }
    }
}
