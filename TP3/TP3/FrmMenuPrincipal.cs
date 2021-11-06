using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using System;
using System.Windows.Forms;
using TP3.UsuarioABM;

namespace TP3
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tmrHoraActual_Tick(object sender, EventArgs e)
        {
            DateTime fechaHoraActual = DateTime.Now;
            lblHoraActual.Text = fechaHoraActual.ToString("hh:mm:ss");
            lblFecha.Text = fechaHoraActual.ToString("dd/MM/yyyy");
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.tmrHoraActual.Enabled = true;
            this.RecargarListado();
            lblGrupoActivo.Text = Asociacion.ObtenerGrupoPorFecha().ToString();
        }

        private void tsmiAltaUsuario_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            this.Hide();
            if (frmAltaUsuario.ShowDialog() == DialogResult.OK)
            {
                this.RecargarListado();
            }
            this.Show();
        }
        private void RecargarListado()
        {
            DateTime fechaActual = DateTime.Now;
            dgvAsistenciaDelDia.DataSource = AsistenciaControlador.FiltrarAsistencias(fechaActual.Date, fechaActual.Date, Asociacion.ObtenerGrupoPorFecha());
        }

        private void tsmiAsistencias_Click(object sender, EventArgs e)
        {
            this.tmrHoraActual.Stop();
            FrmAsistencia frmAsistencia = new FrmAsistencia();
            this.Hide();
            frmAsistencia.ShowDialog();
            this.Show();
            this.tmrHoraActual.Start();
        }

        private void tsmiReportesFiltros_Click(object sender, EventArgs e)
        {
            this.tmrHoraActual.Stop();
            FrmReportesPorFiltro frmReportes = new FrmReportesPorFiltro();
            this.Hide();
            frmReportes.ShowDialog();
            this.Show();
            this.tmrHoraActual.Start();
        }

        private void tsmiReportesPorcentajes_Click(object sender, EventArgs e)
        {
            this.tmrHoraActual.Stop();
            FrmReportesPorPorcentaje frmReportes = new FrmReportesPorPorcentaje();
            this.Hide();
            frmReportes.ShowDialog();
            this.Show();
            this.tmrHoraActual.Start();
        }

        private void tsmiListados_Click(object sender, EventArgs e)
        {
            this.tmrHoraActual.Stop();
            FrmListadoUsuarios frmReportes = new FrmListadoUsuarios();
            this.Hide();
            frmReportes.ShowDialog();
            this.Show();
            this.tmrHoraActual.Start();
        }
    }
}
