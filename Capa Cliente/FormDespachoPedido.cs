using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Cliente
{
    public partial class FormDespachoPedido : Form
    {
        private Pedido pedido;

        public FormDespachoPedido()
        {
            InitializeComponent();
            SetDataGridPedidos();
            SetEstadoPanelDetalles(false);
        }

        private void FormDespachoPedido_Load(object sender, EventArgs e)
        {

        }

        #region Eventos
        private void btnSeleccionarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                var pedidoSeleccionado = ObtenerPedidoSeleccionado();
                if (pedidoSeleccionado == null)
                    throw new Exception("Selecciona un pedido");

                SetDataGridDP(pedidoSeleccionado.Id);
                SetEstadoPanelDetalles(true);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDespacharPedido_Click(object sender, EventArgs e)
        {
            try
            {
                pedido.Despachado = true;
                pedido.FechaDespacho = DateTime.Now;
                pedido.Guardar();
                MessageBox.Show("Pedido Despachado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetEstadoPanelDetalles(false);
                SetDataGridPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Metodos        
        private void SetDataGridPedidos()
        {
            dgvPedidos.DataSource = Pedido.BuscarNoDespachadosIQ();
        }

        private void SetEstadoPanelDetalles(bool estado)
        {
            pnlCrearPedido.Enabled = estado;
        }



        private Pedido ObtenerPedidoSeleccionado()
        {
            pedido = Pedido.BuscarPorId(Convert.ToInt16(dgvPedidos.CurrentRow.Cells["Id"].Value));
            return pedido;
        }

        private void SetDataGridDP(int fkPedido)
        {
            dgvDetallesPedidos.DataSource = DetallePedido.BuscarPorIdPedido(fkPedido);
        }
        #endregion
    }
}
