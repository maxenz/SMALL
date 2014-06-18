namespace FrbaCommerce.Editar_Publicacion
{
    partial class SeleccionPublicacionForm
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
            this.gboxPublicaciones = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.gboxPublicaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxPublicaciones
            // 
            this.gboxPublicaciones.Controls.Add(this.dgvHistorial);
            this.gboxPublicaciones.Location = new System.Drawing.Point(13, 13);
            this.gboxPublicaciones.Name = "gboxPublicaciones";
            this.gboxPublicaciones.Size = new System.Drawing.Size(654, 463);
            this.gboxPublicaciones.TabIndex = 0;
            this.gboxPublicaciones.TabStop = false;
            this.gboxPublicaciones.Text = "Doble click a la publicación que desea editar:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(300, 482);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.dgvHistorial.Location = new System.Drawing.Point(6, 19);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(642, 438);
            this.dgvHistorial.TabIndex = 4;
            this.dgvHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellDoubleClick);
            // 
            // SeleccionPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 533);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gboxPublicaciones);
            this.Name = "SeleccionPublicacion";
            this.Text = "Publicaciones a Editar";
            this.Load += new System.EventHandler(this.SeleccionPublicacion_Load);
            this.gboxPublicaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPublicaciones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}