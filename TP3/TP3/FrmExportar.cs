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
    public partial class FrmExportar : Form
    {
        Reporte<Usuario> reportesFiltro;
        Reporte<RegistroPorcentaje> reportesPorcentaje;
        private FrmExportar()
        {
            InitializeComponent(); 
            this.reportesPorcentaje = null;
            this.reportesFiltro = null;
            DialogResult = DialogResult.Cancel;
        }
        public FrmExportar(Reporte<Usuario> reportesFiltro) : this()
        {
            this.reportesFiltro = reportesFiltro;
        }
        public FrmExportar(Reporte<RegistroPorcentaje> reportesPorcentaje) : this()
        {
            this.reportesPorcentaje = reportesPorcentaje;
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frmBuscadorCarpeta = new FolderBrowserDialog();

            if (frmBuscadorCarpeta.ShowDialog() == DialogResult.OK)
            {
                txtPathCarpeta.Text = frmBuscadorCarpeta.SelectedPath;
            }
        }

        private void FrmExportar_Load(object sender, EventArgs e)
        {
            cmbTipoDeArchivo.DataSource = Enum.GetValues(typeof(ETipoExtension));
            txtPathCarpeta.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtNombreArchivo.Text = $"Reporte-{DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss")}";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                ETipoExtension extensionSeleccionada = (ETipoExtension)cmbTipoDeArchivo.SelectedItem;
                if (extensionSeleccionada == ETipoExtension.Txt || extensionSeleccionada == ETipoExtension.Csv)
                {
                    if (reportesFiltro is not null)
                    {
                        reportesFiltro.ExportarCsvTxt((ETipoExtension)cmbTipoDeArchivo.SelectedItem, txtNombreArchivo.Text, txtNuevaCarpeta.Text, txtPathCarpeta.Text);
                    }
                    else
                    {
                        reportesPorcentaje.ExportarCsvTxt((ETipoExtension)cmbTipoDeArchivo.SelectedItem, txtNombreArchivo.Text, txtNuevaCarpeta.Text, txtPathCarpeta.Text);
                    }
                }
                else
                {
                    if (reportesFiltro is not null)
                    {
                        reportesFiltro.SerializarXmlJson((ETipoExtension)cmbTipoDeArchivo.SelectedItem, txtNombreArchivo.Text, txtNuevaCarpeta.Text, txtPathCarpeta.Text);
                    }
                    else
                    {
                        reportesFiltro.SerializarXmlJson((ETipoExtension)cmbTipoDeArchivo.SelectedItem, txtNombreArchivo.Text, txtNuevaCarpeta.Text, txtPathCarpeta.Text);
                    }
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ErrorDeEscritura error)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendLine(error.Message);
                if (error.InnerException is not null)
                    errorMessage.AppendLine(error.InnerException.Message);

                MessageBox.Show(errorMessage.ToString(), "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
