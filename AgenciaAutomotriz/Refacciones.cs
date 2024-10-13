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
    public partial class Refacciones : Form
    {
        ManejadorRefacciones mr;
        int fila = 0, columna = 0;
        public static int idRefaccion = 0;
        public static string CodigoBarrras = "", Nombre = "", Descripcion = "", Marca = "";

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            idRefaccion = 0; CodigoBarrras = ""; Nombre = ""; Descripcion= "";Marca = "";
            DatosRefacciones de = new DatosRefacciones();
            de.ShowDialog();
            mr.Mostrar(dtgvRefacciones, txtbuscarRefacciones.Text);
            txtbuscarRefacciones.Focus();
        }

        private void txtbuscarRefacciones_TextChanged(object sender, EventArgs e)
        {
            dtgvRefacciones.Visible = true;
            mr.Mostrar(dtgvRefacciones, txtbuscarRefacciones.Text);
        }

        public Refacciones()
        {
            InitializeComponent();
            mr = new ManejadorRefacciones();
        }

        private void dtgvRefacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            if (fila >= 0)
            {

                switch (columna)
                {
                    case 5:
                        {
                            idRefaccion = int.Parse(dtgvRefacciones.Rows[fila].Cells[0].Value.ToString());
                            mr.Borrar(idRefaccion, dtgvRefacciones.Rows[fila].Cells[1].Value.ToString());
                            dtgvRefacciones.Visible = false;
                            mr.Mostrar(dtgvRefacciones, txtbuscarRefacciones.Text);
                        }
                        break;
                    case 6:
                        {
                            idRefaccion = int.Parse(dtgvRefacciones.Rows[fila].Cells[0].Value.ToString());
                            CodigoBarrras = dtgvRefacciones.Rows[fila].Cells[1].Value.ToString();
                            Nombre = dtgvRefacciones.Rows[fila].Cells[2].Value.ToString();
                            Descripcion = dtgvRefacciones.Rows[fila].Cells[3].Value.ToString();
                            Marca = dtgvRefacciones.Rows[fila].Cells[4].Value.ToString();
                            DatosRefacciones dr = new DatosRefacciones();
                            dr.ShowDialog();
                            dtgvRefacciones.Visible = false;
                            mr.Mostrar(dtgvRefacciones, txtbuscarRefacciones.Text);
                        }
                        break;

                }
            }
        }

    }
}
