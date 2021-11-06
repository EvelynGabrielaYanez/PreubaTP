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
using EntidadesAsociacion.Excepciones.Empleados;

namespace TP3
{
    public partial class FrmInicioSesion : Form
    {
        static Empleado empleado;
        public static Empleado Empleado
        {
            get { return FrmInicioSesion.empleado; }
            set { FrmInicioSesion.empleado = value; }
        }

        public FrmInicioSesion()
        {
            InitializeComponent();
            empleado = null;
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            pnlEncabezado.BackColor = Color.FromArgb(159, 140, 183);
            btnIniciarSesion.BackColor = Color.FromArgb(159, 140, 183);
            this.lblUsuarioInvalido.Visible = false;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.lblUsuarioInvalido.Visible = false;
            try {
                // Valida el empleado
                Empleado empelado= EmpleadoControlador.ValidarSesion(txtNombreCuenta.Text, txtContrasenia.Text);
                // Abre el formulario principal
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                this.Hide();
                frmMenuPrincipal.ShowDialog();
                // Vacia los campos y muestra el formulario de incio de sesion
                this.Show();
                this.txtContrasenia.Text = string.Empty;
                this.txtNombreCuenta.Text = string.Empty;
            } catch(SesionInvalida)
            {
                this.lblUsuarioInvalido.Visible = true;
            }
        }

        private void lblAutocompletar_Click(object sender, EventArgs e)
        {
            FrmAutocompletar frmAutocompletar = new FrmAutocompletar();
            if (frmAutocompletar.ShowDialog() == DialogResult.OK)
            {
                txtNombreCuenta.Text = empleado.NombreCuenta;
                txtContrasenia.Text = empleado.Contrasenia;
            }
        }
    }
}
