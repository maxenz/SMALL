namespace FrbaCommerce.Abm_Cliente
{
    partial class AltaClienteForm
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.tbNroCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCuil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bAceptar.Location = new System.Drawing.Point(288, 207);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 28;
            this.bAceptar.Text = "Guardar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(192, 207);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 27;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // tbNroCalle
            // 
            this.tbNroCalle.Location = new System.Drawing.Point(509, 67);
            this.tbNroCalle.Name = "tbNroCalle";
            this.tbNroCalle.Size = new System.Drawing.Size(29, 20);
            this.tbNroCalle.TabIndex = 57;
            this.tbNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Numero:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Cod postal:";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Location = new System.Drawing.Point(342, 94);
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(89, 20);
            this.tbDepartamento.TabIndex = 52;
            this.tbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Fecha de nacimiento";
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(509, 91);
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(29, 20);
            this.tbPiso.TabIndex = 50;
            this.tbPiso.TextChanged += new System.EventHandler(this.tbPiso_TextChanged);
            this.tbPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "CUIL";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(342, 67);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(89, 20);
            this.tbCalle.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Departamento:";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(342, 42);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(89, 20);
            this.tbLocalidad.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Ciudad";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(342, 16);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(89, 20);
            this.tbCiudad.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Localidad";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(509, 42);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(29, 20);
            this.tbCodigoPostal.TabIndex = 42;
            this.tbCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Piso:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(80, 120);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(116, 20);
            this.tbTelefono.TabIndex = 40;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Calle";
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(80, 94);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(116, 20);
            this.tbEMail.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Telefono";
            // 
            // tbCuil
            // 
            this.tbCuil.Location = new System.Drawing.Point(80, 68);
            this.tbCuil.Name = "tbCuil";
            this.tbCuil.Size = new System.Drawing.Size(116, 20);
            this.tbCuil.TabIndex = 36;
            this.tbCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "E-Mail";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(80, 42);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(116, 20);
            this.tbApellido.TabIndex = 34;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(80, 15);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(116, 20);
            this.tbNombre.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(342, 120);
            this.dtpFechaNac.MaxDate = new System.DateTime(1996, 6, 18, 0, 0, 0, 0);
            this.dtpFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaNac.ShowUpDown = true;
            this.dtpFechaNac.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaNac.TabIndex = 58;
            this.dtpFechaNac.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(80, 148);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(116, 20);
            this.tbDni.TabIndex = 60;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(12, 152);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(62, 13);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "Documento";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(239, 147);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(103, 21);
            this.cbTipoDoc.TabIndex = 61;
            // 
            // AltaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 238);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.tbNroCalle);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.tbCuil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AltaClienteForm";
            this.Text = "Alta de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.TextBox tbNroCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDepartamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCuil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox cbTipoDoc;
    }
}