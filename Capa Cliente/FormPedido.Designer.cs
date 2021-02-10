namespace Capa_Cliente
{
    partial class FormPedido
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
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.btnDespacharPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(36, 80);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(97, 23);
            this.btnCrearPedido.TabIndex = 0;
            this.btnCrearPedido.Text = "Crear pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // btnDespacharPedido
            // 
            this.btnDespacharPedido.Location = new System.Drawing.Point(170, 80);
            this.btnDespacharPedido.Name = "btnDespacharPedido";
            this.btnDespacharPedido.Size = new System.Drawing.Size(97, 23);
            this.btnDespacharPedido.TabIndex = 1;
            this.btnDespacharPedido.Text = "Despachar pedido";
            this.btnDespacharPedido.UseVisualStyleBackColor = true;
            this.btnDespacharPedido.Click += new System.EventHandler(this.btnDespacharPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDespacharPedido);
            this.Controls.Add(this.btnCrearPedido);
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Button btnDespacharPedido;
        private System.Windows.Forms.Label label1;
    }
}