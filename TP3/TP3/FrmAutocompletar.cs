using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using EntidadesAsociacion.Excepciones.Genericas;

namespace TP3
{
    public partial class FrmAutocompletar : Form
    {
        public FrmAutocompletar()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.rbtEmpleado.Checked == true)
                {
                    FrmInicioSesion.Empleado = EmpleadoControlador.ObtenerUnUsuarioDelTipo<Empleado>();
                }
                else
                {
                    FrmInicioSesion.Empleado = EmpleadoControlador.ObtenerUnUsuarioDelTipo<Administrador>();
                }
            }
            catch (NoEncontrado error)
            {
                MessageBox.Show(error.Message, "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
