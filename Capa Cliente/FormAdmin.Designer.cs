namespace Capa_Cliente
{
    partial class FormAdmin
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
            this.dgvCrearPedido = new System.Windows.Forms.DataGridView();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.btnUsuarioAceptar = new System.Windows.Forms.Button();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProductoAceptar = new System.Windows.Forms.Button();
            this.txbProductoNombre = new System.Windows.Forms.TextBox();
            this.btnUsuarioAgregar = new System.Windows.Forms.Button();
            this.btnProductoAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRADOR";
            // 
            // dgvCrearPedido
            // 
            this.dgvCrearPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearPedido.Location = new System.Drawing.Point(12, 78);
            this.dgvCrearPedido.Name = "dgvCrearPedido";
            this.dgvCrearPedido.Size = new System.Drawing.Size(399, 283);
            this.dgvCrearPedido.TabIndex = 1;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(12, 431);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(399, 283);
            this.dgvDetalles.TabIndex = 2;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(127, 386);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(133, 23);
            this.btnVerDetalles.TabIndex = 3;
            this.btnVerDetalles.Text = "Ver detalles del pedido";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.label3);
            this.pnlUsuario.Controls.Add(this.label2);
            this.pnlUsuario.Controls.Add(this.txtUsuarioContraseña);
            this.pnlUsuario.Controls.Add(this.txtUsuarioNombre);
            this.pnlUsuario.Controls.Add(this.btnUsuarioAceptar);
            this.pnlUsuario.Location = new System.Drawing.Point(439, 122);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(393, 239);
            this.pnlUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contraseña:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // txtUsuarioContraseña
            // 
            this.txtUsuarioContraseña.Location = new System.Drawing.Point(119, 107);
            this.txtUsuarioContraseña.Name = "txtUsuarioContraseña";
            this.txtUsuarioContraseña.Size = new System.Drawing.Size(128, 20);
            this.txtUsuarioContraseña.TabIndex = 11;
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Location = new System.Drawing.Point(119, 60);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(128, 20);
            this.txtUsuarioNombre.TabIndex = 10;
            // 
            // btnUsuarioAceptar
            // 
            this.btnUsuarioAceptar.Location = new System.Drawing.Point(151, 201);
            this.btnUsuarioAceptar.Name = "btnUsuarioAceptar";
            this.btnUsuarioAceptar.Size = new System.Drawing.Size(83, 23);
            this.btnUsuarioAceptar.TabIndex = 9;
            this.btnUsuarioAceptar.Text = "Aceptar";
            this.btnUsuarioAceptar.UseVisualStyleBackColor = true;
            this.btnUsuarioAceptar.Click += new System.EventHandler(this.btnUsuarioAceptar_Click);
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.label4);
            this.pnlProducto.Controls.Add(this.btnProductoAceptar);
            this.pnlProducto.Controls.Add(this.txbProductoNombre);
            this.pnlProducto.Location = new System.Drawing.Point(439, 478);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(393, 236);
            this.pnlProducto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre:";
            // 
            // btnProductoAceptar
            // 
            this.btnProductoAceptar.Location = new System.Drawing.Point(151, 199);
            this.btnProductoAceptar.Name = "btnProductoAceptar";
            this.btnProductoAceptar.Size = new System.Drawing.Size(83, 23);
            this.btnProductoAceptar.TabIndex = 8;
            this.btnProductoAceptar.Text = "Aceptar";
            this.btnProductoAceptar.UseVisualStyleBackColor = true;
            this.btnProductoAceptar.Click += new System.EventHandler(this.btnProductoAceptar_Click);
            // 
            // txbProductoNombre
            // 
            this.txbProductoNombre.Location = new System.Drawing.Point(119, 92);
            this.txbProductoNombre.Name = "txbProductoNombre";
            this.txbProductoNombre.Size = new System.Drawing.Size(128, 20);
            this.txbProductoNombre.TabIndex = 14;
            // 
            // btnUsuarioAgregar
            // 
            this.btnUsuarioAgregar.Location = new System.Drawing.Point(576, 78);
            this.btnUsuarioAgregar.Name = "btnUsuarioAgregar";
            this.btnUsuarioAgregar.Size = new System.Drawing.Size(110, 23);
            this.btnUsuarioAgregar.TabIndex = 6;
            this.btnUsuarioAgregar.Text = "Agregar Usuario";
            this.btnUsuarioAgregar.UseVisualStyleBackColor = true;
            this.btnUsuarioAgregar.Click += new System.EventHandler(this.btnUsuarioAgregar_Click);
            // 
            // btnProductoAgregar
            // 
            this.btnProductoAgregar.Location = new System.Drawing.Point(576, 431);
            this.btnProductoAgregar.Name = "btnProductoAgregar";
            this.btnProductoAgregar.Size = new System.Drawing.Size(110, 23);
            this.btnProductoAgregar.TabIndex = 7;
            this.btnProductoAgregar.Text = "Agregar  Producto";
            this.btnProductoAgregar.UseVisualStyleBackColor = true;
            this.btnProductoAgregar.Click += new System.EventHandler(this.btnProductoAgregar_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 736);
            this.Controls.Add(this.btnProductoAgregar);
            this.Controls.Add(this.btnUsuarioAgregar);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dgvCrearPedido);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCrearPedido;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioContraseña;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.Button btnUsuarioAceptar;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Button btnProductoAceptar;
        private System.Windows.Forms.Button btnUsuarioAgregar;
        private System.Windows.Forms.Button btnProductoAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbProductoNombre;
    }
}