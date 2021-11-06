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

namespace TP3
{
    public partial class FrmRegistros : Form
    {
        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            cmbTipoDeUsuario.DataSource = Enum.GetValues(typeof(ETipoPersonas));
            cmbTipoDeUsuario.SelectedIndex = 1;
            this.ActualizarRegistros();
        }
        private void ActualizarRegistros()
        {
            switch (cmbTipoDeUsuario.SelectedItem)
            {
                case ETipoPersonas.Administrador:
                    dgvRegitros.DataSource = EmpleadoControlador.FiltrarEmpleados<Administrador>();
                    break;
                case ETipoPersonas.Empleado:
                    dgvRegitros.DataSource = EmpleadoControlador.FiltrarEmpleados<Empleado>();
                    break;
                case ETipoPersonas.Usuario:
                    dgvRegitros.DataSource = Asociacion.ListaUsuarios;
                    break;
            }
        }
    }
}
