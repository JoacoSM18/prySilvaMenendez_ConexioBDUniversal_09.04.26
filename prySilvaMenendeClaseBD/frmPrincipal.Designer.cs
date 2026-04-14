namespace prySilvaMenendeClaseBD
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTablas
            // 
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(170, 173);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(315, 21);
            this.cmbTablas.TabIndex = 1;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // cmbBD
            // 
            this.cmbBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Location = new System.Drawing.Point(171, 74);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(314, 21);
            this.cmbBD.TabIndex = 0;
            this.cmbBD.SelectedIndexChanged += new System.EventHandler(this.cmbBD_SelectedIndexChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 235);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.Size = new System.Drawing.Size(637, 280);
            this.dgvDatos.TabIndex = 2;
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Location = new System.Drawing.Point(168, 54);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(244, 17);
            this.lblBD.TabIndex = 3;
            this.lblBD.Text = "Elija una Base de Datos para Mostrar";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(168, 153);
            this.lblTabla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(187, 17);
            this.lblTabla.TabIndex = 4;
            this.lblTabla.Text = "Elija una Tabla para Mostrar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 541);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbBD);
            this.Controls.Add(this.cmbTablas);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.ComboBox cmbBD;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblTabla;
    }
}

