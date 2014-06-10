namespace FrbaCommerce.Facturar_Publicaciones
{
    partial class frmFacturarPublicaciones
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
            this.cmbPersonaFacturar = new System.Windows.Forms.ComboBox();
            this.lblPersonaFacturar = new System.Windows.Forms.Label();
            this.txtCantidadRendir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFacturarPublicaciones = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodSegTarjeta = new System.Windows.Forms.TextBox();
            this.txtVencimientoTarjeta = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFormaDePago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPersonaFacturar
            // 
            this.cmbPersonaFacturar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonaFacturar.FormattingEnabled = true;
            this.cmbPersonaFacturar.Location = new System.Drawing.Point(6, 32);
            this.cmbPersonaFacturar.Name = "cmbPersonaFacturar";
            this.cmbPersonaFacturar.Size = new System.Drawing.Size(150, 21);
            this.cmbPersonaFacturar.TabIndex = 0;
            // 
            // lblPersonaFacturar
            // 
            this.lblPersonaFacturar.AutoSize = true;
            this.lblPersonaFacturar.Location = new System.Drawing.Point(9, 16);
            this.lblPersonaFacturar.Name = "lblPersonaFacturar";
            this.lblPersonaFacturar.Size = new System.Drawing.Size(150, 13);
            this.lblPersonaFacturar.TabIndex = 1;
            this.lblPersonaFacturar.Text = "Seleccione Persona a facturar";
            // 
            // txtCantidadRendir
            // 
            this.txtCantidadRendir.Location = new System.Drawing.Point(162, 33);
            this.txtCantidadRendir.Name = "txtCantidadRendir";
            this.txtCantidadRendir.Size = new System.Drawing.Size(117, 20);
            this.txtCantidadRendir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad a Rendir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFacturarPublicaciones);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodSegTarjeta);
            this.groupBox1.Controls.Add(this.txtVencimientoTarjeta);
            this.groupBox1.Controls.Add(this.txtNroTarjeta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFormaDePago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPersonaFacturar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPersonaFacturar);
            this.groupBox1.Controls.Add(this.txtCantidadRendir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnFacturarPublicaciones
            // 
            this.btnFacturarPublicaciones.Location = new System.Drawing.Point(110, 168);
            this.btnFacturarPublicaciones.Name = "btnFacturarPublicaciones";
            this.btnFacturarPublicaciones.Size = new System.Drawing.Size(75, 23);
            this.btnFacturarPublicaciones.TabIndex = 12;
            this.btnFacturarPublicaciones.Text = "Facturar";
            this.btnFacturarPublicaciones.UseVisualStyleBackColor = true;
            this.btnFacturarPublicaciones.Click += new System.EventHandler(this.btnFacturarPublicaciones_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cod. Seg.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Venc.";
            // 
            // txtCodSegTarjeta
            // 
            this.txtCodSegTarjeta.Location = new System.Drawing.Point(223, 126);
            this.txtCodSegTarjeta.Name = "txtCodSegTarjeta";
            this.txtCodSegTarjeta.Size = new System.Drawing.Size(56, 20);
            this.txtCodSegTarjeta.TabIndex = 9;
            // 
            // txtVencimientoTarjeta
            // 
            this.txtVencimientoTarjeta.Location = new System.Drawing.Point(162, 126);
            this.txtVencimientoTarjeta.Name = "txtVencimientoTarjeta";
            this.txtVencimientoTarjeta.Size = new System.Drawing.Size(55, 20);
            this.txtVencimientoTarjeta.TabIndex = 8;
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(6, 126);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(150, 20);
            this.txtNroTarjeta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro. de Tarjeta";
            // 
            // cmbFormaDePago
            // 
            this.cmbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaDePago.FormattingEnabled = true;
            this.cmbFormaDePago.Location = new System.Drawing.Point(6, 82);
            this.cmbFormaDePago.Name = "cmbFormaDePago";
            this.cmbFormaDePago.Size = new System.Drawing.Size(150, 21);
            this.cmbFormaDePago.TabIndex = 5;
            this.cmbFormaDePago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaDePago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione Forma de Pago";
            // 
            // frmFacturarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 203);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFacturarPublicaciones";
            this.Text = "Facturar Publicaciones";
            this.Load += new System.EventHandler(this.frmFacturarPublicaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonaFacturar;
        private System.Windows.Forms.Label lblPersonaFacturar;
        private System.Windows.Forms.TextBox txtCantidadRendir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFormaDePago;
        private System.Windows.Forms.Button btnFacturarPublicaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodSegTarjeta;
        private System.Windows.Forms.TextBox txtVencimientoTarjeta;
    }
}