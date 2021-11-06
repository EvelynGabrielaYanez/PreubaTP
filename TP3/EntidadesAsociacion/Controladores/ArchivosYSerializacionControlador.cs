using EntidadesAsociacion.Interfaces;
using EntidadesAsociacion.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion.Controladores
{
    public static class ArchivosYSerializacionControlador
    {
        public static bool ValidarExtensionTxtCsv(string extension)
        {
            return extension.ToLower().Equals(".txt") || extension.ToLower().Equals(".csv");
        }
        public static bool ValidarExtensionXmlJson(string extension)
        {
            return extension.ToLower().Equals(".xml") || extension.ToLower().Equals(".json");
        }
        public static void ImportarAsistenciasJsonXML(ETipoExtension extension,string nombreArchivo,string ruta)
        {
            Reporte<Asistencia> reporteAsistencias = new Reporte<Asistencia>();
            Reporte<Asistencia> lectura = reporteAsistencias.DesereailziarXmlJson(extension, nombreArchivo, ruta);
            AsistenciaControlador.AgregarListadoDeAsistencias(lectura.DatosReporte);
        }
        public static void ExportarAsistenciaCsvTxt(List<Asistencia> listadoDeAsistencia, ETipoExtension tipoExtension, string nombreArchivo, string ruta)
        {
            Reporte<Asistencia> reporteAsistencia = new Reporte<Asistencia>(listadoDeAsistencia);
            reporteAsistencia.ExportarCsvTxt(tipoExtension, nombreArchivo, "", ruta);
        }
    }
}
