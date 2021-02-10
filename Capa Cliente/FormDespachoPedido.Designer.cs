namespace Capa_Cliente
{
    partial class FormDespachoPedido
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
            this.pnlCrearPedido = new System.Windows.Forms.Panel();
            this.btnDespacharPedido = new System.Windows.Forms.Button();
            this.dgvDetallesPedidos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarPedido = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.pnlCrearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESPACHAR PEDIDOS";
            // 
            // pnlCrearPedido
            // 
            this.pnlCrearPedido.Controls.Add(this.btnDespacharPedido);
            this.pnlCrearPedido.Controls.Add(this.dgvDetallesPedidos);
            this.pnlCrearPedido.Location = new System.Drawing.Point(28, 444);
            this.pnlCrearPedido.Name = "pnlCrearPedido";
            this.pnlCrearPedido.Size = new System.Drawing.Size(391, 297);
            this.pnlCrearPedido.TabIndex = 6;
            // 
            // btnDespacharPedido
            // 
            this.btnDespacharPedido.Location = new System.Drawing.Point(141, 258);
            this.btnDespacharPedido.Name = "btnDespacharPedido";
            this.btnDespacharPedido.Size = new System.Drawing.Size(116, 23);
            this.btnDespacharPedido.TabIndex = 7;
            this.btnDespacharPedido.Text = "Despachar pedido";
            this.btnDespacharPedido.UseVisualStyleBackColor = true;
            this.btnDespacharPedido.Click += new System.EventHandler(this.btnDespacharPedido_Click);
            // 
            // dgvDetallesPedidos
            // 
            this.dgvDetallesPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesPedidos.Location = new System.Drawing.Point(16, 16);
            this.dgvDetallesPedidos.Name = "dgvDetallesPedidos";
            this.dgvDetallesPedidos.Size = new System.Drawing.Size(359, 224);
            this.dgvDetallesPedidos.TabIndex = 7;
            // 
            // btnSeleccionarPedido
            // 
            this.btnSeleccionarPedido.Location = new System.Drawing.Point(169, 400);
            this.btnSeleccionarPedido.Name = "btnSeleccionarPedido";
            this.btnSeleccionarPedido.Size = new System.Drawing.Size(116, 23);
            this.btnSeleccionarPedido.TabIndex = 6;
            this.btnSeleccionarPedido.Text = "Seleccionar pedido";
            this.btnSeleccionarPedido.UseVisualStyleBackColor = true;
            this.btnSeleccionarPedido.Click += new System.EventHandler(this.btnSeleccionarPedido_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(28, 71);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(391, 309);
            this.dgvPedidos.TabIndex = 0;
            // 
            // FormDespachoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 771);
            this.Controls.Add(this.btnSeleccionarPedido);
            this.Controls.Add(this.pnlCrearPedido);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label1);
            this.Name = "FormDespachoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDespachoPedido";
            this.Load += new System.EventHandler(this.FormDespachoPedido_Load);
            this.pnlCrearPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCrearPedido;
        private System.Windows.Forms.Button btnSeleccionarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnDespacharPedido;
        private System.Windows.Forms.DataGridView dgvDetallesPedidos;
    }
}