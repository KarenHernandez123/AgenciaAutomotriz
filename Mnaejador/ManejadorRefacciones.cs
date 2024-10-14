using Acceso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mnaejador;

namespace Mnaejador
{
    public class ManejadorRefacciones
    {
        Funciones f = new Funciones();

        public void Guardar(TextBox CodigoBarras, TextBox Nombre, TextBox Descripcion, TextBox Marca)
        {
            string query = $"insert into Refacciones values(null, '{CodigoBarras.Text}', '{Nombre.Text}', '{Descripcion.Text}', '{Marca.Text}')";
            MessageBox.Show(f.Guardar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Borrar(int id, string dato)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar la refacción: {dato}?", "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                f.Borrar($"delete from Refacciones where idRefaccion = {id}");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox CodigoBarras, TextBox Nombre, TextBox Descripcion, TextBox Marca, int idRefaccion)
        {
            string query = $"update Refacciones set CodigoBarras = '{CodigoBarras.Text}', " +
                           $"Nombre = '{Nombre.Text}', Descripcion = '{Descripcion.Text}', Marca = '{Marca.Text}' " +
                           $"where idRefaccion = {idRefaccion}";

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
            tabla.DataSource = f.Mostrar($"Select * from Refacciones where Nombre like '%{filtro}%'", "Refacciones").Tables[0];
            tabla.Columns.Insert(5, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(6, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}