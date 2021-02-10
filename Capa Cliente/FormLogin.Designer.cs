namespace Capa_Cliente
{
    partial class FormLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.lblLoginContraseña = new System.Windows.Forms.Label();
            this.txbLoginUsuario = new System.Windows.Forms.TextBox();
            this.txbLoginContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(166, 149);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Aceptar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Location = new System.Drawing.Point(28, 80);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblLoginUsuario.TabIndex = 1;
            this.lblLoginUsuario.Text = "Usuario:";
            this.lblLoginUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitulo.Location = new System.Drawing.Point(94, 19);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(85, 26);
            this.lblLoginTitulo.TabIndex = 2;
            this.lblLoginTitulo.Text = "LOGIN";
            // 
            // lblLoginContraseña
            // 
            this.lblLoginContraseña.AutoSize = true;
            this.lblLoginContraseña.Location = new System.Drawing.Point(10, 114);
            this.lblLoginContraseña.Name = "lblLoginContraseña";
            this.lblLoginContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblLoginContraseña.TabIndex = 3;
            this.lblLoginContraseña.Text = "Contraseña:";
            // 
            // txbLoginUsuario
            // 
            this.txbLoginUsuario.Location = new System.Drawing.Point(80, 77);
            this.txbLoginUsuario.Name = "txbLoginUsuario";
            this.txbLoginUsuario.Size = new System.Drawing.Size(161, 20);
            this.txbLoginUsuario.TabIndex = 4;
            // 
            // txbLoginContraseña
            // 
            this.txbLoginContraseña.Location = new System.Drawing.Point(80, 111);
            this.txbLoginContraseña.Name = "txbLoginContraseña";
            this.txbLoginContraseña.PasswordChar = '*';
            this.txbLoginContraseña.Size = new System.Drawing.Size(161, 20);
            this.txbLoginContraseña.TabIndex = 5;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 196);
            this.Controls.Add(this.txbLoginContraseña);
            this.Controls.Add(this.txbLoginUsuario);
            this.Controls.Add(this.lblLoginContraseña);
            this.Controls.Add(this.lblLoginTitulo);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.btnLogin);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label lblLoginTitulo;
        private System.Windows.Forms.Label lblLoginContraseña;
        private System.Windows.Forms.TextBox txbLoginUsuario;
        private System.Windows.Forms.TextBox txbLoginContraseña;
    }
}