using EntidadesAsociacion.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion.Controladores
{
    public static class AsistenciaControlador
    {
        public static bool AgregarAsistencia(Asistencia nuevoRegistro)
        {
            bool retorno = true;
            // Valido si el usuario ya esta en la lista y si no esta lo agrego
            foreach (Asistencia registro in Asociacion.ListadoAsistencias)
            {
                if (nuevoRegistro == registro)
                {
                    retorno = false;
                    break;
                }
            }
            if (retorno)
            {
                Asociacion.ListadoAsistencias.Add(nuevoRegistro);
            }
            return retorno;
        }

        public static bool EditarAsistencia(Asistencia registroDatosEditado)
        {
            foreach (Asistencia registro in Asociacion.ListadoAsistencias)
            {
                if (registro == registroDatosEditado)
                {
                    registro.EditarRegistro(registroDatosEditado);
                    return true;
                }
            }
            return false;
        }

        public static List<Asistencia> FiltrarAsistencias(DateTime fechaDesde, DateTime fecgaHasta, EGrupo grupo)
        {
            List<Asistencia> retornoAsistencias = new List<Asistencia>();
            foreach (Asistencia registro in Asociacion.ListadoAsistencias)
            {
                if (registro.Fecha.Date >= fechaDesde.Date && registro.Fecha.Date <= fecgaHasta.Date && grupo == registro.Grupo)
                {
                    retornoAsistencias.Add(registro);
                }
            }
            return retornoAsistencias;
        }

        public static List<Asistencia> FiltrarPorGrupo(EGrupo grupo)
        {
            List<Asistencia> retornoAsistencias = new List<Asistencia>();
            foreach (Asistencia registro in Asociacion.ListadoAsistencias)
            {
                if (grupo == registro.Grupo)
                {
                    retornoAsistencias.Add(registro);
                }
            }
            return retornoAsistencias;
        }

        public static void AgregarListadoDeAsistencias(List<Asistencia> listadoDeAsistencias)
        {
            foreach (Asistencia asistencia in listadoDeAsistencias)
            {
                AsistenciaControlador.AgregarAsistencia(asistencia);
            }
        }

        private static List<Asistencia> FiltrarPorTipoPresencialidad(ETipoAsistencia tipoDeAsistencia, EGrupo grupo ,List<Asistencia> listadoAsistencias)
        {
            List<Asistencia> listadoRetorno = new List<Asistencia>();
            foreach (Asistencia asistencia in listadoAsistencias)
            {
                if (asistencia.Presente == tipoDeAsistencia && asistencia.Grupo == grupo)
                {
                    listadoRetorno.Add(asistencia);
                }
            }
            return listadoRetorno;
        }

        public static List<RegistroPorcentaje> CalcularPorcentaPorTipoAsistencia(EGrupo grupo)
        {
            List<RegistroPorcentaje> listadoRetorno = new List<RegistroPorcentaje>();
            int cantidadUsuariosPorGrupo = CalcularAsistenciasPorGrupo(grupo);
            if (cantidadUsuariosPorGrupo == 0)
            {
                cantidadUsuariosPorGrupo = 1;
            }
            foreach (ETipoAsistencia tipoDeAsistencia in Enum.GetValues(typeof(ETipoAsistencia)))
            {
                int CantidadPorCausa = AsistenciaControlador.FiltrarPorTipoPresencialidad(tipoDeAsistencia, grupo, Asociacion.ListadoAsistencias).Count;
                RegistroPorcentaje nuevoRegistro = new RegistroPorcentaje(CantidadPorCausa, (double)(CantidadPorCausa * 100) / cantidadUsuariosPorGrupo, $"{grupo}-{tipoDeAsistencia}");
                listadoRetorno.Add(nuevoRegistro);
            }

            return listadoRetorno;
        }

        private static int CalcularAsistenciasPorGrupo(EGrupo grupo)
        {
            int cantidad = 0;
            foreach (Asistencia asistencia in Asociacion.ListadoAsistencias)
            {
                if (asistencia.Grupo == grupo)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

    }
}
