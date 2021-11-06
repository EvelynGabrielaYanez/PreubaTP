
namespace TP3
{
    partial class FrmReportesPorPorcentaje
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
            this.chbMeses = new System.Windows.Forms.CheckBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.nudIntervaloMeses = new System.Windows.Forms.NumericUpDown();
            this.nudIntervaloDenuncias = new System.Windows.Forms.NumericUpDown();
            this.chbDenuncias = new System.Windows.Forms.CheckBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.chbCausaDeIngreso = new System.Windows.Forms.CheckBox();
            this.chbTipoAsistencia = new System.Windows.Forms.CheckBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervaloMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervaloDenuncias)).BeginInit();
            this.SuspendLayout();
            // 
            // chbMeses
            // 
            this.chbMeses.AutoSize = true;
            this.chbMeses.Location = new System.Drawing.Point(240, 25);
            this.chbMeses.Name = "chbMeses";
            this.chbMeses.Size = new System.Drawing.Size(125, 19);
            this.chbMeses.TabIndex = 5;
            this.chbMeses.Text = "Intervalo De Meses";
            this.chbMeses.UseVisualStyleBackColor = true;
            this.chbMeses.CheckStateChanged += new System.EventHandler(this.chbMeses_CheckStateChanged);
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(30, 94);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowTemplate.Height = 25;
            this.dgvReporte.Size = new System.Drawing.Size(518, 252);
            this.dgvReporte.TabIndex = 6;
            // 
            // nudIntervaloMeses
            // 
            this.nudIntervaloMeses.Location = new System.Drawing.Point(371, 24);
            this.nudIntervaloMeses.Name = "nudIntervaloMeses";
            this.nudIntervaloMeses.Size = new System.Drawing.Size(40, 23);
            this.nudIntervaloMeses.TabIndex = 8;
            this.nudIntervaloMeses.ValueChanged += new System.EventHandler(this.nudIntervaloMeses_ValueChanged);
            // 
            // nudIntervaloDenuncias
            // 
            this.nudIntervaloDenuncias.Location = new System.Drawing.Point(182, 23);
            this.nudIntervaloDenuncias.Name = "nudIntervaloDenuncias";
            this.nudIntervaloDenuncias.Size = new System.Drawing.Size(40, 23);
            this.nudIntervaloDenuncias.TabIndex = 10;
            this.nudIntervaloDenuncias.ValueChanged += new System.EventHandler(this.nudIntervaloDenuncias_ValueChanged);
            // 
            // chbDenuncias
            // 
            this.chbDenuncias.AutoSize = true;
            this.chbDenuncias.Location = new System.Drawing.Point(30, 25);
            this.chbDenuncias.Name = "chbDenuncias";
            this.chbDenuncias.Size = new System.Drawing.Size(146, 19);
            this.chbDenuncias.TabIndex = 9;
            this.chbDenuncias.Text = "Intervalo de Denuncias";
            this.chbDenuncias.UseVisualStyleBackColor = true;
            this.chbDenuncias.CheckStateChanged += new System.EventHandler(this.chbDenuncias_CheckStateChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(441, 50);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(107, 29);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // chbCausaDeIngreso
            // 
            this.chbCausaDeIngreso.AutoSize = true;
            this.chbCausaDeIngreso.Location = new System.Drawing.Point(432, 23);
            this.chbCausaDeIngreso.Name = "chbCausaDeIngreso";
            this.chbCausaDeIngreso.Size = new System.Drawing.Size(116, 19);
            this.chbCausaDeIngreso.TabIndex = 15;
            this.chbCausaDeIngreso.Text = "Causa de Ingreso";
            this.chbCausaDeIngreso.UseVisualStyleBackColor = true;
            this.chbCausaDeIngreso.CheckStateChanged += new System.EventHandler(this.chbCausaDeIngreso_CheckStateChanged);
            // 
            // chbTipoAsistencia
            // 
            this.chbTipoAsistencia.AutoSize = true;
            this.chbTipoAsistencia.Location = new System.Drawing.Point(30, 60);
            this.chbTipoAsistencia.Name = "chbTipoAsistencia";
            this.chbTipoAsistencia.Size = new System.Drawing.Size(79, 19);
            this.chbTipoAsistencia.TabIndex = 16;
            this.chbTipoAsistencia.Text = "Asistencia";
            this.chbTipoAsistencia.UseVisualStyleBackColor = true;
            this.chbTipoAsistencia.CheckStateChanged += new System.EventHandler(this.chbTipoAsistencia_CheckStateChanged);
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(130, 58);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(108, 23);
            this.cmbGrupo.TabIndex = 17;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // FrmReportesPorPorcentaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 372);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.chbTipoAsistencia);
            this.Controls.Add(this.chbCausaDeIngreso);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.nudIntervaloDenuncias);
            this.Controls.Add(this.chbDenuncias);
            this.Controls.Add(this.nudIntervaloMeses);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.chbMeses);
            this.Name = "FrmReportesPorPorcentaje";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportesPorPorcentaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervaloMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervaloDenuncias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chbMeses;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.NumericUpDown nudIntervaloMeses;
        private System.Windows.Forms.NumericUpDown nudIntervaloDenuncias;
        private System.Windows.Forms.CheckBox chbDenuncias;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.CheckBox chbCausaDeIngreso;
        private System.Windows.Forms.CheckBox chbTipoAsistencia;
        private System.Windows.Forms.ComboBox cmbGrupo;
    }
}