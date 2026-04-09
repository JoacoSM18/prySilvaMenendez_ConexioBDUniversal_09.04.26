namespace prySilvaMenendeClaseBD
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // cmbTablas
            // 
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(178, 214);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(221, 21);
            this.cmbTablas.TabIndex = 0;
            // 
            // cmbBD
            // 
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Location = new System.Drawing.Point(178, 100);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(221, 21);
            this.cmbBD.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.cmbBD);
            this.Controls.Add(this.cmbTablas);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.ComboBox cmbBD;
    }
}

