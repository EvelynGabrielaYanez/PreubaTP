using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Controladores
{
    public static class PersonaControlador
    {
        public static List<T> BuscarDniQueContanga<T>(this List<T> lista , string dni) where T: Persona
        {
            List<T> datosFiltrados = lista.ToList().Where(persona =>
            {
                return persona.Dni.ToString().Contains(dni);
            }).ToList();

            return datosFiltrados;
        }

    }
}
