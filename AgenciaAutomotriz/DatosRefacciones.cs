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
    public partial class DatosRefacciones : Form
    {
        ManejadorRefacciones mr;
        public DatosRefacciones()
        {
            InitializeComponent();
            mr =new ManejadorRefacciones();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (Refacciones.idRefaccion > 0)
            {
                // Llamada a modificar con el valor formateado de la fecha
                mr.Modificar(txtCodigoBarrras, txtNombre, txtDescripcion, txtMarca, Refacciones.idRefaccion);
            }
            else
            {
                // Llamada a guardar con el valor formateado de la fecha
                mr.Guardar(txtCodigoBarrras,txtNombre,txtDescripcion,txtMarca);
            }
            Close();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
