using EntidadesAsociacion.Excepciones.Empleados;
using EntidadesAsociacion.Excepciones.Genericas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion.Controladores
{
    public static class EmpleadoControlador
    {
        public static Empleado ValidarSesion(string nombreUsuario, string contrasenia)
        {
            Empleado retorno = null;
            foreach (Empleado empleado in Asociacion.ListaEmpleados)
            {
                if (empleado.NombreCuenta == nombreUsuario && empleado.Contrasenia == contrasenia)
                {
                    retorno = empleado;
                    break;
                }
            }
            if (retorno is null)
            {
                throw new SesionInvalida();
            }

            return retorno;
        }
        public static List<T> FiltrarEmpleados<T>() where T : Empleado
        {
            List<T> listaFiltrada = new List<T>();

            foreach (Empleado empleado in Asociacion.ListaEmpleados)
            {
                if (empleado.GetType() == typeof(T))
                {
                    listaFiltrada.Add((T)empleado);
                }
            }
            return listaFiltrada;
        }

        public static Empleado ObtenerUnUsuarioDelTipo<T>() where T : Empleado
        {
            List<T> auxLista;

            auxLista = EmpleadoControlador.FiltrarEmpleados<T>();

            if (auxLista.Count == 0)
            {
                throw new NoEncontrado($"No se encontro ningún empleado del tipo {typeof(T)}");
            }

            return auxLista[0];
        }

        public static List<T> FiltrarPorTipoEmpleado<T,U>(this List<U> lista) where T : Empleado
                                                                              where U : Persona
        {
            List<T> datosFiltrados = new List<T>();

            foreach (Persona persona in lista)
            {
                if (typeof(T) == persona.GetType())
                {
                    datosFiltrados.Add((T)persona);
                }
            }

            return datosFiltrados;
        }
    }
}
