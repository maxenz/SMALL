namespace FrbaCommerce.Listado_Estadistico
{
    partial class ListadosForm
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
            this.cboxListado = new System.Windows.Forms.ComboBox();
            this.gridListado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxAnio = new System.Windows.Forms.ComboBox();
            this.cboxTrimestre = new System.Windows.Forms.ComboBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxMes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listados Disponibles";
            // 
            // cboxListado
            // 
            this.cboxListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxListado.FormattingEnabled = true;
            this.cboxListado.Items.AddRange(new object[] {
            "Primeros 5 vendedores con mayor cantidad de productos no vendidos",
            "Primeros 5 vendedores con mayor facturación",
            "Primeras 5 vendedores con mayores calificaciones",
            "Primeros 5 clientes con mayor cantidad de publicaciones sin calificar"});
            this.cboxListado.Location = new System.Drawing.Point(127, 15);
            this.cboxListado.Name = "cboxListado";
            this.cboxListado.Size = new System.Drawing.Size(469, 21);
            this.cboxListado.TabIndex = 1;
            this.cboxListado.SelectedIndexChanged += new System.EventHandler(this.cboxListado_SelectedIndexChanged);
            // 
            // gridListado
            // 
            this.gridListado.AllowUserToAddRows = false;
            this.gridListado.AllowUserToDeleteRows = false;
            this.gridListado.AllowUserToResizeColumns = false;
            this.gridListado.AllowUserToResizeRows = false;
            this.gridListado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListado.Location = new System.Drawing.Point(5, 117);
            this.gridListado.Name = "gridListado";
            this.gridListado.ReadOnly = true;
            this.gridListado.Size = new System.Drawing.Size(602, 147);
            this.gridListado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trimestre";
            // 
            // cboxAnio
            // 
            this.cboxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAnio.FormattingEnabled = true;
            this.cboxAnio.Location = new System.Drawing.Point(529, 42);
            this.cboxAnio.Name = "cboxAnio";
            this.cboxAnio.Size = new System.Drawing.Size(64, 21);
            this.cboxAnio.TabIndex = 5;
            // 
            // cboxTrimestre
            // 
            this.cboxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTrimestre.FormattingEnabled = true;
            this.cboxTrimestre.Location = new System.Drawing.Point(128, 42);
            this.cboxTrimestre.Name = "cboxTrimestre";
            this.cboxTrimestre.Size = new System.Drawing.Size(74, 21);
            this.cboxTrimestre.TabIndex = 6;
            this.cboxTrimestre.SelectedIndexChanged += new System.EventHandler(this.cboxTrimestre_SelectedIndexChanged);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(169, 74);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(87, 24);
            this.buttonConsultar.TabIndex = 7;
            this.buttonConsultar.Text = "Listar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboxMes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonConsultar);
            this.groupBox1.Controls.Add(this.cboxTrimestre);
            this.groupBox1.Controls.Add(this.cboxAnio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxListado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mes";
            // 
            // cboxMes
            // 
            this.cboxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMes.FormattingEnabled = true;
            this.cboxMes.Location = new System.Drawing.Point(323, 43);
            this.cboxMes.Name = "cboxMes";
            this.cboxMes.Size = new System.Drawing.Size(103, 21);
            this.cboxMes.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados Estadisticos";
            this.Load += new System.EventHandler(this.ListadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxListado;
        private System.Windows.Forms.DataGridView gridListado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxAnio;
        private System.Windows.Forms.ComboBox cboxTrimestre;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}