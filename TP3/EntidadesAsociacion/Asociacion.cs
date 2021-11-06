using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesAsociacion.Enumerados;

namespace EntidadesAsociacion
{
    public static class Asociacion
    {
        static List<Usuario> listaUsuarios;
        static List<Empleado> listaEmpleados;
        static List<Asistencia> listadoAsistencias;

        static Asociacion()
        {
            Asociacion.listaUsuarios = new List<Usuario>();
            Asociacion.listaEmpleados = new List<Empleado>();
            Asociacion.listadoAsistencias = new List<Asistencia>();
            Asociacion.HardCodeoEmpleados();
           Asociacion.HardCodeoUsuarioYAsistencias();
        }

        public static List<Usuario> ListaUsuarios
        {
            get { return Asociacion.listaUsuarios; }
        }
        public static List<Empleado> ListaEmpleados
        {
            get { return Asociacion.listaEmpleados; }
        }
        public static List<Asistencia> ListadoAsistencias
        {
            get { return Asociacion.listadoAsistencias; }
        }

        private static void HardCodeoEmpleados()
        {
            listaEmpleados = new List<Empleado>()
            {
              { new Empleado("nombreEmpleado1", "apellidoEmpelado1", 39429755, "empleado1", "contra1234") },
              { new Empleado("nombreEmpleado2", "apellidoEmpelado2", 39429756, "empleado2", "senia5678") },
              { new Empleado("nombreEmpleado3", "apellidoEmpelado3", 39429757, "empleado3", "emplea123") },
              { new Administrador("nombreAdmin1", "apellidoAdmin1", 39429758, "admin1", "admin123") },
              { new Administrador("nombreAdmin2", "apellidoAdmin2", 39429759, "admin2", "admin456") }
            };
        }
        private static void HardCodeoUsuarioYAsistencias()
        {
            Usuario usuario1 = new Usuario("nombreUsuario1", "apellidoUsuario1", 31429766, Convert.ToDateTime("01/07/2021"), EGrupo.Viernes, 2, 1566429774, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.DelitoSexual });
            Usuario usuario2 = new Usuario("nombreUsuario2", "apellidoUsuario2", 34429765, Convert.ToDateTime("01/08/2021"), EGrupo.Martes, 1, 1566439685, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.DelitoSexual, ETipoCausaIngreso.ViolenciaDomestica });
            Usuario usuario3 = new Usuario("nombreUsuario3", "apellidoUsuario3", 39429767, Convert.ToDateTime("01/09/2021"), EGrupo.Miercoles, 5, 1566439685, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.ViolenciaDomestica });
            Usuario usuario4 = new Usuario("nombreUsuario4", "apellidoUsuario4", 36429768, Convert.ToDateTime("03/04/2021"), EGrupo.Miercoles, 10, 1578423714, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.DelitoSexual, ETipoCausaIngreso.MaltratoYAbusoInfantil });
            Usuario usuario5 = new Usuario("nombreUsuario4", "apellidoUsuario4", 39429112, Convert.ToDateTime("03/05/2021"), EGrupo.Viernes, 10, 1578423714, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.DelitoSexual, ETipoCausaIngreso.MaltratoYAbusoInfantil });
            Usuario usuario6 = new Usuario("nombreUsuario4", "apellidoUsuario4", 37429444, Convert.ToDateTime("01/09/2021"), EGrupo.Lunes, 10, 1578423714, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.DelitoSexual, ETipoCausaIngreso.MaltratoYAbusoInfantil });

            Asociacion.listaUsuarios = new List<Usuario>()
            {
              {usuario1},
              {usuario2},
              {usuario3},
              {usuario4}
            };

            Asociacion.listadoAsistencias = new List<Asistencia>()
            {
              { new Asistencia(usuario1, Convert.ToDateTime("29/10/2021"),EGrupo.Viernes,ETipoAsistencia.Ausente)},
              { new Asistencia(usuario2, Convert.ToDateTime("26/10/2021"),EGrupo.Martes,ETipoAsistencia.AusenteConAviso)},
              { new Asistencia(usuario2, Convert.ToDateTime("02/11/2021"),EGrupo.Martes,ETipoAsistencia.AusenteConAviso)},
              { new Asistencia(usuario3, Convert.ToDateTime("03/11/2021"),EGrupo.Miercoles,ETipoAsistencia.Feriado)},
              { new Asistencia(usuario4, Convert.ToDateTime("03/11/2021"),EGrupo.Miercoles,ETipoAsistencia.Presente)},
              { new Asistencia(usuario4, Convert.ToDateTime("27/10/2021"),EGrupo.Miercoles,ETipoAsistencia.Presente)},
              { new Asistencia(usuario3, Convert.ToDateTime("27/10/2021"),EGrupo.Miercoles,ETipoAsistencia.Presente)},
              { new Asistencia(usuario5, Convert.ToDateTime("01/01/2021"),EGrupo.Viernes,ETipoAsistencia.Presente)},
              { new Asistencia(usuario5, Convert.ToDateTime("29/10/2021"),EGrupo.Viernes,ETipoAsistencia.Presente)},
              { new Asistencia(usuario6, Convert.ToDateTime("01/11/2021"),EGrupo.Lunes,ETipoAsistencia.Presente)},
              { new Asistencia(usuario6, Convert.ToDateTime("25/10/2021"),EGrupo.Lunes,ETipoAsistencia.Ausente)},
              { new Asistencia(usuario6, Convert.ToDateTime("18/10/2021"),EGrupo.Lunes,ETipoAsistencia.AusenteConAviso)}
            };
        }


        public static EGrupo ObtenerGrupoPorFecha()
        {
            string dia = DateTime.Now.ToString("dddd", CultureInfo.CreateSpecificCulture("es-ES"));
            switch (dia.ToLower())
            {
                case "lunes":
                    return EGrupo.Lunes;
                case "martes":
                    return EGrupo.Martes;
                case "miércoles":
                    return EGrupo.Miercoles;
                case "jueves":
                    return EGrupo.Jueves;
                default:
                    return EGrupo.Viernes;
            }
        }
    }
}
