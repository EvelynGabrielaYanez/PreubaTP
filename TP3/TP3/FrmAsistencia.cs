using EntidadesAsociacion;
using EntidadesAsociacion.Controladores;
using EntidadesAsociacion.Excepciones.Usuarios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static EntidadesAsociacion.Enumerados;

namespace TP3
{
    public partial class FrmAsistencia : Form
    {
        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            cmbGrupo.DataSource = Enum.GetValues(typeof(EGrupo));
            cmbGrupo.SelectedIndex = (int)Asociacion.ObtenerGrupoPorFecha();
            dtpFechaFiltro.Value = DateTime.Now;
            this.ActualizarDataGrid();
            chbFecha.Checked = false;
            dtpFechaFiltro.Enabled = false;
        }

        private void ActualizarDataGrid()
        {
            if (chbFecha.Checked)
            {
                dgvAsistencia.DataSource = AsistenciaControlador.FiltrarAsistencias(dtpFechaFiltro.Value, dtpFechaFiltro.Value, (EGrupo)cmbGrupo.SelectedItem);
            }
            else
            {
                dgvAsistencia.DataSource = AsistenciaControlador.FiltrarPorGrupo((EGrupo)cmbGrupo.SelectedItem);
            }
        }

        private void cmbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
        }

        private void dtpFechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            FrmImportarAsistencias frmImportarAsistencias = new FrmImportarAsistencias();
            frmImportarAsistencias.ShowDialog();
        }

        private void btnExportarAsistencias_Click(object sender, EventArgs e)
        {
            //Selecciona el listado de asistencias seleccionado
            List<Asistencia> listadoDeAsistencia = (List<Asistencia>)dgvAsistencia.DataSource;

            FrmExportarAsistencia frmExportarCsvTxt = new FrmExportarAsistencia(listadoDeAsistencia,(EGrupo)cmbGrupo.SelectedItem,dtpFechaFiltro.Value);
            frmExportarCsvTxt.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAsistenciaAlta frmAsistencia = new FrmAsistenciaAlta();
            this.Hide();
            frmAsistencia.ShowDialog();
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = this.ObtenerDatosDeSeleccion();

            if (asistencia is not null)
            {
                FrmAsistenciaEditar frmEditarAlta = new FrmAsistenciaEditar(asistencia);
                this.Hide();
                frmEditarAlta.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No hay ningun registro seleccionado para editar", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Obtiene los datos seleccionados del datagred y retorna la
        /// la asistencia seleccionada
        /// </summary>
        /// <returns>Retorna la instancia de la asistencia selecionada. En caso de no haber seleccion retorna null</returns>
        private Asistencia ObtenerDatosDeSeleccion()
        {
            Asistencia asistencia = null;
            try
            {

                // En caso de no haber ninguna fila le asigno -1
                int indiceFila = dgvAsistencia.CurrentRow is null ? -1 : dgvAsistencia.CurrentRow.Index;
                if (indiceFila >= 0)
                {
                    DataGridViewRow fila = dgvAsistencia.Rows[indiceFila];
                    int dni = (int)fila.Cells["DNIUsuario"].Value;
                    DateTime fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value.ToString());
                    EGrupo grupo = (EGrupo)fila.Cells["Grupo"].Value;
                    ETipoAsistencia presente = (ETipoAsistencia)fila.Cells["Presente"].Value;
                    asistencia = new Asistencia(UsuarioControlador.BuscarUsuario(dni), fecha, grupo, presente);
                }
            } catch (UsuarioNoEncontrado error)
            {
                MessageBox.Show(error.Message, "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return asistencia;
        }

        private void chbFecha_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbFecha.Checked)
                dtpFechaFiltro.Enabled = true;
            else
                dtpFechaFiltro.Enabled = false;

            this.ActualizarDataGrid();
        }
    }
}
