using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
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
        public int FkProducto { get => fkProducto; 
            set
            {
                if (value == 0)
                    throw new Exception("Complete todos los campos");
                fkProducto = value;
            }
        }
        public int Cantidad { get => cantidad; 
            set
            {
                if (value == 0)
                    throw new Exception("Complete todos los campos");
                cantidad = value;
            }
        }
        public Producto Producto
        {
            get { return producto; }
            set
            {
                if (value == null)
                    throw new Exception("Complete todos los datos");
                this.producto = value;
                this.fkProducto = value.Id;
            }
        }

        public Pedido Pedido
        {
            get => pedido;
            set
            {
                if (value == null)
                    throw new Exception("Complete todos los campos");
                this.pedido = value;
                this.fkPedido = value.Id;
            }
        }
        public int FkPedido { get => fkPedido; 
            set
            {
                if (value == 0)
                    throw new Exception("Complete todos los campos");
                fkPedido = value;
            }
        }
        public int Id { get => id; 
            set
            {
                if (value == 0)
                    throw new Exception("Complete todos los campos");
                id = value;
            }
        }
        #endregion

        #region Constructor
        public DetallePedido()
        {
            this.producto = null;
            this.fkProducto = 0;
            this.cantidad = 0;
            this.id = 0;
            this.pedido = null;
            this.fkPedido = 0;
        }

        public DetallePedido(Producto producto, int cantidad, int id, Pedido pedido)
        {
            this.producto = producto;
            this.fkProducto = producto.Id;
            this.cantidad = cantidad;
            this.id = id;
            this.pedido = pedido;
            this.fkPedido = pedido.Id;
        }

        public DetallePedido(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.fkProducto = producto.Id;
            this.cantidad = cantidad;
            this.id = 0;
            this.pedido = null;
            this.fkPedido = 0;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return producto + "-" + cantidad;
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eDetallePedido newDP = new eDetallePedido();

            if (this.Id == 0)
            {
                SetDatos(newDP);
                dc.eDetallePedido.InsertOnSubmit(newDP);
                dc.SubmitChanges();
            }
            else
            {
                var row = (from x in dc.eDetallePedido where x.id == this.id select x).FirstOrDefault();
                if (row != null)
                {
                    SetDatos(row);
                    dc.SubmitChanges();
                }
                else
                    throw new Exception("Detalle pedido no encontrado");

            }
        }

        public static IQueryable BuscarIQ(string buscado = "")
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            buscado = buscado.ToLower().Trim();

            var res = from r in dc.eDetallePedido
                      where
                      buscado == ""
                      select new
                      {
                          Id = r.id,
                          Producto = r.eProducto.nombre,
                          Cantidad = r.cantidad,
                          Pedido = r.fkPedido,
                      };

            return res;

        }

        public static DetallePedido BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var res = (from m in dc.eDetallePedido where m.id == id select m).FirstOrDefault();

            return new DetallePedido(
                Producto.BuscarPorId(Convert.ToInt32(res.fkProducto))
                , Convert.ToInt32(res.cantidad)
                ,res.id
                , Pedido.BuscarPorId(Convert.ToInt32(res.fkPedido)) );
        }

        public static IQueryable BuscarPorIdPedido(int fkPedido)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var res = from m in dc.eDetallePedido 
                      where m.fkPedido == fkPedido 
                      select new
                      {
                          Id = m.id,
                          Producto = m.eProducto.nombre,
                          Cantidad = m.cantidad,
                          Pedido = m.fkPedido,
                      };
            return res;
        }

        private void SetDatos(eDetallePedido newDP)
        {
            newDP.cantidad = this.cantidad;
            newDP.fkPedido = this.fkPedido;
            newDP.fkProducto = this.fkProducto;
        }
        #endregion
    }
}
