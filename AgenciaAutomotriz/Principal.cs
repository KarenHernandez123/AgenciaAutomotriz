using Entidades;
using Mnaejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaAutomotriz
{
    public partial class Principal : Form
    {
        private string nombreUsuario;
        public Principal(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            /*Manejadorlogin manejadorLogin = new Manejadorlogin();

            if (manejadorLogin.TienePermiso(nombreUsuario, "FrmHerramientas"))
            {
                Herramientas frmHerramientas = new Herramientas(nombreUsuario);
                frmHerramientas.Show();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a este formulario.");
            }*/
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            /*Manejadorlogin manejadorLogin = new Manejadorlogin();

            if (manejadorLogin.TienePermiso(nombreUsuario, "FrmProductos"))
            {
                Productos frmProductos = new Productos(nombreUsuario);
                frmProductos.Show();
            }
            else
            {
                MessageBox.Show("No tiene permiso para acceder a este formulario.");
            }*/
        }
    }
}
