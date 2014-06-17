namespace FrbaCommerce.Abm_Empresa
{
    partial class AbmEmpresaForm
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
            this.bAlta = new System.Windows.Forms.Button();
            this.bModificacion = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAlta
            // 
            this.bAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bAlta.Location = new System.Drawing.Point(42, 107);
            this.bAlta.Name = "bAlta";
            this.bAlta.Size = new System.Drawing.Size(166, 63);
            this.bAlta.TabIndex = 0;
            this.bAlta.Text = "Alta";
            this.bAlta.UseVisualStyleBackColor = true;
            this.bAlta.Click += new System.EventHandler(this.bAlta_Click);
            // 
            // bModificacion
            // 
            this.bModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bModificacion.Location = new System.Drawing.Point(42, 176);
            this.bModificacion.Name = "bModificacion";
            this.bModificacion.Size = new System.Drawing.Size(166, 63);
            this.bModificacion.TabIndex = 1;
            this.bModificacion.Text = "Modificacion/Baja";
            this.bModificacion.UseVisualStyleBackColor = true;
            this.bModificacion.Click += new System.EventHandler(this.bModificacion_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitulo.Location = new System.Drawing.Point(36, 25);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(187, 31);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "ABM Empresa";
            // 
            // AbmEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 283);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.bModificacion);
            this.Controls.Add(this.bAlta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AbmEmpresaForm";
            this.Text = "ABM de Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AbmEmpresaForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAlta;
        private System.Windows.Forms.Button bModificacion;
        private System.Windows.Forms.Label lbTitulo;
    }
}