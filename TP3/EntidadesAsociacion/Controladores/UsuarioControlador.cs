using EntidadesAsociacion.Excepciones.Usuarios;
using EntidadesAsociacion.Reportes;
using EntidadesAsociacion.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion.Controladores
{
    public static class UsuarioControlador
    {
        public static bool AgregarUsuario(Usuario nuevoUsuario)
        {
            bool retorno = true;
            // Valido si el usuario ya esta en la lista y si no esta lo agrego
            foreach (Usuario usuario in Asociacion.ListaUsuarios)
            {
                if (usuario == nuevoUsuario)
                {
                    retorno = false;
                    break;
                }
            }
            if (retorno)
            {
                Asociacion.ListaUsuarios.Add(nuevoUsuario);
            }
            return retorno;
        }

        public static Usuario EditarUsuario(Usuario usuarioDatosEditados)
        {
            Usuario retorno = null;
            foreach (Usuario usuario in Asociacion.ListaUsuarios)
            {
                if (usuario == usuarioDatosEditados)
                {
                    usuario.EditarDatos(usuarioDatosEditados);
                    retorno = usuario;
                    break;
                }
            }
            if (retorno is null)
            {
                throw new UsuarioNoEncontrado("No se encontro el usuario a editar");
            }
            return retorno;
        }
        public static Usuario BajaUsuario(int dni)
        {
            Usuario retorno = null;
            foreach (Usuario usuario in Asociacion.ListaUsuarios)
            {
                if (usuario.Dni == dni)
                {
                    usuario.Activo = false;
                    retorno = usuario;
                    break;
                }
            }
            if (retorno is null)
            {
                throw new UsuarioNoEncontrado("No se encontro el usuario a eliminar");
            }
            return retorno;
        }

        public static List<Usuario> FiltrarPorFecha(DateTime fechaDesde, DateTime fechaHasta, List<Usuario> listadoaFiltrar)
        {
            List<Usuario> listadoRetorno = new List<Usuario>();
            if (fechaDesde <= fechaHasta)
            {
                foreach (Usuario usuario in listadoaFiltrar)
                { 
                    if(usuario.FechaIngreso.Date >= fechaDesde.Date && usuario.FechaIngreso.Date <= fechaHasta.Date)
                    {
                        listadoRetorno.Add(usuario);
                    }
                }
            }
            return listadoRetorno;
        }

        public static List<Usuario> FiltrarCantidadDenuncias(int denunciasMinimo, int denunciasMaximo, List<Usuario> listadoaFiltrar)
        {
            List<Usuario> listadoRetorno = new List<Usuario>();
            if (denunciasMinimo >= 0 && denunciasMinimo <= denunciasMaximo)
            {
                foreach (Usuario usuario in listadoaFiltrar)
                {
                    if (usuario.DenunciasRegistradas >= denunciasMinimo && usuario.DenunciasRegistradas <= denunciasMaximo)
                    {
                        listadoRetorno.Add(usuario);
                    }
                }
            }
            return listadoRetorno;
        }
        public static List<Usuario> FiltrarCausaDeIngreso(List<ETipoCausaIngreso> filtroCausaDeIngreso, List<Usuario> listadoaFiltrar)
        {
            List<Usuario> listadoRetorno = new List<Usuario>();
            if (filtroCausaDeIngreso is not null && filtroCausaDeIngreso.Count > 0)
            {
                foreach (Usuario usuario in listadoaFiltrar)
                {
                    if (usuario.ValidarLasCausaDeIngreso(filtroCausaDeIngreso))
                    {
                        listadoRetorno.Add(usuario);
                    }
                }
            }
            return listadoRetorno;
        }

        public static List<RegistroPorcentaje> CalcularPorcentajePorDenuncias( int intevaloDenuncias)
        {
            List<RegistroPorcentaje> listadoRetorno = new List<RegistroPorcentaje>();
            if (intevaloDenuncias<=0)
            {
                return listadoRetorno;
            }

            int cantidadDeUsuarios = Asociacion.ListaUsuarios.Count;
            if (cantidadDeUsuarios == 0)
            {
                cantidadDeUsuarios = 1;
            }
            int totalRegistrosCalculados = 0;
            for (int i = 1; totalRegistrosCalculados < cantidadDeUsuarios; i++)
            {
                int intervaloDedese = (i - 1) * intevaloDenuncias;
                int intervaloHasta = i * intevaloDenuncias - 1;

                RegistroPorcentaje nuevoRegistro = new RegistroPorcentaje($"{intervaloDedese}-{intervaloHasta}");
                foreach (Usuario registro in Asociacion.ListaUsuarios)
                {
                    if (registro.DenunciasRegistradas >= intervaloDedese && registro.DenunciasRegistradas <= intervaloHasta)
                    {
                        nuevoRegistro.Cantidad++;
                        totalRegistrosCalculados++;
                    }
                }
                nuevoRegistro.Porcentaje = (double)(100 * nuevoRegistro.Cantidad) / cantidadDeUsuarios;
                listadoRetorno.Add(nuevoRegistro);
            }

            return listadoRetorno;
        }
        public static List<RegistroPorcentaje> CalcularPorcentajesPorMeses(int inteveloMeses)
        {
            List<RegistroPorcentaje> listadoRetorno = new List<RegistroPorcentaje>();
            if (inteveloMeses <= 0)
            {
                return listadoRetorno;
            }

            int cantidadDeUsuarios = Asociacion.ListaUsuarios.Count;
            if (cantidadDeUsuarios == 0)
            {
                cantidadDeUsuarios = 1;
            }
            int totalRegistrosCalculados = 0;
            for (int i = 1; totalRegistrosCalculados < cantidadDeUsuarios; i++)
            {
                int intervaloDedese = (i - 1) * inteveloMeses;
                int intervaloHasta = i * inteveloMeses - 1;

                RegistroPorcentaje nuevoRegistro = new RegistroPorcentaje($"{intervaloDedese}-{intervaloHasta}");
                foreach (Usuario registro in Asociacion.ListaUsuarios)
                {
                    int mesesTranscurridosDesdeIngreso = registro.FechaIngreso.CalcularMesesHastaLaActualidad();
                    if (mesesTranscurridosDesdeIngreso >= intervaloDedese && mesesTranscurridosDesdeIngreso <= intervaloHasta)
                    {
                        nuevoRegistro.Cantidad++;
                        totalRegistrosCalculados++;
                    }
                }
                nuevoRegistro.Porcentaje = (double)(100 * nuevoRegistro.Cantidad) / cantidadDeUsuarios;
                listadoRetorno.Add(nuevoRegistro);
            }
            return listadoRetorno;
        }

        public static List<RegistroPorcentaje> CalcularPorcentajesPorCausaIngreso()
        {
            List<RegistroPorcentaje> listadoRetorno = new List<RegistroPorcentaje>();
            int cantidadDeUsuarios = Asociacion.ListaUsuarios.Count;
            if (cantidadDeUsuarios == 0)
            {
                cantidadDeUsuarios = 1;
            }
            foreach (ETipoCausaIngreso causaDeIngreso in Enum.GetValues(typeof(ETipoCausaIngreso)))
            {
                int CantidadPorCausa = UsuarioControlador.FiltrarCausaDeIngreso(new List<ETipoCausaIngreso>() {causaDeIngreso}, Asociacion.ListaUsuarios).Count;
                RegistroPorcentaje nuevoRegistro = new RegistroPorcentaje(CantidadPorCausa,(double)(CantidadPorCausa*100)/cantidadDeUsuarios, causaDeIngreso.ToString());
                listadoRetorno.Add(nuevoRegistro);
            }

            return listadoRetorno;
        }

        public static List<int> BuscarListadoDni()
        {
            List<int> listaRetorno = new List<int>();
            foreach (Usuario usuario in Asociacion.ListaUsuarios)
            {
                listaRetorno.Add(usuario.Dni);
            }
            return listaRetorno;
        }

        public static Usuario BuscarUsuario(int dni)
        {
            Usuario usuarioRetorno = null;
            foreach (Usuario usuario in Asociacion.ListaUsuarios)
            {
                if (usuario.Dni == dni)
                {
                    usuarioRetorno = usuario;
                    break;
                }
            }
            if (usuarioRetorno is null)
            {
                throw new UsuarioNoEncontrado($"No se encontro ningun usuario con DNI: {dni}");
            }
            return usuarioRetorno;
        }
    }
}
