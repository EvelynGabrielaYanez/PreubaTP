using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using EntidadesAsociacion.Excepciones.Archivos;
using EntidadesAsociacion.Reportes;
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
    public partial class FrmExportarAsistencia : Form
    {
        List<Asistencia> listadoDeAsistencia;
        EGrupo grupo;
        DateTime fecha;

        public FrmExportarAsistencia(List<Asistencia> listadoDeAsistencia, EGrupo grupo, DateTime fecha)
        {
            InitializeComponent();
            this.listadoDeAsistencia = listadoDeAsistencia;
            this.grupo = grupo;
            this.fecha = fecha;
            DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frmBuscadorCarpeta = new FolderBrowserDialog();

            if (frmBuscadorCarpeta.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = frmBuscadorCarpeta.SelectedPath;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {
                ArchivosYSerializacionControlador.ExportarAsistenciaCsvTxt(this.listadoDeAsistencia, this.ObtenerExtension(), txtNombreArchivo.Text, txtRuta.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ErrorDeLectura error)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendLine(error.Message);
                if (error.InnerException is not null)
                    errorMessage.AppendLine(error.InnerException.Message);

                MessageBox.Show(errorMessage.ToString(), "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ETipoExtension ObtenerExtension()
        {
            if (rbtTxt.Checked)
            {
                return ETipoExtension.Txt;
            }
            else
            {
                return ETipoExtension.Csv;
            }
        }

        private void FrmExportarAsistencia_Load(object sender, EventArgs e)
        {
            txtRuta.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtNombreArchivo.Text = $"Asistencia-{this.grupo}-{fecha.ToString("ddmmyyyy")}";
            rbtTxt.Checked = true;
        }
    }
}
