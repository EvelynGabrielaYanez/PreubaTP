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
    public partial class FrmImportarAsistencias : Form
    {
        public FrmImportarAsistencias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@$"Ocurrio un error al importar el archivo {txtRutaArchivo.Text}\{txtNombreArchivo.Text}");
            try
            {
                ArchivosYSerializacionControlador.ImportarAsistenciasJsonXML(this.ObtenerExtension(), txtNombreArchivo.Text, txtRutaArchivo.Text);
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
            if (rbtJson.Checked)
            {
                return ETipoExtension.Json;
            }
            else
            {
                return ETipoExtension.Xml;
            }
        }

        private void FrmImportarAsistencias_Load(object sender, EventArgs e)
        {
            txtRutaArchivo.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtNombreArchivo.Text = "Asistencias";
            rbtXml.Checked = true;
        }
    }
}
