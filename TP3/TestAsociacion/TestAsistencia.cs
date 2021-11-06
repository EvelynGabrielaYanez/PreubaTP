using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static EntidadesAsociacion.Enumerados;

namespace TestAsociacion
{
    [TestClass]
    public class TestAsistencia
    {
        Asistencia asistencia;
        [TestInitialize]
        public void Initialize()
        {
            Usuario usuario = new Usuario("asistenciaTestNombre", "asistenciaTestApellido", 38555666, Convert.ToDateTime("01/09/2021"), EGrupo.Lunes, 10, 1578423714, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.DelitoSexual, ETipoCausaIngreso.MaltratoYAbusoInfantil });
            this.asistencia = new Asistencia(usuario, Convert.ToDateTime("29/10/2021"), EGrupo.Viernes, ETipoAsistencia.A);
        }

        [TestMethod]
        public void Test_AgregarAsistencia_01()
        {
            bool retorno = AsistenciaControlador.AgregarAsistencia(this.asistencia);
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void Test_AgregarAsistencia_02()
        {
            AsistenciaControlador.AgregarAsistencia(this.asistencia);
            bool retorno = AsistenciaControlador.AgregarAsistencia(this.asistencia);
            Assert.IsFalse(retorno);
        }

        [DataRow(ETipoAsistencia.F)]
        [TestMethod]
        public void Test_EditarAsistencia_01(ETipoAsistencia tipoDeasistencia)
        {

            AsistenciaControlador.AgregarAsistencia(this.asistencia);
            this.asistencia.Presente = tipoDeasistencia;
            bool retorno = AsistenciaControlador.EditarAsistencia(this.asistencia);

            // Obtengo la ultima asistencia de la lista para verificar si se agrego
            int indice = Asociacion.ListadoAsistencias.Count -1;
            Asistencia asistenciaRetorno = Asociacion.ListadoAsistencias[indice];
            
            Assert.AreEqual(tipoDeasistencia, asistenciaRetorno.Presente);
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void Test_EditarAsistencia_02()
        {
            Usuario usuario = new Usuario("asistenciaTestNombre2", "asistenciaTestApellido2", 38555777, Convert.ToDateTime("01/09/2021"), EGrupo.Lunes, 10, 1578423714, new List<ETipoCausaIngreso>() { ETipoCausaIngreso.DelitoSexual, ETipoCausaIngreso.MaltratoYAbusoInfantil });
            this.asistencia = new Asistencia(usuario, Convert.ToDateTime("29/10/2021"), EGrupo.Viernes, ETipoAsistencia.A);

            bool retorno = AsistenciaControlador.EditarAsistencia(this.asistencia);
            Assert.IsFalse(retorno);
        }
    }
}
