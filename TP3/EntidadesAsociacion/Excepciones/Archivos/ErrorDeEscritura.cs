using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Excepciones.Archivos
{
    public class ErrorDeEscritura: Exception
    {
        public ErrorDeEscritura(string mensaje) : base(mensaje)
        { 
        
        }
        public ErrorDeEscritura(string mensaje, Exception excepcion) : base(mensaje, excepcion)
        {

        }
    }
}
