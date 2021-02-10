using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class DetallePedido
    {
        #region VM
        private int id;
        private Producto producto;
        private int fkProducto;
        private int cantidad;
        private Pedido pedido;
        private int fkPedido;
        #endregion

        #region Propiedades
        public int FkProducto { get => fkProducto; set => fkProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Producto Producto
        {
            get { return producto; }
            set
            {
                producto = value;
                fkProducto = value.Id;
            }
        }

        public Pedido Pedido
        {
            get => pedido;
            set
            {
                pedido = value;
                fkPedido = value.Id;
            }
        }
        public int FkPedido { get => fkPedido; set => fkPedido = value; }
        public int Id { get => id; set => id = value; }
        #endregion

        #region Constructor
        public DetallePedido()
        {
            this.Producto = null;
            this.fkProducto = 0;
            this.cantidad = 0;
            this.id = 0;
            this.pedido = null;
            this.fkPedido = 0;
        }

        public DetallePedido(Producto producto, int cantidad, int id, Pedido pedido )
        {
            this.producto = producto;
            this.fkProducto = producto.Id;
            this.cantidad = 0;
            this.id = id;
            this.pedido = pedido;
            this.fkPedido = pedido.Id;  
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return producto + "-" + cantidad;
        }
        #endregion
    }
}
