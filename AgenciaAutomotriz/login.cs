using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mnaejador;

namespace AgenciaAutomotriz
{
    public partial class login : Form
    {
        Manejadorlogin manejadorlogin;
        public login()
        {
            InitializeComponent();
            manejadorlogin = new Manejadorlogin();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            /*string nombre = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            if (manejadorlogin.VerificarCredenciales(nombre, contraseña))
            {
                if (manejadorlogin.TienePermiso(nombre, "NombreDelFormulario"))
                {
                    Principal frmPrincipal = new Principal(nombre);
                    frmPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No tiene permiso para acceder a este formulario.");
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }*/
        }
    }
}