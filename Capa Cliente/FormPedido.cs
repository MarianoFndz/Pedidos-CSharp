using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Cliente
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            FormCrearPedido formCrearPedido = new FormCrearPedido();
            formCrearPedido.ShowDialog();
        }

        private void btnDespacharPedido_Click(object sender, EventArgs e)
        {
            FormDespachoPedido formDespachoPedido = new FormDespachoPedido();
            formDespachoPedido.ShowDialog();
        }
    }
}
