using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso;
using Entidades;
using Mnaejador;

namespace AgenciaAutomotriz
{
    public partial class Herramientas : Form
    {
        ManejadorHerramientas manejadorHerramientas;
        string nombreUsuario;
        public Herramientas(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            manejadorHerramientas = new ManejadorHerramientas();
            //CargarHerramientas();
        }

       /* private void CargarHerramientas()
        {
            DataSet ds = manejadorHerramientas.ObtenerHerramientas();
            dtgvHerramientas.DataSource = ds.Tables[0];
        }*/

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           /* string resultado = manejadorHerramientas.EliminarHerramienta(dtgvHerramientas);
            MessageBox.Show(resultado);

            if (resultado == "Herramienta eliminada con éxito.")
            {
                CargarHerramientas(); 
            }*/

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*string resultado = manejadorHerramientas.AgregarHerramienta(herramienta);
            MessageBox.Show(resultado);
            CargarHerramientas();*/
        }
    }
}
