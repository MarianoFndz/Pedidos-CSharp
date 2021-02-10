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
    public partial class FormCrearPedido : Form
    {
        private Pedido pedido;
        private List<DetallePedido> detallesPedidos = new List<DetallePedido>();

        public FormCrearPedido()
        {
            InitializeComponent();
            SetEstadoPanel(false);    
        }
        #region Eventos
        private void nudCrearPedido_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCrearPedidoTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                pedido = new Pedido();
                SetDataGrid();
                SetEstadoPanel(true); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                     
         }

        private void btnAgregarDetallePedido_Click(object sender, EventArgs e)
        {
            try
            {
                var productoSelec = ObtenerSeleccionado();
                if (productoSelec == null)
                    throw new Exception("Seleccione un producto");

                var cantidad = Convert.ToInt32(nudCrearPedido.Value);
                var detallePedido = new DetallePedido();
                detallePedido.Cantidad = cantidad;
                detallePedido.Producto = productoSelec;
                detallesPedidos.Add(detallePedido);
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnTerminarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                SetDatosPedido(pedido);
                pedido.Guardar();
            
                var pedidoActual = Pedido.BuscarPedidoActual();

                GuardarDP( detallesPedidos, pedidoActual);
                ResetListDetallePedido(detallesPedidos);

                SetEstadoPanel(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion



        #region Metodos
        private void SetDataGrid()
        {
            dgvCrearPedido.DataSource = Producto.BuscarIQ();
        }

        private Producto ObtenerSeleccionado()
        {
            var producto = Producto.BuscarPorId(Convert.ToInt16(dgvCrearPedido.CurrentRow.Cells["Id"].Value));
            return producto;
        }

        private void SetEstadoPanel(bool estado)
        {
            pnlCrearPedido.Enabled = estado;
        }

        private void SetDatosPedido(Pedido pedido)
        {
            pedido.Direccion = txbDireccion.Text;
            pedido.FkUsuario = Usuario.usuarioActual.Id;
        }

        private void GuardarDP(List<DetallePedido> detallesPedidos, Pedido pedidoActual)
        {
            foreach (var dt in detallesPedidos)
            {
                dt.FkPedido = pedidoActual.Id;
                dt.Guardar();
            }
        }

        private void ResetListDetallePedido(List<DetallePedido> detallesPedido)
        {
            detallesPedidos = new List<DetallePedido>();
        }
        #endregion

    }
}
