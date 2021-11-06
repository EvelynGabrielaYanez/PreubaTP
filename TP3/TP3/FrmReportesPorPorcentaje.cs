using EntidadesAsociacion.Controladores;
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
    public partial class FrmReportesPorPorcentaje : Form
    {
        public FrmReportesPorPorcentaje()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Reporte<RegistroPorcentaje> datosFiltrados = new Reporte<RegistroPorcentaje>();
            datosFiltrados.DatosReporte = new List<RegistroPorcentaje>((List<RegistroPorcentaje>)dgvReporte.DataSource);
            FrmExportar frmExportar = new FrmExportar(datosFiltrados);
            this.Hide();
            frmExportar.ShowDialog();
            this.Show();
        }

        private void FrmReportesPorPorcentaje_Load(object sender, EventArgs e)
        {
            nudIntervaloDenuncias.Value = 1;
            nudIntervaloMeses.Value = 1;
            chbDenuncias.Checked = true;
            chbMeses.Checked = false;
            chbCausaDeIngreso.Checked = false;
            nudIntervaloMeses.Enabled = false;
            chbTipoAsistencia.Checked = false;
            cmbGrupo.DataSource = Enum.GetValues(typeof(EGrupo));
        }

        private void CalcularReporte()
        {
            List<RegistroPorcentaje> resultado = new List<RegistroPorcentaje>();
            if (chbDenuncias.Checked)
            {
                resultado = UsuarioControlador.CalcularPorcentajePorDenuncias((int)nudIntervaloDenuncias.Value);
            }
            else if (chbMeses.Checked)
            {
                resultado = UsuarioControlador.CalcularPorcentajesPorMeses((int)nudIntervaloMeses.Value);
            } else if (chbCausaDeIngreso.Checked)
            {
                resultado = UsuarioControlador.CalcularPorcentajesPorCausaIngreso();
            } else if (chbTipoAsistencia.Checked)
            {
                resultado = AsistenciaControlador.CalcularPorcentaPorTipoAsistencia((EGrupo)cmbGrupo.SelectedItem);
            }
            dgvReporte.DataSource = resultado;
        }

        private void chbDenuncias_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbDenuncias.Checked)
            {
                nudIntervaloDenuncias.Enabled = true;
                nudIntervaloMeses.Enabled = false;
                chbCausaDeIngreso.Checked = false;
                chbMeses.Checked = false;
                chbTipoAsistencia.Checked = false;
                cmbGrupo.Enabled = false;
            }
            else
            {
                nudIntervaloDenuncias.Enabled = false;

            }
            this.CalcularReporte();
        }

        private void chbMeses_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbMeses.Checked)
            {
                nudIntervaloMeses.Enabled = true;
                nudIntervaloDenuncias.Enabled = false;
                chbCausaDeIngreso.Checked = false;
                chbDenuncias.Checked = false;
                chbTipoAsistencia.Checked = false;
                cmbGrupo.Enabled = false;
            }
            else
            {
                nudIntervaloMeses.Enabled = false;
            }
            this.CalcularReporte();
        }

        private void chbCausaDeIngreso_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbCausaDeIngreso.Checked)
            {
                chbMeses.Checked = false;
                chbDenuncias.Checked = false;
                nudIntervaloMeses.Enabled = false;
                nudIntervaloDenuncias.Enabled = false;
                chbTipoAsistencia.Checked = false;
                cmbGrupo.Enabled = false;
            }
            this.CalcularReporte();
        }

        private void chbTipoAsistencia_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbTipoAsistencia.Checked)
            {
                nudIntervaloMeses.Enabled = false;
                nudIntervaloDenuncias.Enabled = false;
                chbCausaDeIngreso.Checked = false;
                chbDenuncias.Checked = false;
                chbCausaDeIngreso.Checked = false;
                chbMeses.Checked = false;
                chbTipoAsistencia.Checked = true;
                cmbGrupo.Enabled = true;
            }
            else
            {
                cmbGrupo.Enabled = false;
            }
            this.CalcularReporte();
        }

        private void nudIntervaloDenuncias_ValueChanged(object sender, EventArgs e)
        {
            this.CalcularReporte();
        }

        private void nudIntervaloMeses_ValueChanged(object sender, EventArgs e)
        {
            this.CalcularReporte();
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CalcularReporte();
        }
    }
}
