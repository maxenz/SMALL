namespace FrbaCommerce.Comprar_Ofertar
{
    partial class ComprarOfertarForm
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
            this.dgvGrillaPublicaciones = new System.Windows.Forms.DataGridView();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.lblTotalPagina = new System.Windows.Forms.Label();
            this.llblPrimero = new System.Windows.Forms.LinkLabel();
            this.llblAnterior = new System.Windows.Forms.LinkLabel();
            this.lblDe = new System.Windows.Forms.Label();
            this.llblSiguiete = new System.Windows.Forms.LinkLabel();
            this.llblUltimo = new System.Windows.Forms.LinkLabel();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrillaPublicaciones
            // 
            this.dgvGrillaPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaPublicaciones.Location = new System.Drawing.Point(23, 111);
            this.dgvGrillaPublicaciones.Name = "dgvGrillaPublicaciones";
            this.dgvGrillaPublicaciones.Size = new System.Drawing.Size(633, 349);
            this.dgvGrillaPublicaciones.TabIndex = 0;
            this.dgvGrillaPublicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaPublicaciones_CellClick);
            // 
            // cmbRubros
            // 
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(90, 22);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(228, 21);
            this.cmbRubros.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(91, 53);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(227, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(19, 27);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(39, 13);
            this.lblRubro.TabIndex = 3;
            this.lblRubro.Text = "Rubro:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(479, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(281, 503);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(17, 472);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(10, 13);
            this.lblCantidadTotal.TabIndex = 7;
            this.lblCantidadTotal.Text = ".";
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Location = new System.Drawing.Point(505, 472);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(10, 13);
            this.lblPaginaActual.TabIndex = 8;
            this.lblPaginaActual.Text = ".";
            // 
            // lblTotalPagina
            // 
            this.lblTotalPagina.AutoSize = true;
            this.lblTotalPagina.Location = new System.Drawing.Point(567, 472);
            this.lblTotalPagina.Name = "lblTotalPagina";
            this.lblTotalPagina.Size = new System.Drawing.Size(10, 13);
            this.lblTotalPagina.TabIndex = 9;
            this.lblTotalPagina.Text = ".";
            // 
            // llblPrimero
            // 
            this.llblPrimero.AutoSize = true;
            this.llblPrimero.Location = new System.Drawing.Point(224, 472);
            this.llblPrimero.Name = "llblPrimero";
            this.llblPrimero.Size = new System.Drawing.Size(42, 13);
            this.llblPrimero.TabIndex = 10;
            this.llblPrimero.TabStop = true;
            this.llblPrimero.Text = "Primero";
            this.llblPrimero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPrimero_LinkClicked);
            // 
            // llblAnterior
            // 
            this.llblAnterior.AutoSize = true;
            this.llblAnterior.Location = new System.Drawing.Point(274, 472);
            this.llblAnterior.Name = "llblAnterior";
            this.llblAnterior.Size = new System.Drawing.Size(43, 13);
            this.llblAnterior.TabIndex = 11;
            this.llblAnterior.TabStop = true;
            this.llblAnterior.Text = "Anterior";
            this.llblAnterior.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAnterior_LinkClicked);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(533, 472);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 12;
            this.lblDe.Text = "De";
            // 
            // llblSiguiete
            // 
            this.llblSiguiete.AutoSize = true;
            this.llblSiguiete.Location = new System.Drawing.Point(331, 472);
            this.llblSiguiete.Name = "llblSiguiete";
            this.llblSiguiete.Size = new System.Drawing.Size(51, 13);
            this.llblSiguiete.TabIndex = 13;
            this.llblSiguiete.TabStop = true;
            this.llblSiguiete.Text = "Siguiente";
            this.llblSiguiete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSiguiete_LinkClicked);
            // 
            // llblUltimo
            // 
            this.llblUltimo.AutoSize = true;
            this.llblUltimo.Location = new System.Drawing.Point(388, 472);
            this.llblUltimo.Name = "llblUltimo";
            this.llblUltimo.Size = new System.Drawing.Size(36, 13);
            this.llblUltimo.TabIndex = 14;
            this.llblUltimo.TabStop = true;
            this.llblUltimo.Text = "Ultimo";
            this.llblUltimo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUltimo_LinkClicked);
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(602, 472);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(45, 13);
            this.lblPaginas.TabIndex = 15;
            this.lblPaginas.Text = "Paginas";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 78);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione los Criterios de Búsqueda:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 406);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione la Publicacion Deseada:";
            // 
            // ComprarOfertarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 538);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.llblUltimo);
            this.Controls.Add(this.llblSiguiete);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.llblAnterior);
            this.Controls.Add(this.llblPrimero);
            this.Controls.Add(this.lblTotalPagina);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbRubros);
            this.Controls.Add(this.dgvGrillaPublicaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ComprarOfertarForm";
            this.Text = "Comprar / Ofertar";
            this.Load += new System.EventHandler(this.ComprarOfertarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrillaPublicaciones;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Label lblTotalPagina;
        private System.Windows.Forms.LinkLabel llblPrimero;
        private System.Windows.Forms.LinkLabel llblAnterior;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.LinkLabel llblSiguiete;
        private System.Windows.Forms.LinkLabel llblUltimo;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}