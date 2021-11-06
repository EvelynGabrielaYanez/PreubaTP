
namespace TP3
{
    partial class FrmReportesPorFiltro
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
            this.chbFecha = new System.Windows.Forms.CheckBox();
            this.chbDenuncias = new System.Windows.Forms.CheckBox();
            this.chbMotivoIngreso = new System.Windows.Forms.CheckBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.chblstMotivosDeIngreso = new System.Windows.Forms.CheckedListBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblDenunciasHasta = new System.Windows.Forms.Label();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.nudDenunciasDesde = new System.Windows.Forms.NumericUpDown();
            this.nudDenunciasHasta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenunciasDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenunciasHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // chbFecha
            // 
            this.chbFecha.AutoSize = true;
            this.chbFecha.Location = new System.Drawing.Point(24, 25);
            this.chbFecha.Name = "chbFecha";
            this.chbFecha.Size = new System.Drawing.Size(153, 19);
            this.chbFecha.TabIndex = 0;
            this.chbFecha.Text = "Fecha de Ingreso Desde:";
            this.chbFecha.UseVisualStyleBackColor = true;
            this.chbFecha.CheckStateChanged += new System.EventHandler(this.chbFecha_CheckStateChanged);
            // 
            // chbDenuncias
            // 
            this.chbDenuncias.AutoSize = true;
            this.chbDenuncias.Location = new System.Drawing.Point(23, 53);
            this.chbDenuncias.Name = "chbDenuncias";
            this.chbDenuncias.Size = new System.Drawing.Size(186, 19);
            this.chbDenuncias.TabIndex = 1;
            this.chbDenuncias.Text = "Cantidad de Denuncias Desde:";
            this.chbDenuncias.UseVisualStyleBackColor = true;
            this.chbDenuncias.CheckStateChanged += new System.EventHandler(this.chbDenuncias_CheckStateChanged);
            // 
            // chbMotivoIngreso
            // 
            this.chbMotivoIngreso.AutoSize = true;
            this.chbMotivoIngreso.Location = new System.Drawing.Point(24, 81);
            this.chbMotivoIngreso.Name = "chbMotivoIngreso";
            this.chbMotivoIngreso.Size = new System.Drawing.Size(122, 19);
            this.chbMotivoIngreso.TabIndex = 2;
            this.chbMotivoIngreso.Text = "Motivo de Ingreso";
            this.chbMotivoIngreso.UseVisualStyleBackColor = true;
            this.chbMotivoIngreso.CheckStateChanged += new System.EventHandler(this.chbMotivoIngreso_CheckStateChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(205, 20);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(141, 23);
            this.dtpFechaDesde.TabIndex = 5;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Location = new System.Drawing.Point(352, 22);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(133, 22);
            this.lblFechaHasta.TabIndex = 6;
            this.lblFechaHasta.Text = "Fecha de Ingreso Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(515, 21);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(141, 23);
            this.dtpFechaHasta.TabIndex = 7;
            // 
            // chblstMotivosDeIngreso
            // 
            this.chblstMotivosDeIngreso.FormattingEnabled = true;
            this.chblstMotivosDeIngreso.Location = new System.Drawing.Point(165, 81);
            this.chblstMotivosDeIngreso.Name = "chblstMotivosDeIngreso";
            this.chblstMotivosDeIngreso.Size = new System.Drawing.Size(342, 58);
            this.chblstMotivosDeIngreso.TabIndex = 11;
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(23, 175);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowTemplate.Height = 25;
            this.dgvReporte.Size = new System.Drawing.Size(633, 287);
            this.dgvReporte.TabIndex = 12;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(23, 129);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(39, 40);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "button1";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblDenunciasHasta
            // 
            this.lblDenunciasHasta.Location = new System.Drawing.Point(352, 52);
            this.lblDenunciasHasta.Name = "lblDenunciasHasta";
            this.lblDenunciasHasta.Size = new System.Drawing.Size(168, 22);
            this.lblDenunciasHasta.TabIndex = 14;
            this.lblDenunciasHasta.Text = "Cantidad de Denuncias Hasta:";
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(513, 81);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(143, 25);
            this.btnQuitarFiltro.TabIndex = 15;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(513, 114);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(143, 25);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // nudDenunciasDesde
            // 
            this.nudDenunciasDesde.Location = new System.Drawing.Point(205, 52);
            this.nudDenunciasDesde.Name = "nudDenunciasDesde";
            this.nudDenunciasDesde.Size = new System.Drawing.Size(140, 23);
            this.nudDenunciasDesde.TabIndex = 17;
            // 
            // nudDenunciasHasta
            // 
            this.nudDenunciasHasta.Location = new System.Drawing.Point(516, 49);
            this.nudDenunciasHasta.Name = "nudDenunciasHasta";
            this.nudDenunciasHasta.Size = new System.Drawing.Size(140, 23);
            this.nudDenunciasHasta.TabIndex = 18;
            // 
            // FrmReportesPorFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 483);
            this.Controls.Add(this.nudDenunciasHasta);
            this.Controls.Add(this.nudDenunciasDesde);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.lblDenunciasHasta);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.chblstMotivosDeIngreso);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.chbMotivoIngreso);
            this.Controls.Add(this.chbDenuncias);
            this.Controls.Add(this.chbFecha);
            this.Name = "FrmReportesPorFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenunciasDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenunciasHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbFecha;
        private System.Windows.Forms.CheckBox chbDenuncias;
        private System.Windows.Forms.CheckBox chbMotivoIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.CheckedListBox chblstMotivosDeIngreso;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblDenunciasHasta;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.NumericUpDown nudDenunciasDesde;
        private System.Windows.Forms.NumericUpDown nudDenunciasHasta;
    }
}