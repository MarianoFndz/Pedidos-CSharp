using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class Producto
    {
        #region VM
        private int id;
        private string nombre;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion

        #region Constructor
        public Producto()
        {
            this.id = 0;
            this.nombre = "";
        }
        public Producto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return id + "-" + Nombre ;
        }
        #endregion
    }
}
