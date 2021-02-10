using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Usuario
    {
        public static Usuario usuarioActual;
        #region VM
        private int id;
        private string contraseña;
        private string nombre;

        #endregion

        #region Propiedades
        public int Id { get => id;
            set {
                if (value == 0)
                    throw new Exception("Complete todos los campos");
                id = value; 
            }
        }
        public string Contraseña { get => contraseña; 
            set
            {
             if (value.Trim() == "")
                throw new Exception("Complete todos los campos");
             contraseña = value;
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

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eUsuario newUsuario = new eUsuario();

            if (this.Id == 0)
            {
                SetDatos(newUsuario);
                dc.eUsuario.InsertOnSubmit(newUsuario);
                dc.SubmitChanges();

            }
            else
            {
                var row = (from x in dc.eUsuario where x.id == this.id select x).FirstOrDefault();
                if (row != null)
                {
                    SetDatos(row);
                    dc.SubmitChanges();
                }
                else
                    throw new Exception("Usuario no encontrado");

            }
        }

        private void SetDatos(eUsuario newUsuario)
        {
            newUsuario.nombre = this.nombre;
            newUsuario.contraseña = this.contraseña;
        }

        public static Usuario BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var res = (from m in dc.eUsuario where m.id == id select m).FirstOrDefault();

            return new Usuario(res.id, res.nombre, res.contraseña);
        }

        public static Usuario BuscarUsuario(string nombre, string contraseña)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());

            if(nombre == "admin")
            {
                var admin = (from r in dc.eUsuario
                           where
                           r.contraseña == contraseña
                           select r).FirstOrDefault();
                if (admin != null) {
                    return new Usuario(admin.id,admin.nombre, admin.contraseña); 
                } else {
                    return null;
                }
            }
            else
            {
                var res = (from r in dc.eUsuario
                             where
                             r.nombre == nombre &&
                             r.contraseña == contraseña
                             select r).FirstOrDefault();
                if(res != null)
                {
                    return new Usuario(res.id, res.nombre, res.contraseña);
                }
                else
                {
                    return null;
                }
            }

            


            
        }
        #endregion
    }
}
