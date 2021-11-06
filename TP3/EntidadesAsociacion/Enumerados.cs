using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAsociacion
{
    public class Enumerados
    {
        public enum ETipoAsistencia
        {
            Ausente,
            AusenteConAviso,
            Feriado,
            Presente
        }
        public enum ETipoCausaIngreso
        {
            DelitoSexual,
            MaltratoYAbusoInfantil,
            ViolenciaDomestica
        }
        public enum EGrupo
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes
        }
        public enum ETipoPersonas
        {
            Usuario,
            Administrador,
            Empleado
        }

        public enum ETipoExtension
        { 
            Txt,
            Csv,
            Json,
            Xml
        }
        public enum EFiltros
        { 
            FechaDesde,
            FechaHasta,
            EdadDesde,
            EdadHasta
        }
        public enum ETipoReporte
        {
            Filtro,
            Porcentaje
        }

        public enum ETipoPersona
        {
            Usuario,
            Empleado,
            Administrador
        }
    }
}
