using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using EntidadesAsociacion.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static EntidadesAsociacion.Enumerados;

namespace TP3
{
    public partial class FrmReportesPorFiltro : Form
    {
        private List<Usuario> dataDeLaTabla;

        public FrmReportesPorFiltro()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            this.ReiniciarDataGrid();
            chbDenuncias.Checked = false;
            chbMotivoIngreso.Checked = false;
            chbFecha.Checked = false;
            nudDenunciasDesde.Enabled = false; 
            nudDenunciasHasta.Enabled = false;
            dtpFechaDesde.Enabled = false;
            dtpFechaDesde.Enabled = false;
            chblstMotivosDeIngreso.Enabled = false;
            this.CargarMotivosDeIngreso();
        }
        private void CargarMotivosDeIngreso()
        {
            foreach (ETipoCausaIngreso causa in Enum.GetValues(typeof(ETipoCausaIngreso)))
            {
                chblstMotivosDeIngreso.Items.Add(causa);
            }
        }
        private void ReiniciarDataGrid() {

            Reporte<Usuario> datosFiltrados = new Reporte<Usuario>();

            foreach (Usuario usuario in Asociacion.ListaUsuarios)
            { 
                datosFiltrados.DatosReporte.Add(usuario);
            }
            dataDeLaTabla = datosFiltrados.DatosReporte;

            dgvReporte.DataSource = datosFiltrados.DatosReporte;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Reporte<Usuario> datosFiltrados = new Reporte<Usuario>();
            datosFiltrados.DatosReporte = new List<Usuario>((List<Usuario>)dgvReporte.DataSource);
            FrmExportar frmExportar = new FrmExportar(datosFiltrados);
            this.Hide();
            frmExportar.ShowDialog();
            this.Show();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(chbFecha.Checked)
            {
                dataDeLaTabla = UsuarioControlador.FiltrarPorFecha(dtpFechaDesde.Value.Date, dtpFechaHasta.Value.Date, dataDeLaTabla);
            }

            if (chbDenuncias.Checked)
            {
                dataDeLaTabla = UsuarioControlador.FiltrarCantidadDenuncias((int)nudDenunciasDesde.Value, (int)nudDenunciasHasta.Value, dataDeLaTabla);
            }

            List<ETipoCausaIngreso> causasSeleccionadas = ObtenerMotivosDeIngresoSeleccionados();
            if (chbMotivoIngreso.Checked && causasSeleccionadas.Count > 0)
            {
                dataDeLaTabla = UsuarioControlador.FiltrarCausaDeIngreso(causasSeleccionadas, dataDeLaTabla);
            }

            dgvReporte.DataSource = dataDeLaTabla;
        }

        private List<ETipoCausaIngreso> ObtenerMotivosDeIngresoSeleccionados()
        {
            List<ETipoCausaIngreso> listadoRetorno = new List<ETipoCausaIngreso>();
            for (int i = 0; i < chblstMotivosDeIngreso.CheckedItems.Count; i++)
            {
                listadoRetorno.Add((ETipoCausaIngreso)chblstMotivosDeIngreso.CheckedItems[i]);
            }
            return listadoRetorno;
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            this.ReiniciarDataGrid();
        }

        private void chbMotivoIngreso_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbMotivoIngreso.Checked)
            {
                chblstMotivosDeIngreso.Enabled = true;
            }
            else
            {
                chblstMotivosDeIngreso.Enabled = false;
            }
        }

        private void chbDenuncias_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbDenuncias.Checked)
            {
                nudDenunciasDesde.Enabled = true;
                nudDenunciasHasta.Enabled = true;
            }
            else
            {
                nudDenunciasDesde.Enabled = false;
                nudDenunciasHasta.Enabled = false;
            }
        }

        private void chbFecha_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbFecha.Checked)
            {
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
            else
            {
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
        }
    }
}
