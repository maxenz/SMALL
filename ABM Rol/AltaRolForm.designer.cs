namespace FrbaCommerce.ABM_Rol
{
    partial class AltaRolForm
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
            this.clbFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNinguno = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbFuncionalidades
            // 
            this.clbFuncionalidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFuncionalidades.FormattingEnabled = true;
            this.clbFuncionalidades.Location = new System.Drawing.Point(12, 101);
            this.clbFuncionalidades.Name = "clbFuncionalidades";
            this.clbFuncionalidades.Size = new System.Drawing.Size(262, 244);
            this.clbFuncionalidades.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(65, 30);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(103, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(103, 351);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNinguno
            // 
            this.btnNinguno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnNinguno.Location = new System.Drawing.Point(12, 72);
            this.btnNinguno.Name = "btnNinguno";
            this.btnNinguno.Size = new System.Drawing.Size(115, 23);
            this.btnNinguno.TabIndex = 4;
            this.btnNinguno.Text = "Seleccionar ninguno";
            this.btnNinguno.UseVisualStyleBackColor = true;
            // 
            // btnTodo
            // 
            this.btnTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnTodo.Location = new System.Drawing.Point(159, 72);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(115, 23);
            this.btnTodo.TabIndex = 5;
            this.btnTodo.Text = "Seleccionar todos";
            this.btnTodo.UseVisualStyleBackColor = true;
            // 
            // AltaRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 386);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnNinguno);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.clbFuncionalidades);
            this.Name = "AltaRolForm";
            this.Text = "Alta de un Rol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaRolForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbFuncionalidades;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNinguno;
        private System.Windows.Forms.Button btnTodo;
    }
}