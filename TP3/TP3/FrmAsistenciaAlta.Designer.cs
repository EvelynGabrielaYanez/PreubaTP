
namespace TP3
{
    partial class FrmAsistenciaAlta
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
            this.lblDniUsuario = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoAsistencia = new System.Windows.Forms.ComboBox();
            this.lblTipoAsistencia = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDniUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDniUsuario
            // 
            this.lblDniUsuario.AutoSize = true;
            this.lblDniUsuario.Location = new System.Drawing.Point(25, 24);
            this.lblDniUsuario.Name = "lblDniUsuario";
            this.lblDniUsuario.Size = new System.Drawing.Size(70, 15);
            this.lblDniUsuario.TabIndex = 1;
            this.lblDniUsuario.Text = "DNI Usuario";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(132, 59);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(161, 23);
            this.dtpFecha.TabIndex = 2;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(133, 100);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(161, 23);
            this.cmbGrupo.TabIndex = 3;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(25, 103);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(40, 15);
            this.lblGrupo.TabIndex = 4;
            this.lblGrupo.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha";
            // 
            // cmbTipoAsistencia
            // 
            this.cmbTipoAsistencia.FormattingEnabled = true;
            this.cmbTipoAsistencia.Location = new System.Drawing.Point(132, 139);
            this.cmbTipoAsistencia.Name = "cmbTipoAsistencia";
            this.cmbTipoAsistencia.Size = new System.Drawing.Size(161, 23);
            this.cmbTipoAsistencia.TabIndex = 6;
            // 
            // lblTipoAsistencia
            // 
            this.lblTipoAsistencia.AutoSize = true;
            this.lblTipoAsistencia.Location = new System.Drawing.Point(25, 137);
            this.lblTipoAsistencia.Name = "lblTipoAsistencia";
            this.lblTipoAsistencia.Size = new System.Drawing.Size(55, 15);
            this.lblTipoAsistencia.TabIndex = 7;
            this.lblTipoAsistencia.Text = "Presente:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(25, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(167, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 29);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDniUsuario
            // 
            this.txtDniUsuario.Location = new System.Drawing.Point(132, 21);
            this.txtDniUsuario.Name = "txtDniUsuario";
            this.txtDniUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtDniUsuario.TabIndex = 10;
            this.txtDniUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtDniUsuario_Validating);
            // 
            // FrmAsistenciaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 233);
            this.Controls.Add(this.txtDniUsuario);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoAsistencia);
            this.Controls.Add(this.cmbTipoAsistencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDniUsuario);
            this.Name = "FrmAsistenciaAlta";
            this.Text = "Registar Asistencia";
            this.Load += new System.EventHandler(this.FrmAsistenciaAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDniUsuario;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoAsistencia;
        protected System.Windows.Forms.TextBox txtDniUsuario;
        protected System.Windows.Forms.DateTimePicker dtpFecha;
        protected System.Windows.Forms.ComboBox cmbGrupo;
        protected System.Windows.Forms.ComboBox cmbTipoAsistencia;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnAceptar;
    }
}