
namespace TP3
{
    partial class FrmRegistros
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
            this.dgvRegitros = new System.Windows.Forms.DataGridView();
            this.cmbTipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegitros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegitros
            // 
            this.dgvRegitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegitros.Location = new System.Drawing.Point(27, 59);
            this.dgvRegitros.Name = "dgvRegitros";
            this.dgvRegitros.RowTemplate.Height = 25;
            this.dgvRegitros.Size = new System.Drawing.Size(495, 270);
            this.dgvRegitros.TabIndex = 0;
            // 
            // cmbTipoDeUsuario
            // 
            this.cmbTipoDeUsuario.FormattingEnabled = true;
            this.cmbTipoDeUsuario.Location = new System.Drawing.Point(398, 21);
            this.cmbTipoDeUsuario.Name = "cmbTipoDeUsuario";
            this.cmbTipoDeUsuario.Size = new System.Drawing.Size(124, 23);
            this.cmbTipoDeUsuario.TabIndex = 1;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Location = new System.Drawing.Point(280, 19);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(112, 25);
            this.lblTipoUsuario.TabIndex = 2;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            this.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 349);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.cmbTipoDeUsuario);
            this.Controls.Add(this.dgvRegitros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.FrmRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegitros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegitros;
        private System.Windows.Forms.ComboBox cmbTipoDeUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
    }
}