using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Producto
    {
        #region VM
        private int id;
        private string nombre;

        #endregion

        #region Propiedades
        public int Id { get => id; 
            set
            {
                if (value == 0)
                    throw new Exception("Complete todos los campos");
                id = value;
            }
        }
        public string Nombre { get => nombre; 
            set
            {
                if (value.Trim() == "")
                    throw new Exception("Complete todos los campos");
                nombre = value;
            }
        }
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
            return id + "-" + Nombre;
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eProducto newProducto = new eProducto();

            if (this.Id == 0)
            {
                SetDatos(newProducto);
                dc.eProducto.InsertOnSubmit(newProducto);
                dc.SubmitChanges();

            }
            else
            {
                var row = (from x in dc.eProducto where x.id == this.id select x).FirstOrDefault();
                if (row != null)
                {
                    SetDatos(row);
                    dc.SubmitChanges();
                }
                else
                    throw new Exception("Producto no encontrado");

            }
        }

        private void SetDatos(eProducto newProducto)
        {
            newProducto.nombre = this.nombre;
        }

        public static IQueryable BuscarIQ(string buscado = "")
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            buscado = buscado.ToLower().Trim();

            var res = from r in dc.eProducto
                      where buscado == ""
                      || r.nombre.ToString().Contains(buscado) 
                      
                      select new
                      {
                          Id = r.id,
                          Nombre = r.nombre,
                      };

            return res;

        }

        public static Producto BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var res = (from m in dc.eProducto where m.id == id select m).FirstOrDefault();

            return new Producto(res.id, res.nombre);
        }
        #endregion
    }
}
