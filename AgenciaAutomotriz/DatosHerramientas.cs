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
    public partial class DatosHerramientas : Form
    {
        ManejadorHerramientas mh;
        public DatosHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Herramientas.idHerramienta > 0)
            {
                // Llamada a modificar con el valor formateado de la fecha
                mh.Modificar(txtCodigoBarrras, txtNombre, txtDescripcion,txtMedida, txtMarca, Herramientas.idHerramienta);
            }
            else
            {
                // Llamada a guardar con el valor formateado de la fecha
                mh.Guardar(txtCodigoBarrras, txtNombre, txtDescripcion,txtMedida, txtMarca);
            }
            Close();

        }
    }
}
