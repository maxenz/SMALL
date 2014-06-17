namespace FrbaCommerce.Abm_Empresa
{
    partial class AltaEmpresaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRazonSocial = new System.Windows.Forms.TextBox();
            this.tbNombreContacto = new System.Windows.Forms.TextBox();
            this.tbCuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNroCalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de contacto";
            // 
            // tbRazonSocial
            // 
            this.tbRazonSocial.Location = new System.Drawing.Point(161, 21);
            this.tbRazonSocial.Name = "tbRazonSocial";
            this.tbRazonSocial.Size = new System.Drawing.Size(171, 20);
            this.tbRazonSocial.TabIndex = 2;
            // 
            // tbNombreContacto
            // 
            this.tbNombreContacto.Location = new System.Drawing.Point(161, 48);
            this.tbNombreContacto.Name = "tbNombreContacto";
            this.tbNombreContacto.Size = new System.Drawing.Size(171, 20);
            this.tbNombreContacto.TabIndex = 3;
            // 
            // tbCuit
            // 
            this.tbCuit.Location = new System.Drawing.Point(161, 74);
            this.tbCuit.Name = "tbCuit";
            this.tbCuit.Size = new System.Drawing.Size(171, 20);
            this.tbCuit.TabIndex = 5;
            this.tbCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail";
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(161, 100);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(171, 20);
            this.tbEMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(161, 178);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(171, 20);
            this.tbCiudad.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Localidad";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(161, 152);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(171, 20);
            this.tbCodigoPostal.TabIndex = 11;
            this.tbCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Piso:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(161, 126);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(171, 20);
            this.tbTelefono.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Calle";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(288, 256);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(44, 20);
            this.tbPiso.TabIndex = 19;
            this.tbPiso.TextChanged += new System.EventHandler(this.tbPiso_TextChanged);
            this.tbPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "CUIT";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(161, 230);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(75, 20);
            this.tbCalle.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Departamento";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(161, 204);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(171, 20);
            this.tbLocalidad.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Codigo postal";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Location = new System.Drawing.Point(161, 256);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(75, 20);
            this.tbDepartamento.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Fecha de creacion";
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(161, 334);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 24;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bAceptar.Location = new System.Drawing.Point(257, 334);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 26;
            this.bAceptar.Text = "Guardar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(161, 285);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCreacion.TabIndex = 27;
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnToday.Location = new System.Drawing.Point(266, 285);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(66, 20);
            this.btnToday.TabIndex = 28;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Numero:";
            // 
            // tbNroCalle
            // 
            this.tbNroCalle.Location = new System.Drawing.Point(288, 230);
            this.tbNroCalle.Name = "tbNroCalle";
            this.tbNroCalle.Size = new System.Drawing.Size(44, 20);
            this.tbNroCalle.TabIndex = 30;
            this.tbNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // AltaEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 370);
            this.Controls.Add(this.tbNroCalle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDepartamento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbPiso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCodigoPostal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreContacto);
            this.Controls.Add(this.tbRazonSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaEmpresaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaEmpresaForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRazonSocial;
        private System.Windows.Forms.TextBox tbNombreContacto;
        private System.Windows.Forms.TextBox tbCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDepartamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNroCalle;
    }
}