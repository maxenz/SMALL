namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class ResponderForm
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
            this.gbPregunta = new System.Windows.Forms.GroupBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.gbRespuesta = new System.Windows.Forms.GroupBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbPregunta.SuspendLayout();
            this.gbRespuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPregunta
            // 
            this.gbPregunta.Controls.Add(this.txtPregunta);
            this.gbPregunta.Location = new System.Drawing.Point(13, 13);
            this.gbPregunta.Name = "gbPregunta";
            this.gbPregunta.Size = new System.Drawing.Size(565, 206);
            this.gbPregunta.TabIndex = 0;
            this.gbPregunta.TabStop = false;
            this.gbPregunta.Text = "Pregunta:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(7, 20);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ReadOnly = true;
            this.txtPregunta.Size = new System.Drawing.Size(552, 171);
            this.txtPregunta.TabIndex = 0;
            // 
            // gbRespuesta
            // 
            this.gbRespuesta.Controls.Add(this.btnResponder);
            this.gbRespuesta.Controls.Add(this.txtRespuesta);
            this.gbRespuesta.Location = new System.Drawing.Point(13, 226);
            this.gbRespuesta.Name = "gbRespuesta";
            this.gbRespuesta.Size = new System.Drawing.Size(565, 206);
            this.gbRespuesta.TabIndex = 1;
            this.gbRespuesta.TabStop = false;
            this.gbRespuesta.Text = "Respuesta";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(484, 95);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(75, 23);
            this.btnResponder.TabIndex = 1;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(7, 20);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(471, 167);
            this.txtRespuesta.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(257, 449);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ResponderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 492);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbRespuesta);
            this.Controls.Add(this.gbPregunta);
            this.Name = "ResponderForm";
            this.Text = "Responder";
            this.Load += new System.EventHandler(this.ResponderForm_Load);
            this.gbPregunta.ResumeLayout(false);
            this.gbPregunta.PerformLayout();
            this.gbRespuesta.ResumeLayout(false);
            this.gbRespuesta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPregunta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.GroupBox gbRespuesta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnResponder;
    }
}