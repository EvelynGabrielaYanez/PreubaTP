using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Excepciones.Genericas
{
    public class NoEncontrado: Exception
    {
        public NoEncontrado(string mensage) : base(mensage)
        {
        }
    }
}
