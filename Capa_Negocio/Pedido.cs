using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Pedido
    {

        #region VM
        private int id;
        private bool despachado;
        private DateTime fechaCreacion;
        private DateTime fechaDespacho;
        private string direccion;
        private Usuario usuario;
        private int fkUsuario;

        #endregion

        #region Propiedades
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaDespacho { get => fechaDespacho; set => fechaDespacho = value; }
        public bool Despachado { get => despachado; 
            set
            {
                despachado = value;
            }
        }
        public string Direccion { get => direccion; 
            set
            {
                if (value.Trim() == "")
                    throw new Exception("Complete todos los campos");
                direccion = value;
            }
        }
        public int Id { get => id; set => id = value; }
        public  Usuario Usuario
        {
            get => usuario;
            set
            {
                if (value == null)
                    throw new Exception("Complete todos los campos");
                usuario = value;
                FkUsuario = value.Id;
            }
        }

        public int FkUsuario { get => fkUsuario; set => fkUsuario = value; }
        #endregion

        #region Constructor
        public Pedido()
        {
            this.fechaCreacion = DateTime.Now;
            this.fechaDespacho = new DateTime(1900, 1, 1);
            this.despachado = false;
            this.direccion = "";
            this.id = 0;
            this.usuario = null;
            this.FkUsuario = 0;
        }

        public Pedido(int id, string direccion, Usuario usuario)
        {
            this.fechaCreacion = DateTime.Now;
            this.fechaDespacho = new DateTime(1900, 1, 1);
            this.despachado = false;
            this.direccion = direccion;
            this.id = id;
            this.usuario = usuario;
            this.FkUsuario = usuario.Id;
        }

        public Pedido(int id, string direccion, Usuario usuario, DateTime fechaCreacion, DateTime fechaDespacho, bool despachado)
        {
            this.fechaCreacion = fechaCreacion;
            this.fechaDespacho = fechaDespacho;
            this.despachado = despachado;
            this.direccion = direccion;
            this.id = id;
            this.usuario = usuario;
            this.FkUsuario = usuario.Id;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return id + "-" + fechaCreacion + "-" + despachado;
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            ePedido newPedido = new ePedido();

            if (this.Id == 0)
            {
                SetDatos(newPedido);
                dc.ePedido.InsertOnSubmit(newPedido);
                dc.SubmitChanges();
                
            }
            else
            {
                var row = (from x in dc.ePedido where x.id == this.id select x).FirstOrDefault();
                if (row != null)
                {
                    SetDatos(row);
                    dc.SubmitChanges();
                }
                else
                    throw new Exception("Pedido no encontrado");

            }
        }

       private void SetDatos(ePedido newPedido)
        {
            newPedido.fechaCreacion = this.fechaCreacion;
            newPedido.fechaDespacho = this.fechaDespacho;
            newPedido.fkUsuario = this.FkUsuario;
            newPedido.direccion = this.direccion;
            newPedido.despachado = this.despachado;   
        }

        public static IQueryable BuscarIQ(string buscado = "")
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            buscado = buscado.ToLower().Trim();

            var res = from r in dc.ePedido
                      where
                      buscado == "" ||
                      r.direccion.ToString().Contains(buscado) 
                      select new
                      {
                          Id = r.id,
                          Direccion = r.direccion,
                          FechaCreacion = r.fechaCreacion,
                          FechaDespacho = r.fechaDespacho,
                          NombreUsuario = r.eUsuario.nombre,
                      };

            return res;

        }

        public static IQueryable BuscarNoDespachadosIQ()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());

            var res = from r in dc.ePedido
                      where
                       r.despachado == false
                      select new
                      {
                          Id = r.id,
                          Direccion = r.direccion,
                          FechaCreacion = r.fechaCreacion,
                          FechaDespacho = r.fechaDespacho,
                          Nombre = r.eUsuario.nombre,
                      };

            return res;
        }



        public static Pedido BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var res = (from m in dc.ePedido where m.id == id select m).FirstOrDefault();

            return new Pedido(
                Convert.ToInt32(res.id)
                , res.direccion
                , Usuario.BuscarPorId(Convert.ToInt32(res.fkUsuario))
                , Convert.ToDateTime(res.fechaCreacion)
                , Convert.ToDateTime(res.fechaDespacho)
                , Convert.ToBoolean(res.despachado));
        }

        public static Pedido BuscarPedidoActual()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var res = (from m in dc.ePedido orderby m.id descending select m).FirstOrDefault();

            return new Pedido(
                Convert.ToInt32(res.id)
                , res.direccion
                , Usuario.BuscarPorId(Convert.ToInt32(res.fkUsuario))
                , Convert.ToDateTime(res.fechaCreacion)
                , Convert.ToDateTime(res.fechaDespacho)
                , Convert.ToBoolean(res.despachado));
        }
        
        #endregion


    }
}
