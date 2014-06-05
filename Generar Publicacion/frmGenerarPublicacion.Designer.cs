namespace FrbaCommerce.Generar_Publicacion
{
    partial class frmGenerarPublicacion
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
            this.components = new System.ComponentModel.Container();
            this.gpGenerarPublicacion = new System.Windows.Forms.GroupBox();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.lblValorInicialSubasta = new System.Windows.Forms.Label();
            this.txtValorInicialSubasta = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstadoPublicacion = new System.Windows.Forms.ComboBox();
            this.lstBoxRubros = new System.Windows.Forms.ListBox();
            this.lblRubros = new System.Windows.Forms.Label();
            this.txtVencimientoPublicacion = new System.Windows.Forms.TextBox();
            this.btnGenerarPublicacion = new System.Windows.Forms.Button();
            this.chkSePermitePreguntas = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpInicioPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblVisibilidad = new System.Windows.Forms.Label();
            this.cmbVisibilidadPublicacion = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescPublicacion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodPublicacion = new System.Windows.Forms.TextBox();
            this.lblTipoPublicacion = new System.Windows.Forms.Label();
            this.cmbTipoPublicacion = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpGenerarPublicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpGenerarPublicacion
            // 
            this.gpGenerarPublicacion.Controls.Add(this.btnLimpiarForm);
            this.gpGenerarPublicacion.Controls.Add(this.lblValorInicialSubasta);
            this.gpGenerarPublicacion.Controls.Add(this.txtValorInicialSubasta);
            this.gpGenerarPublicacion.Controls.Add(this.textBox1);
            this.gpGenerarPublicacion.Controls.Add(this.lblUsuario);
            this.gpGenerarPublicacion.Controls.Add(this.label10);
            this.gpGenerarPublicacion.Controls.Add(this.cmbEstadoPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.lstBoxRubros);
            this.gpGenerarPublicacion.Controls.Add(this.lblRubros);
            this.gpGenerarPublicacion.Controls.Add(this.txtVencimientoPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.btnGenerarPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.chkSePermitePreguntas);
            this.gpGenerarPublicacion.Controls.Add(this.txtPrecio);
            this.gpGenerarPublicacion.Controls.Add(this.lblPrecioUnitario);
            this.gpGenerarPublicacion.Controls.Add(this.lblFechaInicio);
            this.gpGenerarPublicacion.Controls.Add(this.lblFechaVencimiento);
            this.gpGenerarPublicacion.Controls.Add(this.dtpInicioPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.lblVisibilidad);
            this.gpGenerarPublicacion.Controls.Add(this.cmbVisibilidadPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.lblStock);
            this.gpGenerarPublicacion.Controls.Add(this.txtStock);
            this.gpGenerarPublicacion.Controls.Add(this.lblDescripcion);
            this.gpGenerarPublicacion.Controls.Add(this.txtDescPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.lblCodigo);
            this.gpGenerarPublicacion.Controls.Add(this.txtCodPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.lblTipoPublicacion);
            this.gpGenerarPublicacion.Controls.Add(this.cmbTipoPublicacion);
            this.gpGenerarPublicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpGenerarPublicacion.Location = new System.Drawing.Point(0, 0);
            this.gpGenerarPublicacion.Name = "gpGenerarPublicacion";
            this.gpGenerarPublicacion.Size = new System.Drawing.Size(520, 203);
            this.gpGenerarPublicacion.TabIndex = 0;
            this.gpGenerarPublicacion.TabStop = false;
            this.gpGenerarPublicacion.Text = "Datos Principales";
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Location = new System.Drawing.Point(15, 174);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(109, 23);
            this.btnLimpiarForm.TabIndex = 31;
            this.btnLimpiarForm.Text = "Limpiar";
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // lblValorInicialSubasta
            // 
            this.lblValorInicialSubasta.AutoSize = true;
            this.lblValorInicialSubasta.Location = new System.Drawing.Point(110, 120);
            this.lblValorInicialSubasta.Name = "lblValorInicialSubasta";
            this.lblValorInicialSubasta.Size = new System.Drawing.Size(65, 13);
            this.lblValorInicialSubasta.TabIndex = 30;
            this.lblValorInicialSubasta.Text = "V.I. Subasta";
            // 
            // txtValorInicialSubasta
            // 
            this.txtValorInicialSubasta.Location = new System.Drawing.Point(110, 136);
            this.txtValorInicialSubasta.Name = "txtValorInicialSubasta";
            this.txtValorInicialSubasta.ReadOnly = true;
            this.txtValorInicialSubasta.Size = new System.Drawing.Size(60, 20);
            this.txtValorInicialSubasta.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "MPOGGIO";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(285, 119);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 27;
            this.lblUsuario.Text = "Usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Estado";
            // 
            // cmbEstadoPublicacion
            // 
            this.cmbEstadoPublicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPublicacion.FormattingEnabled = true;
            this.cmbEstadoPublicacion.Location = new System.Drawing.Point(176, 135);
            this.cmbEstadoPublicacion.Name = "cmbEstadoPublicacion";
            this.cmbEstadoPublicacion.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoPublicacion.TabIndex = 25;
            // 
            // lstBoxRubros
            // 
            this.lstBoxRubros.FormattingEnabled = true;
            this.lstBoxRubros.Location = new System.Drawing.Point(409, 38);
            this.lstBoxRubros.Name = "lstBoxRubros";
            this.lstBoxRubros.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBoxRubros.Size = new System.Drawing.Size(107, 82);
            this.lstBoxRubros.TabIndex = 23;
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Location = new System.Drawing.Point(406, 22);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(41, 13);
            this.lblRubros.TabIndex = 24;
            this.lblRubros.Text = "Rubros";
            // 
            // txtVencimientoPublicacion
            // 
            this.txtVencimientoPublicacion.Location = new System.Drawing.Point(273, 87);
            this.txtVencimientoPublicacion.Name = "txtVencimientoPublicacion";
            this.txtVencimientoPublicacion.ReadOnly = true;
            this.txtVencimientoPublicacion.Size = new System.Drawing.Size(119, 20);
            this.txtVencimientoPublicacion.TabIndex = 22;
            // 
            // btnGenerarPublicacion
            // 
            this.btnGenerarPublicacion.Location = new System.Drawing.Point(399, 174);
            this.btnGenerarPublicacion.Name = "btnGenerarPublicacion";
            this.btnGenerarPublicacion.Size = new System.Drawing.Size(109, 23);
            this.btnGenerarPublicacion.TabIndex = 21;
            this.btnGenerarPublicacion.Text = "Guardar";
            this.btnGenerarPublicacion.UseVisualStyleBackColor = true;
            this.btnGenerarPublicacion.Click += new System.EventHandler(this.btnGenerarPublicacion_Click);
            // 
            // chkSePermitePreguntas
            // 
            this.chkSePermitePreguntas.AutoSize = true;
            this.chkSePermitePreguntas.Location = new System.Drawing.Point(382, 137);
            this.chkSePermitePreguntas.Name = "chkSePermitePreguntas";
            this.chkSePermitePreguntas.Size = new System.Drawing.Size(132, 17);
            this.chkSePermitePreguntas.TabIndex = 17;
            this.chkSePermitePreguntas.Text = "Se permiten preguntas";
            this.chkSePermitePreguntas.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(53, 135);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(51, 20);
            this.txtPrecio.TabIndex = 16;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(53, 119);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(51, 13);
            this.lblPrecioUnitario.TabIndex = 15;
            this.lblPrecioUnitario.Text = "Precio U.";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(139, 72);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.lblFechaInicio.TabIndex = 13;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(275, 72);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVencimiento.TabIndex = 12;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dtpInicioPublicacion
            // 
            this.dtpInicioPublicacion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInicioPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioPublicacion.Location = new System.Drawing.Point(142, 87);
            this.dtpInicioPublicacion.Name = "dtpInicioPublicacion";
            this.dtpInicioPublicacion.Size = new System.Drawing.Size(125, 20);
            this.dtpInicioPublicacion.TabIndex = 10;
            this.dtpInicioPublicacion.Value = new System.DateTime(2014, 6, 3, 0, 0, 0, 0);
            this.dtpInicioPublicacion.ValueChanged += new System.EventHandler(this.dtpInicioPublicacion_ValueChanged);
            // 
            // lblVisibilidad
            // 
            this.lblVisibilidad.AutoSize = true;
            this.lblVisibilidad.Location = new System.Drawing.Point(12, 72);
            this.lblVisibilidad.Name = "lblVisibilidad";
            this.lblVisibilidad.Size = new System.Drawing.Size(53, 13);
            this.lblVisibilidad.TabIndex = 9;
            this.lblVisibilidad.Text = "Visibilidad";
            // 
            // cmbVisibilidadPublicacion
            // 
            this.cmbVisibilidadPublicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisibilidadPublicacion.FormattingEnabled = true;
            this.cmbVisibilidadPublicacion.Location = new System.Drawing.Point(12, 86);
            this.cmbVisibilidadPublicacion.Name = "cmbVisibilidadPublicacion";
            this.cmbVisibilidadPublicacion.Size = new System.Drawing.Size(121, 21);
            this.cmbVisibilidadPublicacion.TabIndex = 8;
            this.cmbVisibilidadPublicacion.SelectedIndexChanged += new System.EventHandler(this.cmbVisibilidadPublicacion_SelectedIndexChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 119);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(15, 135);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(32, 20);
            this.txtStock.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(213, 22);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescPublicacion
            // 
            this.txtDescPublicacion.Location = new System.Drawing.Point(210, 38);
            this.txtDescPublicacion.Name = "txtDescPublicacion";
            this.txtDescPublicacion.Size = new System.Drawing.Size(182, 20);
            this.txtDescPublicacion.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(139, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodPublicacion
            // 
            this.txtCodPublicacion.Location = new System.Drawing.Point(139, 38);
            this.txtCodPublicacion.Name = "txtCodPublicacion";
            this.txtCodPublicacion.ReadOnly = true;
            this.txtCodPublicacion.Size = new System.Drawing.Size(65, 20);
            this.txtCodPublicacion.TabIndex = 2;
            // 
            // lblTipoPublicacion
            // 
            this.lblTipoPublicacion.AutoSize = true;
            this.lblTipoPublicacion.Location = new System.Drawing.Point(12, 22);
            this.lblTipoPublicacion.Name = "lblTipoPublicacion";
            this.lblTipoPublicacion.Size = new System.Drawing.Size(101, 13);
            this.lblTipoPublicacion.TabIndex = 1;
            this.lblTipoPublicacion.Text = "Tipo de Publicación";
            // 
            // cmbTipoPublicacion
            // 
            this.cmbTipoPublicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPublicacion.FormattingEnabled = true;
            this.cmbTipoPublicacion.Location = new System.Drawing.Point(12, 38);
            this.cmbTipoPublicacion.Name = "cmbTipoPublicacion";
            this.cmbTipoPublicacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPublicacion.TabIndex = 0;
            this.cmbTipoPublicacion.TextChanged += new System.EventHandler(this.cmbTipoPublicacion_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 203);
            this.Controls.Add(this.gpGenerarPublicacion);
            this.Name = "frmGenerarPublicacion";
            this.Text = "Generar Publicación";
            this.Load += new System.EventHandler(this.frmGenerarPublicacion_Load);
            this.gpGenerarPublicacion.ResumeLayout(false);
            this.gpGenerarPublicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpGenerarPublicacion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescPublicacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodPublicacion;
        private System.Windows.Forms.Label lblTipoPublicacion;
        private System.Windows.Forms.ComboBox cmbTipoPublicacion;
        private System.Windows.Forms.Label lblVisibilidad;
        private System.Windows.Forms.ComboBox cmbVisibilidadPublicacion;
        private System.Windows.Forms.DateTimePicker dtpInicioPublicacion;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.CheckBox chkSePermitePreguntas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGenerarPublicacion;
        private System.Windows.Forms.TextBox txtVencimientoPublicacion;
        private System.Windows.Forms.ListBox lstBoxRubros;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbEstadoPublicacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblValorInicialSubasta;
        private System.Windows.Forms.TextBox txtValorInicialSubasta;
        private System.Windows.Forms.Button btnLimpiarForm;
    }
}