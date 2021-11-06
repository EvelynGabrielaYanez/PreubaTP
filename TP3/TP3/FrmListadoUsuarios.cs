using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntidadesAsociacion.Enumerados;

namespace TP3.UsuarioABM
{
    public partial class FrmListadoUsuarios : Form
    {
        List<Persona> fuenteDeInformacion;
        public FrmListadoUsuarios()
        {
            InitializeComponent();
            this.fuenteDeInformacion = new List<Persona>();
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            cmbTipoPersona.DataSource = Enum.GetValues(typeof(ETipoPersona));
            txtDni.PlaceholderText = "Inserte el Dni";
            this.CargarDatosSinFiltro((ETipoPersona)cmbTipoPersona.SelectedItem);
        }

        private void CargarDatosSinFiltro(ETipoPersona tipoPersona)
        {
            this.fuenteDeInformacion.Clear();

            switch (tipoPersona)
            {
                case ETipoPersona.Administrador:
                    this.fuenteDeInformacion.AddRange(Asociacion.ListaEmpleados.FiltrarPorTipoEmpleado<Administrador, Empleado>());
                    break;
                case ETipoPersona.Empleado:
                    this.fuenteDeInformacion.AddRange(Asociacion.ListaEmpleados.FiltrarPorTipoEmpleado<Empleado, Empleado>());
                    break;
                case ETipoPersona.Usuario:
                    this.fuenteDeInformacion.AddRange(Asociacion.ListaUsuarios);
                    break;
            }

            this.ActualizarTabla(this.fuenteDeInformacion);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ActualizarTabla(this.fuenteDeInformacion.BuscarDniQueContanga(txtDni.Text));
        }

        /// <summary>
        /// Método que recibe una lista de usuarios que puede o no estar filtada y 
        /// actualiza la fuente del datagrid con la misma.
        /// </summary>
        /// <param name="datosFiltrados"></param>
        private void ActualizarTabla(List<Persona> datosFiltrados)
        {
            switch ((ETipoPersona)this.cmbTipoPersona.SelectedItem)
            {
                case ETipoPersona.Administrador:
                case ETipoPersona.Empleado:
                    dgvPersonas.DataSource = datosFiltrados.Cast<Empleado>().ToList();
                    break;
                case ETipoPersona.Usuario:
                    dgvPersonas.DataSource = datosFiltrados.Cast<Usuario>().ToList();
                    break;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.ShowDialog();
            this.Show();
            this.CargarDatosSinFiltro((ETipoPersona)cmbTipoPersona.SelectedItem);
        }

        private void cmbTipoPersona_SelectedValueChanged(object sender, EventArgs e)
        {
            this.CargarDatosSinFiltro((ETipoPersona)cmbTipoPersona.SelectedItem);
        }
    }
}
