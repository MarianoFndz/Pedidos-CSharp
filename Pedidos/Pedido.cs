using System;

namespace CapaNegocio
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
        public bool Despachado { get => despachado; set => despachado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id { get => id; set => id = value; }
        internal Usuario Usuario
        {
            get => usuario;
            set { 
                usuario = value;
                fkUsuario = value.Id;
            }
        }
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
            this.fkUsuario = 0;
        }

        public Pedido(string direccion, int id, Usuario usuario)
        {
            this.fechaCreacion = DateTime.Now;
            this.fechaDespacho = new DateTime(1900, 1, 1);
            this.despachado = false;
            this.direccion = direccion;
            this.id = id;
            this.usuario = usuario;
            this.fkUsuario = usuario.Id;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return id + "-" + fechaCreacion + "-" + despachado;
        }
        #endregion

    }
}
