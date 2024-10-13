using Acceso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mnaejador
{
    public class ManejadorUsuarios
    {
        Funciones f = new Funciones();

        public void Guardar(TextBox Nombre, TextBox ApellidoPaterno,
            TextBox ApellidoMaterno, DateTimePicker FechaNacimiento, TextBox Rfc, TextBox contraseña)
        {
            string fechaFormateada = FechaNacimiento.Value.ToString("yyyy-MM-dd");

            string query = $"insert into Usuarios values(null,'{Nombre.Text}'," +
                           $"'{ApellidoPaterno.Text}','{ApellidoMaterno.Text}'," +
                           $"'{fechaFormateada}','{Rfc.Text}','{contraseña.Text}')";

            MessageBox.Show(f.Guardar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int id, string dato)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar {dato}?",
                "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                f.Borrar($"delete from Usuarios where idUsuario={id}");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(TextBox Nombre, TextBox ApellidoPaterno,
            TextBox ApellidoMaterno, DateTimePicker FechaNacimiento, TextBox Rfc, TextBox contraseña, int idUsuario)
        {
            string fechaFormateada = FechaNacimiento.Value.ToString("yyyy-MM-dd");

            string query = $"update Usuarios set Nombre = '{Nombre.Text}'," +
                           $"ApellidoPaterno='{ApellidoPaterno.Text}'," +
                           $"ApellidoMaterno='{ApellidoMaterno.Text}'," +
                           $"FechaNacimiento='{fechaFormateada}'," +
                           $"Rfc='{Rfc.Text}'," +
                           $"contraseña='{contraseña.Text}'" +
                           $" where idUsuario = {idUsuario}";

            MessageBox.Show(f.Modificar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para crear los botones en DataGridView
        DataGridViewButtonColumn Boton(string t, Color co)
        {
            DataGridViewButtonColumn bo = new DataGridViewButtonColumn();
            bo.Text = t;
            bo.UseColumnTextForButtonValue = true;
            bo.FlatStyle = FlatStyle.Popup;
            bo.DefaultCellStyle.BackColor = co;
            bo.DefaultCellStyle.ForeColor = Color.White;
            return bo;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
           tabla.DataSource = f.Mostrar($"Select * from usuarios where Nombre like '%{filtro}%'", "Usuarios").Tables[0];
            tabla.Columns.Insert(7, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(8, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
