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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            SetDataGridPedidos();
            SetEstadoPanelUsuarios(false);
            SetEstadoPanelProductos(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        #region Eventos        
        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                var pedidoSeleccionado = ObtenerSeleccionado();
                if(pedidoSeleccionado == null)
                    throw new Exception("Selecciona un pedido");
    
                SetDataGridDP(pedidoSeleccionado.Id);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProductoAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var newProducto = new Producto();
                SetDatosProducto(newProducto);
                newProducto.Guardar();
                SetEstadoPanelProductos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUsuarioAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SetEstadoPanelUsuarios(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProductoAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SetEstadoPanelProductos(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUsuarioAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var newUsuario = new Usuario();
                SetDatosUsuario(newUsuario);
                newUsuario.Guardar();
                SetEstadoPanelUsuarios(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Metodos
        private void SetDataGridDP(int fkPedido)
        {
            dgvDetalles.DataSource = DetallePedido.BuscarPorIdPedido(fkPedido);
        }

        private void SetDatosUsuario(Usuario newUsuario)
        {
            newUsuario.Nombre = txtUsuarioNombre.Text;
            newUsuario.Contraseña = txtUsuarioContraseña.Text;
        }

        private void SetDatosProducto(Producto newProducto)
        {
            newProducto.Nombre = txbProductoNombre.Text;
        }        
        
        private void SetEstadoPanelUsuarios(bool estado)
        {
            pnlUsuario.Enabled = estado;
        }

        private void SetEstadoPanelProductos(bool estado)
        {
            pnlProducto.Enabled = estado;
        }

        private void SetDataGridPedidos()
        {
            dgvCrearPedido.DataSource = Pedido.BuscarIQ();
        }

        private Pedido ObtenerSeleccionado()
        {
            var pedido = Pedido.BuscarPorId(Convert.ToInt16(dgvCrearPedido.CurrentRow.Cells["Id"].Value));
            return pedido;
        }

        #endregion
    }
}
