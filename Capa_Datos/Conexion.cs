using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public static class Conexion
    {
        private static string server = @"localhost\SQLEXPRESS";
        private static string db = @"Pedidos";
        private static string usuario = @"mariano";
        private static string clave = @"1234";

        public static string DarStrConexion()
        {
            return string.Concat(@"Data Source=", server, ";Initial Catalog=", db,
                ";Persist Security Info=False;User ID=", usuario, ";Password=", clave);
        }

    }
}
