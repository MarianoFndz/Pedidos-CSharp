namespace Capa_Cliente
{
    partial class FormCrearPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCrearPedido = new System.Windows.Forms.DataGridView();
            this.btnAgregarDetallePedido = new System.Windows.Forms.Button();
            this.lblCrearPedidoTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudCrearPedido = new System.Windows.Forms.NumericUpDown();
            this.lblCrearPedidoCantidad = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.pnlCrearPedido = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.btnTerminarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearPedido)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrearPedido)).BeginInit();
            this.pnlCrearPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCrearPedido
            // 
            this.dgvCrearPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearPedido.Location = new System.Drawing.Point(16, 13);
            this.dgvCrearPedido.Name = "dgvCrearPedido";
            this.dgvCrearPedido.Size = new System.Drawing.Size(345, 283);
            this.dgvCrearPedido.TabIndex = 0;
            // 
            // btnAgregarDetallePedido
            // 
            this.btnAgregarDetallePedido.Location = new System.Drawing.Point(250, 20);
            this.btnAgregarDetallePedido.Name = "btnAgregarDetallePedido";
            this.btnAgregarDetallePedido.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDetallePedido.TabIndex = 1;
            this.btnAgregarDetallePedido.Text = "Agregar";
            this.btnAgregarDetallePedido.UseVisualStyleBackColor = true;
            this.btnAgregarDetallePedido.Click += new System.EventHandler(this.btnAgregarDetallePedido_Click);
            // 
            // lblCrearPedidoTitulo
            // 
            this.lblCrearPedidoTitulo.AutoSize = true;
            this.lblCrearPedidoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearPedidoTitulo.Location = new System.Drawing.Point(91, 9);
            this.lblCrearPedidoTitulo.Name = "lblCrearPedidoTitulo";
            this.lblCrearPedidoTitulo.Size = new System.Drawing.Size(193, 26);
            this.lblCrearPedidoTitulo.TabIndex = 2;
            this.lblCrearPedidoTitulo.Text = "CREAR PEDIDO";
            this.lblCrearPedidoTitulo.Click += new System.EventHandler(this.lblCrearPedidoTitulo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudCrearPedido);
            this.panel1.Controls.Add(this.lblCrearPedidoCantidad);
            this.panel1.Controls.Add(this.btnAgregarDetallePedido);
            this.panel1.Location = new System.Drawing.Point(16, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 68);
            this.panel1.TabIndex = 3;
            // 
            // nudCrearPedido
            // 
            this.nudCrearPedido.Location = new System.Drawing.Point(64, 23);
            this.nudCrearPedido.Name = "nudCrearPedido";
            this.nudCrearPedido.Size = new System.Drawing.Size(120, 20);
            this.nudCrearPedido.TabIndex = 3;
            this.nudCrearPedido.ValueChanged += new System.EventHandler(this.nudCrearPedido_ValueChanged);
            // 
            // lblCrearPedidoCantidad
            // 
            this.lblCrearPedidoCantidad.AutoSize = true;
            this.lblCrearPedidoCantidad.Location = new System.Drawing.Point(13, 25);
            this.lblCrearPedidoCantidad.Name = "lblCrearPedidoCantidad";
            this.lblCrearPedidoCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCrearPedidoCantidad.TabIndex = 2;
            this.lblCrearPedidoCantidad.Text = "Cantidad: ";
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(132, 51);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(103, 23);
            this.btnNuevoPedido.TabIndex = 4;
            this.btnNuevoPedido.Text = "Nuevo pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // pnlCrearPedido
            // 
            this.pnlCrearPedido.Controls.Add(this.label1);
            this.pnlCrearPedido.Controls.Add(this.txbDireccion);
            this.pnlCrearPedido.Controls.Add(this.btnTerminarPedido);
            this.pnlCrearPedido.Controls.Add(this.dgvCrearPedido);
            this.pnlCrearPedido.Controls.Add(this.panel1);
            this.pnlCrearPedido.Location = new System.Drawing.Point(1, 80);
            this.pnlCrearPedido.Name = "pnlCrearPedido";
            this.pnlCrearPedido.Size = new System.Drawing.Size(373, 492);
            this.pnlCrearPedido.TabIndex = 5;
            this.pnlCrearPedido.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Direccion: ";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(80, 399);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(100, 20);
            this.txbDireccion.TabIndex = 7;
            // 
            // btnTerminarPedido
            // 
            this.btnTerminarPedido.Location = new System.Drawing.Point(131, 449);
            this.btnTerminarPedido.Name = "btnTerminarPedido";
            this.btnTerminarPedido.Size = new System.Drawing.Size(103, 23);
            this.btnTerminarPedido.TabIndex = 6;
            this.btnTerminarPedido.Text = "Terminar pedido";
            this.btnTerminarPedido.UseVisualStyleBackColor = true;
            this.btnTerminarPedido.Click += new System.EventHandler(this.btnTerminarPedido_Click);
            // 
            // FormCrearPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 573);
            this.Controls.Add(this.pnlCrearPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.lblCrearPedidoTitulo);
            this.Name = "FormCrearPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrearPedido)).EndInit();
            this.pnlCrearPedido.ResumeLayout(false);
            this.pnlCrearPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCrearPedido;
        private System.Windows.Forms.Button btnAgregarDetallePedido;
        private System.Windows.Forms.Label lblCrearPedidoTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudCrearPedido;
        private System.Windows.Forms.Label lblCrearPedidoCantidad;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Panel pnlCrearPedido;
        private System.Windows.Forms.Button btnTerminarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDireccion;
    }
}

