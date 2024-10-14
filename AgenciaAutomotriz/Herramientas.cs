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
        ManejadorHerramientas mh;
        int fila = 0, columna = 0;
        public static int idHerramienta = 0;
        public static string CodigoBarrras = "", Nombre = "", medida = "", Descripcion = "", Marca = "";

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dtgvHerramientas.Visible = true;
            mh.Mostrar(dtgvHerramientas, txtNombre.Text);
        }

        public Herramientas(string nombreUsuario)
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            idHerramienta = 0; CodigoBarrras = ""; Nombre = ""; medida = "", Descripcion = ""; Marca = "";
            DatosHerramienta dh = new DatosHerramienta();
            dh.ShowDialog();
            mh.Mostrar(dtgvHerramientas, txtNombre.Text);
            txtNombre.Focus();
        }

        private void dtgvHerramientas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            if (fila >= 0)
            {

                switch (columna)
                {
                    case 6:
                        {
                            idHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                            mh.Borrar(idHerramienta, dtgvHerramientas.Rows[fila].Cells[1].Value.ToString());
                            dtgvHerramientas.Visible = false;
                            mh.Mostrar(dtgvHerramientas, txtNombre.Text);
                        }
                        break;
                    case 7:
                        {
                            idHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                            CodigoBarrras = dtgvHerramientas.Rows[fila].Cells[1].Value.ToString();
                            Nombre = dtgvHerramientas.Rows[fila].Cells[2].Value.ToString();
                            Descripcion = dtgvHerramientas.Rows[fila].Cells[3].Value.ToString();
                            medida = dtgvHerramientas.Rows[fila].Cells[4].Value.ToString();
                            Marca = dtgvHerramientas.Rows[fila].Cells[5].Value.ToString();
                            DatosHerramientas dh = new DatosHerramientas();
                            dh.ShowDialog();
                            dtgvHerramientas.Visible = false;
                            mh.Mostrar(dtgvHerramientas,txtNombre.Text);
                        }
                        break;

                }
            }
        }
    }
}
