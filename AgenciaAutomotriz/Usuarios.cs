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
    public partial class Usuarios : Form
    {
        ManejadorUsuarios mu;
        int fila = 0, columna = 0;
        public static int idUsuarios = 0;
        public static string Nombre = "", ApellidoPaterno = "", ApellidoMaterno = "", Rfc = "", contraseña = "";
        public Usuarios()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible = true;
            mu.Mostrar(dtgvUsuarios,txtusuario.Text);
        }

        private void dtgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            if (fila >= 0)
            {
                
                switch (columna)
                {
                    case 7:
                        {
                            idUsuarios = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                            mu.Borrar(idUsuarios, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString());
                            dtgvUsuarios.Visible = false;
                            mu.Mostrar(dtgvUsuarios, txtusuario.Text);
                        }
                        break;
                    case 8:
                        {
                            idUsuarios = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                            Nombre = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                            ApellidoPaterno = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                            ApellidoMaterno = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                            Rfc = dtgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                            contraseña = dtgvUsuarios.Rows[fila].Cells[6].Value.ToString(); 
                            DatosUsuario de = new DatosUsuario();
                            de.ShowDialog();
                            dtgvUsuarios.Visible = false;
                            mu.Mostrar(dtgvUsuarios, txtusuario.Text);
                        }
                        break;

                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            idUsuarios = 0; Nombre = ""; ApellidoPaterno = ""; ApellidoMaterno= ""; Rfc= ""; contraseña = "";
            DatosUsuario de = new DatosUsuario();
            de.ShowDialog();
            mu.Mostrar(dtgvUsuarios,txtusuario.Text);
            txtusuario.Focus();
        }
    }
}
