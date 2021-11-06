﻿using EntidadesAsociacion.Excepciones.Archivos;
using EntidadesAsociacion.Interfaces;
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
    public static class ArchivoDeTexto<T> where T: ICsv, new()
    {
        public static void Escribir(string ruta, string subCarpeta, string nombreDelArchivo, List<T> contenidoDelArchivo, bool crearPathSiNoExiste)
        {
            Path.GetFullPath(ruta);
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
                using (StreamWriter streamWriter = new StreamWriter(pathCompleto))
                {
                    foreach (T linea in contenidoDelArchivo)
                    {
                        streamWriter.WriteLine(linea.ToStringSeparadoPorComa());
                    }
                }
            }
            catch (PathInexistente e)
            {
                throw new Exception($"Ruta inexistente: {path}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al escribir el archivo de texto {path}", e);
            }
        }

        public static string Leer(string carpeta, string subCarpeta, string nombreDelArchivo)
        {
            GenerarPathCometo(carpeta, subCarpeta, nombreDelArchivo, out string path);

            StringBuilder contenidoDelArchivo = new StringBuilder();

            try
            {
                if (!Directory.Exists(path))
                {
                    string archivo = null;
                    //Busca el Archivo en la ruta
                    foreach (string archivoEnLaRuta in Directory.GetFiles(path))
                    {
                        if (archivoEnLaRuta == nombreDelArchivo)
                        {
                            archivo = nombreDelArchivo;
                            break;
                        }
                    }
                    if (archivo is not null)
                    {
                        using (StreamReader streamReader = new StreamReader(archivo))
                        {
                            string linea;
                            while ((linea = streamReader.ReadLine()) is not null)
                            {
                                contenidoDelArchivo.AppendLine(linea);
                            }
                        }

                    }
                }
                return contenidoDelArchivo.ToString();
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
            if (!nombreDelArchivo.ToLower().Contains(".txt"))
            {
                sbPath.Append(".txt");
            }
            return sbPath.ToString();
        }
    }

}
