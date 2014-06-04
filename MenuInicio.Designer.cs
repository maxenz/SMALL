namespace FrbaCommerce
{
    partial class MenuInicio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnComprarOfertar = new System.Windows.Forms.Button();
            this.btnGenerarPublicacion = new System.Windows.Forms.Button();
            this.btnResponderPreguntas = new System.Windows.Forms.Button();
            this.btnVerRespuestas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(23, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 31);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "FRBA Commerce";
            // 
            // btnComprarOfertar
            // 
            this.btnComprarOfertar.Location = new System.Drawing.Point(29, 60);
            this.btnComprarOfertar.Name = "btnComprarOfertar";
            this.btnComprarOfertar.Size = new System.Drawing.Size(120, 23);
            this.btnComprarOfertar.TabIndex = 15;
            this.btnComprarOfertar.Text = "Comprar/Ofertar";
            this.btnComprarOfertar.UseVisualStyleBackColor = true;
            this.btnComprarOfertar.Click += new System.EventHandler(this.btnComprarOfertar_Click_1);
            // 
            // btnGenerarPublicacion
            // 
            this.btnGenerarPublicacion.Location = new System.Drawing.Point(29, 90);
            this.btnGenerarPublicacion.Name = "btnGenerarPublicacion";
            this.btnGenerarPublicacion.Size = new System.Drawing.Size(120, 23);
            this.btnGenerarPublicacion.TabIndex = 16;
            this.btnGenerarPublicacion.Text = "Generar Publicacion";
            this.btnGenerarPublicacion.UseVisualStyleBackColor = true;
            this.btnGenerarPublicacion.Click += new System.EventHandler(this.btnGenerarPublicacion_Click);
            // 
            // btnResponderPreguntas
            // 
            this.btnResponderPreguntas.Location = new System.Drawing.Point(29, 120);
            this.btnResponderPreguntas.Name = "btnResponderPreguntas";
            this.btnResponderPreguntas.Size = new System.Drawing.Size(120, 23);
            this.btnResponderPreguntas.TabIndex = 17;
            this.btnResponderPreguntas.Text = "Responder Preguntas";
            this.btnResponderPreguntas.UseVisualStyleBackColor = true;
            this.btnResponderPreguntas.Click += new System.EventHandler(this.btnResponderPreguntas_Click);
            // 
            // btnVerRespuestas
            // 
            this.btnVerRespuestas.Location = new System.Drawing.Point(29, 150);
            this.btnVerRespuestas.Name = "btnVerRespuestas";
            this.btnVerRespuestas.Size = new System.Drawing.Size(120, 23);
            this.btnVerRespuestas.TabIndex = 18;
            this.btnVerRespuestas.Text = "Ver Respuestas";
            this.btnVerRespuestas.UseVisualStyleBackColor = true;
            this.btnVerRespuestas.Click += new System.EventHandler(this.btnVerRespuestas_Click);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnVerRespuestas);
            this.Controls.Add(this.btnResponderPreguntas);
            this.Controls.Add(this.btnGenerarPublicacion);
            this.Controls.Add(this.btnComprarOfertar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComprarOfertar;
        private System.Windows.Forms.Button btnGenerarPublicacion;
        private System.Windows.Forms.Button btnResponderPreguntas;
        private System.Windows.Forms.Button btnVerRespuestas;
    }
}
