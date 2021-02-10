using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class Usuario
    {
        #region VM
        private int id;
        private string contraseña;
        private string nombre;

        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion

        #region Constructor
        public Usuario()
        {
            this.id = 0;
            this.nombre = "";
            this.contraseña = "";
        }
        public Usuario(int id, string nombre, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return id + "-" + Nombre;
        }
        #endregion
    }
}
