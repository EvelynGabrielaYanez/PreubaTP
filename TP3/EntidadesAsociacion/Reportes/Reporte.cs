using EntidadesAsociacion.Archivos_Serializacion;
using EntidadesAsociacion.Controladores;
using EntidadesAsociacion.Excepciones.Archivos;
using EntidadesAsociacion.Interfaces;
using EntidadesAsociacion.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion.Reportes
{
    public class Reporte<T> where T: ICsv, new()
    {
        private List<T> datosReporte;
        public Reporte()
        {
            this.datosReporte = new List<T>();
        }
        public Reporte(List<T> datosReporte)
        {
            this.datosReporte = datosReporte;
        }

        public List<T> DatosReporte
        {
            get { return this.datosReporte; }
            set { this.datosReporte = value; }
        }

        public void ExportarCsvTxt(ETipoExtension extension, string nombre, string carpetaExtra ,string path)
        {
            string nombreArchivo = $"{nombre}.{extension.ToString().ToLower()}";
            switch (extension)
            {
                case ETipoExtension.Txt:
                    ArchivoDeTexto<T>.Escribir(path, carpetaExtra, nombreArchivo, this.datosReporte, true);
                    break;
                case ETipoExtension.Csv:
                    ArchivoCsv<T>.Escribir(path, carpetaExtra, nombreArchivo, this.datosReporte, true);
                    break;
                default:
                    ExtensionInvalida extensionInvalida = new ExtensionInvalida($"La extension: {extension} es invalida");
                    throw new ErrorDeLectura("Error al deserealizar el archvo.", extensionInvalida);
            }
        }

        public void SerializarXmlJson(ETipoExtension extension, string nombre, string carpetaExtra, string path)
        {
            string nombreArchivo = $"{nombre}.{extension.ToString().ToLower()}";
            switch (extension)
            {
                case ETipoExtension.Json:
                    ArchivoJson<Reporte<T>>.Escribir(path, carpetaExtra, nombreArchivo, this, true);
                    break;
                case ETipoExtension.Xml:
                    ArchivoXML<Reporte<T>>.Escribir(path, carpetaExtra, nombreArchivo, this, true);
                    break;
                default:
                    ExtensionInvalida extensionInvalida = new ExtensionInvalida($"La extension: {extension} es invalida");
                    throw new ErrorDeLectura("Error al deserealizar el archvo.", extensionInvalida);
            }
        }

        public Reporte<T> DesereailziarXmlJson(ETipoExtension extension,string nombre, string path)
        {
            Reporte<T> reporte = new Reporte<T>(); 
            string nombreArchivo = $"{nombre}.{extension.ToString().ToLower()}";
            switch (extension)
            {
                case ETipoExtension.Json:
                    reporte = ArchivoJson<Reporte<T>>.Leer(path, nombreArchivo);
                    break;
                case ETipoExtension.Xml:
                    reporte = ArchivoXML<Reporte<T>>.Leer(path, nombreArchivo);
                    break;
                default:
                    ExtensionInvalida extensionInvalida = new ExtensionInvalida($"La extension: {extension} es invalida");
                    throw new ErrorDeLectura("Error al deserealizar el archvo.", extensionInvalida);
            }

            return reporte;
        }
    }
}
