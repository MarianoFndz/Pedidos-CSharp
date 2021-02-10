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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txbLoginUsuario.Text;
                var contraseña = txbLoginContraseña.Text;
                if (nombre == "" || contraseña == "")
                    throw new Exception("Ingrese todos los datos");

                    var usuario = Usuario.BuscarUsuario(nombre, contraseña);
                    if (usuario != null)
                    {
                        Usuario.usuarioActual = usuario;
                        if (nombre == "admin")
                        {
                            FormAdmin FormAdmin = new FormAdmin();
                            FormAdmin.ShowDialog();
                        }
                        else
                        {
                            FormPedido FormPedido = new FormPedido();
                            FormPedido.ShowDialog();
                        }
                    }
                    else
                        throw new Exception("Usuario o contraseña incorrectos");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
