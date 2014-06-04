namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class ResponderPreguntasForm
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
            this.dgvPreguntas = new System.Windows.Forms.DataGridView();
            this.gbDataGrid = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
            this.gbDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.AllowUserToAddRows = false;
            this.dgvPreguntas.AllowUserToDeleteRows = false;
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.Location = new System.Drawing.Point(6, 19);
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.ReadOnly = true;
            this.dgvPreguntas.RowHeadersWidth = 60;
            this.dgvPreguntas.Size = new System.Drawing.Size(643, 237);
            this.dgvPreguntas.TabIndex = 0;
            this.dgvPreguntas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreguntas_CellDoubleClick);
            // 
            // gbDataGrid
            // 
            this.gbDataGrid.Controls.Add(this.dgvPreguntas);
            this.gbDataGrid.Location = new System.Drawing.Point(12, 12);
            this.gbDataGrid.Name = "gbDataGrid";
            this.gbDataGrid.Size = new System.Drawing.Size(655, 262);
            this.gbDataGrid.TabIndex = 1;
            this.gbDataGrid.TabStop = false;
            this.gbDataGrid.Text = "Doble click a la pregunta que desea responder:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(301, 292);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ResponderPreguntasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 327);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbDataGrid);
            this.Name = "ResponderPreguntasForm";
            this.Text = "Responder Preguntas";
            this.Load += new System.EventHandler(this.ResponderPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
            this.gbDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreguntas;
        private System.Windows.Forms.GroupBox gbDataGrid;
        private System.Windows.Forms.Button btnVolver;
    }
}