namespace FrbaCommerce.Calificar_Vendedor
{
    partial class CalificarDetalle
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
            this.btnCalificar = new System.Windows.Forms.Button();
            this.cmbCalificacion = new System.Windows.Forms.ComboBox();
            this.txtDetalleCalificacion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(209, 122);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 0;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // cmbCalificacion
            // 
            this.cmbCalificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalificacion.FormattingEnabled = true;
            this.cmbCalificacion.Location = new System.Drawing.Point(12, 41);
            this.cmbCalificacion.Name = "cmbCalificacion";
            this.cmbCalificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbCalificacion.TabIndex = 1;
            // 
            // txtDetalleCalificacion
            // 
            this.txtDetalleCalificacion.Location = new System.Drawing.Point(154, 47);
            this.txtDetalleCalificacion.Name = "txtDetalleCalificacion";
            this.txtDetalleCalificacion.Size = new System.Drawing.Size(377, 69);
            this.txtDetalleCalificacion.TabIndex = 2;
            this.txtDetalleCalificacion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de Estrellas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDetalleCalificacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCalificar);
            this.groupBox1.Controls.Add(this.cmbCalificacion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Califique el producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle";
            // 
            // CalificarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 152);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalificarDetalle";
            this.Text = "CalificarDetalle";
            this.Load += new System.EventHandler(this.CalificarDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.ComboBox cmbCalificacion;
        private System.Windows.Forms.RichTextBox txtDetalleCalificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}