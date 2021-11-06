using EntidadesAsociacion.Controladores;
using EntidadesAsociacion.Excepciones.Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Environment;

namespace EntidadesAsociacion.Archivos_Serializacion
{
    public static class ArchivoXML<T> where T : new()
    {
        public static void Escribir(string carpeta, string subCarpeta, string nombreDelArchivo, T contenidoDelArchivo, bool crearPathSiNoExiste)
        {
            string pathCompleto = GenerarPathCometo(carpeta,subCarpeta,nombreDelArchivo,out string path);

            try
            {
                if (crearPathSiNoExiste && !Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                } else if (!crearPathSiNoExiste)
                {
                    throw new PathInexistente("La ruta no existe");
                }

                using (StreamWriter streamWriter = new StreamWriter(pathCompleto))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, contenidoDelArchivo);
                }

            }
            catch (PathInexistente e)
            {
                throw new Exception($"Error al escribir el archivo de texto {path}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al escribir el archivo de texto {path}", e);
            }
        }

        public static T Leer(string carpeta, string nombreDelArchivo)
        {
            string pathCompleto = GenerarPathCometo(carpeta, "", nombreDelArchivo, out string path);

            T contenidoDeseralizado = default;

            try
            {
                if (Directory.Exists(path))
                {
                    string archivo = null;
                    //Busca el Archivo en la ruta
                    foreach (string archivoEnLaRuta in Directory.GetFiles(path))
                    {
                        if (archivoEnLaRuta == pathCompleto)
                        {
                            archivo = archivoEnLaRuta;
                            break;
                        }
                    }
                    if (archivo is not null)
                    {
                        using (StreamReader streamReader = new StreamReader(archivo))
                        {
                            XmlSerializer seralizadorXml = new XmlSerializer(typeof(T));
                            contenidoDeseralizado = (T)seralizadorXml.Deserialize(streamReader);
                        }
                    }
                }
                return contenidoDeseralizado;
            }
            catch (Exception e)
            {
                throw new Exception($"Error al leer el archivo de texto {path}", e);
            }
        }

        private static string GenerarPathCometo(string ruta, string subCarpeta, string nombreDelArchivo, out string path)
        {
            if (!Directory.Exists(ruta))
            {
                throw new Exception("Ruta Invalida");
            }
            StringBuilder sbPath = new StringBuilder();
            sbPath.Append(Path.GetFullPath(ruta));
            if (subCarpeta.Trim() != string.Empty)
            {
                sbPath.Append(@$"\{subCarpeta}\");
            }
            else
            {
                sbPath.Append(@$"\");
            }
            path = sbPath.ToString();
            sbPath.Append(nombreDelArchivo);
            if (!nombreDelArchivo.ToLower().Contains(".xml"))
            {
                sbPath.Append(".xml");
            }
            return sbPath.ToString();
        }
    }
}
