using EntidadesAsociacion.Excepciones.Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Environment;

namespace EntidadesAsociacion.Archivos_Serializacion
{
    public static class  ArchivoJson<T> where T : new ()
    {
        public static void Escribir(string ruta, string subCarpeta, string nombreDelArchivo, T contenidoDelArchivo, bool crearPathSiNoExiste)
        {
            string pathCompleto = GenerarPathCometo(ruta, subCarpeta, nombreDelArchivo, out string path);

            try
            {
                if (crearPathSiNoExiste && !Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else if (!crearPathSiNoExiste)
                {
                    throw new PathInexistente("La ruta no existe");
                }
                File.WriteAllText(pathCompleto,JsonSerializer.Serialize(contenidoDelArchivo));

            }
            catch (PathInexistente e)
            {
                throw new Exception($"Ruta inexistente: {path}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al escribir el archivo Json {path}", e);
            }
        }

        public static T Leer(string carpeta, string nombreDelArchivo)
        {
            string pathCompleto = GenerarPathCometo(carpeta, "" , nombreDelArchivo, out string path);
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
                        contenidoDeseralizado  = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
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
            if (!nombreDelArchivo.ToLower().Contains(".json"))
            {
                sbPath.Append(".json");
            }
            return sbPath.ToString();
        }
    }
}
