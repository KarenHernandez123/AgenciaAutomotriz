using Acceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using Mnaejador;

namespace Mnaejador
{
    public class ManejadorHerramientas
    {
        Funciones f = new Funciones();

        public void Guardar(TextBox CodigoBarras, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            string query = $"insert into Herramientas values(null, '{CodigoBarras.Text}', '{Nombre.Text}', '{Medida.Text}', '{Marca.Text}', '{Descripcion.Text}')";
            MessageBox.Show(f.Guardar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int id, string dato)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar la herramienta: {dato}?", "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                f.Borrar($"delete from Herramientas where idHerramienta = {id}");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(TextBox CodigoBarras, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion, int idHerramienta)
        {
            string query = $"update Herramientas set CodigoBarras = '{CodigoBarras.Text}', " +
                           $"Nombre = '{Nombre.Text}', Medida = '{Medida.Text}', Marca = '{Marca.Text}', Descripcion = '{Descripcion.Text}' " +
                           $"where idHerramienta = {idHerramienta}";

            MessageBox.Show(f.Modificar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataGridViewButtonColumn Boton(string texto, Color color)
        {
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.Text = texto;
            boton.UseColumnTextForButtonValue = true;
            boton.FlatStyle = FlatStyle.Popup;
            boton.DefaultCellStyle.BackColor = color;
            boton.DefaultCellStyle.ForeColor = Color.White;
            return boton;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"Select * from Herramientas where Nombre like '%{filtro}%'", "Herramientas").Tables[0];
            tabla.Columns.Insert(5, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(6, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
