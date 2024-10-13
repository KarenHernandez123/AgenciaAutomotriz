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
    public partial class DatosUsuario : Form
    {
        ManejadorUsuarios mu;
        public DatosUsuario()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string fechaNacimiento = txtFechaNacimiento.Value.ToString("yyyy-MM-dd");

            if (Usuarios.idUsuarios > 0)
            {
                // Llamada a modificar con el valor formateado de la fecha
                mu.Modificar(txtnombre, txtApellidoPaterno, txtApellidoMaterno, txtFechaNacimiento, txtRfc, txtContraseña, Usuarios.idUsuarios);
            }
            else
            {
                // Llamada a guardar con el valor formateado de la fecha
                mu.Guardar(txtnombre, txtApellidoPaterno, txtApellidoMaterno, txtFechaNacimiento, txtRfc, txtContraseña);
            }
            Close();
        }
    }
}
