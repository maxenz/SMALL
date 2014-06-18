namespace FrbaCommerce.Historial_Cliente
{
    partial class HistorialClienteForm
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
            this.gbxHistoriales = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboxHistoriales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.gbxHistoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxHistoriales
            // 
            this.gbxHistoriales.Controls.Add(this.btnVolver);
            this.gbxHistoriales.Controls.Add(this.btnConsultar);
            this.gbxHistoriales.Controls.Add(this.cboxHistoriales);
            this.gbxHistoriales.Controls.Add(this.label1);
            this.gbxHistoriales.Location = new System.Drawing.Point(13, 13);
            this.gbxHistoriales.Name = "gbxHistoriales";
            this.gbxHistoriales.Size = new System.Drawing.Size(582, 128);
            this.gbxHistoriales.TabIndex = 0;
            this.gbxHistoriales.TabStop = false;
            this.gbxHistoriales.Text = "Historiales";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(347, 78);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(134, 77);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboxHistoriales
            // 
            this.cboxHistoriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHistoriales.FormattingEnabled = true;
            this.cboxHistoriales.Items.AddRange(new object[] {
            "Historial de Compras",
            "Historial de Ofertas",
            "Historial de Calificaciones Otorgadas",
            "Historial de Calificaciones Recibidas"});
            this.cboxHistoriales.Location = new System.Drawing.Point(134, 28);
            this.cboxHistoriales.Name = "cboxHistoriales";
            this.cboxHistoriales.Size = new System.Drawing.Size(440, 21);
            this.cboxHistoriales.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija historial a consultar:";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 144);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(583, 328);
            this.dgvHistorial.TabIndex = 3;
            // 
            // HistorialClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 484);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.gbxHistoriales);
            this.Name = "HistorialClienteForm";
            this.Text = "Historial";
            this.gbxHistoriales.ResumeLayout(false);
            this.gbxHistoriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHistoriales;
        private System.Windows.Forms.ComboBox cboxHistoriales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}