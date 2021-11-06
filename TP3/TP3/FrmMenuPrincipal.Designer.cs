
namespace TP3
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnsMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiListados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAsistencias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportesFiltros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportesPorcentajes = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHoraActual = new System.Windows.Forms.Timer(this.components);
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.lblGrupoActivo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloGrupoActivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAsistenciaDelDia = new System.Windows.Forms.DataGridView();
            this.mnsMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaDelDia)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            this.mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListados,
            this.tsmiAsistencias,
            this.tsmiReportes});
            this.mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            this.mnsMenuPrincipal.Size = new System.Drawing.Size(559, 24);
            this.mnsMenuPrincipal.TabIndex = 0;
            this.mnsMenuPrincipal.Text = "menuStrip1";
            // 
            // tsmiListados
            // 
            this.tsmiListados.Name = "tsmiListados";
            this.tsmiListados.Size = new System.Drawing.Size(62, 20);
            this.tsmiListados.Text = "Listados";
            this.tsmiListados.Click += new System.EventHandler(this.tsmiListados_Click);
            // 
            // tsmiAsistencias
            // 
            this.tsmiAsistencias.Name = "tsmiAsistencias";
            this.tsmiAsistencias.Size = new System.Drawing.Size(77, 20);
            this.tsmiAsistencias.Text = "Asistencias";
            this.tsmiAsistencias.Click += new System.EventHandler(this.tsmiAsistencias_Click);
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReportesFiltros,
            this.tsmiReportesPorcentajes});
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(65, 20);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiReportesFiltros
            // 
            this.tsmiReportesFiltros.Name = "tsmiReportesFiltros";
            this.tsmiReportesFiltros.Size = new System.Drawing.Size(199, 22);
            this.tsmiReportesFiltros.Text = "Análisis por Filtros";
            this.tsmiReportesFiltros.Click += new System.EventHandler(this.tsmiReportesFiltros_Click);
            // 
            // tsmiReportesPorcentajes
            // 
            this.tsmiReportesPorcentajes.Name = "tsmiReportesPorcentajes";
            this.tsmiReportesPorcentajes.Size = new System.Drawing.Size(199, 22);
            this.tsmiReportesPorcentajes.Text = "Análisis por Porcentajes";
            this.tsmiReportesPorcentajes.Click += new System.EventHandler(this.tsmiReportesPorcentajes_Click);
            // 
            // tmrHoraActual
            // 
            this.tmrHoraActual.Tick += new System.EventHandler(this.tmrHoraActual_Tick);
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraActual.Location = new System.Drawing.Point(12, 203);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(176, 71);
            this.lblHoraActual.TabIndex = 1;
            this.lblHoraActual.Text = "00:00:00";
            this.lblHoraActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrupoActivo
            // 
            this.lblGrupoActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrupoActivo.Location = new System.Drawing.Point(448, 44);
            this.lblGrupoActivo.Name = "lblGrupoActivo";
            this.lblGrupoActivo.Size = new System.Drawing.Size(87, 19);
            this.lblGrupoActivo.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(12, 274);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(176, 36);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "DD/MM/AAAA";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP3.Properties.Resources.logoAsociacion;
            this.pictureBox1.Location = new System.Drawing.Point(22, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloGrupoActivo
            // 
            this.lblTituloGrupoActivo.AutoSize = true;
            this.lblTituloGrupoActivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloGrupoActivo.Location = new System.Drawing.Point(205, 44);
            this.lblTituloGrupoActivo.Name = "lblTituloGrupoActivo";
            this.lblTituloGrupoActivo.Size = new System.Drawing.Size(237, 19);
            this.lblTituloGrupoActivo.TabIndex = 5;
            this.lblTituloGrupoActivo.Text = "Grupo correspondiente a la fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Listado de usuarios correspondiente:";
            // 
            // dgvAsistenciaDelDia
            // 
            this.dgvAsistenciaDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaDelDia.Location = new System.Drawing.Point(205, 113);
            this.dgvAsistenciaDelDia.Name = "dgvAsistenciaDelDia";
            this.dgvAsistenciaDelDia.RowTemplate.Height = 25;
            this.dgvAsistenciaDelDia.Size = new System.Drawing.Size(330, 210);
            this.dgvAsistenciaDelDia.TabIndex = 7;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 344);
            this.Controls.Add(this.dgvAsistenciaDelDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTituloGrupoActivo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblGrupoActivo);
            this.Controls.Add(this.lblHoraActual);
            this.Controls.Add(this.mnsMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.mnsMenuPrincipal.ResumeLayout(false);
            this.mnsMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaDelDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiListados;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.Timer tmrHoraActual;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Label lblGrupoActivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloGrupoActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAsistencias;
        private System.Windows.Forms.DataGridView dgvAsistenciaDelDia;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportesFiltros;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportesPorcentajes;
    }
}