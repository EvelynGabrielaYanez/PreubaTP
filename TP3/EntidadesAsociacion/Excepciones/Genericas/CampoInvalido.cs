using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Excepciones.Genericas
{
    public class CampoInvalido : Exception
    {
        string nombreCampo;
        public CampoInvalido(string mensaje, string nombreCampo) : base(mensaje)
        {
            this.nombreCampo = nombreCampo;
        }
        public string NombreCampo
        {
            get { return this.nombreCampo; }
        }
    }
}
