using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using EntidadesAsociacion.Excepciones.Genericas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntidadesAsociacion.Enumerados;

namespace TP3.UsuarioABM
{
    public partial class FrmAltaUsuario : Form
    {
        private ErrorProvider errorEnCampo;
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cmbGrupo.DataSource = Enum.GetValues(typeof(EGrupo));

            chklstDelitosRegistrados.DataSource = Enum.GetValues(typeof(ETipoCausaIngreso));

            errorEnCampo = new ErrorProvider();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se Validan los campos
                this.VaciarRegistrosDeError();
                this.ValidarCampos();

                List<ETipoCausaIngreso> listadoDeDelitos = this.ObtenerCausaDeIngreso();

                // Se agrega el usuario y se intenga agregar.
                Usuario usuario = new Usuario(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                                                DateTime.Now, (EGrupo)cmbGrupo.SelectedItem, int.Parse(txtNumeroDeDenuncias.Text),
                                                int.Parse(txtTelefono.Text), listadoDeDelitos);
                if (!UsuarioControlador.AgregarUsuario(usuario))
                {
                    MessageBox.Show("El usuario ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (CampoInvalido error)
            {
                Control control = Controls.Find(error.NombreCampo, true)[0];
                errorEnCampo.SetError(control, error.Message);
            }
        }
        private void ValidarVacio(string valorCampo, string nombreControl)
        {
            if (valorCampo == string.Empty)
            {
                throw new CampoInvalido("Los campos obligatorios (*) no pueden estar vacios.", nombreControl);
            }
        }

        private void VaciarRegistrosDeError()
        {
            // Vacia los registros de error
            errorEnCampo.SetError(txtNombre,"");
            errorEnCampo.SetError(txtApellido,"");
            errorEnCampo.SetError(txtDni,"");
            errorEnCampo.SetError(txtNumeroDeDenuncias,"");
            errorEnCampo.SetError(txtTelefono,"");
        }

        private void ValidarCampos()
        {
            // Se validan campos no vacios
            this.ValidarVacio(txtNombre.Text.Trim(), "txtNombre");
            this.ValidarVacio(txtApellido.Text.Trim(), "txtApellido");
            this.ValidarVacio(txtDni.Text.Trim(), "txtDni");
            this.ValidarVacio(txtNumeroDeDenuncias.Text.Trim(), "txtNumeroDeDenuncias");
            this.ValidarVacio(txtTelefono.Text.Trim(), "txtTelefono");
            this.ValidarVacio(txtFechaIngreso.Text.Trim(), "txtFechaIngreso");
            this.ValidarVacio(txtNumeroDeDenuncias.Text.Trim(), "txtNumeroDeDenuncias");

            // Se validan valores de cada campo
            // Valida que el campo de nombre tenga solo letras
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZñÑ]+$"))
            {
                throw new CampoInvalido("txtNombre", "El nombre puede contener sólo letras (mayuscula y/o minuscula)");
            }
            // Valida que el campo de apellido tenga solo letras
            if (!Regex.IsMatch(txtApellido.Text, @"^[a-zA-ZñÑ]+$"))
            {
                throw new CampoInvalido("txtApellido", "El apellido puede contener sólo letras (mayuscula y/o minuscula)");
            }
            // Valida que el campo de Dni sea solo numerico y tenga un largo entre 6 y 8
            if (!Regex.IsMatch(txtDni.Text, @"^[0-9]+$") && (txtDni.Text.Length >8 || txtDni.Text.Length < 6))
            {
                throw new CampoInvalido("txtDni", "El Dni puede contener sólo puede contener números y debe tener un largo entre 6 y 8");
            }
            // Valida que el campo Numero De Denuncias sea solo numerico 
            if (!Regex.IsMatch(txtNumeroDeDenuncias.Text, @"^[0-9]+$"))
            {
                throw new CampoInvalido("txtNumeroDeDenuncias", "El Dni puede contener sólo puede contener números y debe tener un largo entre 6 y 8");
            }
            // Valida que el campo de telefono sea solo numerico y tenga un largo de 10
            if (!Regex.IsMatch(txtTelefono.Text, @"^[0-9]+$") && txtTelefono.Text.Length != 10)
            {
                throw new CampoInvalido("txtTelefono", "El Teléfono puede contener sólo puede contener números y debe tener un largo de 10");
            }
        }

        private List<ETipoCausaIngreso> ObtenerCausaDeIngreso()
        {
            List<ETipoCausaIngreso> listaRetorno = new List<ETipoCausaIngreso>();

            for (int i = 0; i < chklstDelitosRegistrados.CheckedItems.Count; i++)
            {
                listaRetorno.Add((ETipoCausaIngreso)chklstDelitosRegistrados.CheckedItems[i]);
            }
            return listaRetorno;
        }
    }
}
