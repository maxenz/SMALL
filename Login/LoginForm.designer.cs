namespace FrbaCommerce.Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_button = new System.Windows.Forms.Button();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(92, 101);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 21);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(58, 38);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '•';
            this.tBoxPassword.Size = new System.Drawing.Size(196, 20);
            this.tBoxPassword.TabIndex = 2;
            this.tBoxPassword.TextChanged += new System.EventHandler(this.Cambios);
            // 
            // tBoxNombreUsuario
            // 
            this.tBoxNombreUsuario.Location = new System.Drawing.Point(58, 12);
            this.tBoxNombreUsuario.Name = "tBoxNombreUsuario";
            this.tBoxNombreUsuario.Size = new System.Drawing.Size(196, 20);
            this.tBoxNombreUsuario.TabIndex = 1;
            this.tBoxNombreUsuario.TextChanged += new System.EventHandler(this.Cambios);
            // 
            // errorBox
            // 
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Enabled = false;
            this.errorBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorBox.Location = new System.Drawing.Point(5, 64);
            this.errorBox.Multiline = true;
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(250, 30);
            this.errorBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.tBoxNombreUsuario);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.TextBox tBoxNombreUsuario;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}