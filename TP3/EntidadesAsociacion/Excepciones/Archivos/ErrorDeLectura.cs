using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Excepciones.Archivos
{
    public class ErrorDeLectura: Exception
    {
        public ErrorDeLectura(string mensaje, Exception error) : base(mensaje)
        {
        }
    }
}
