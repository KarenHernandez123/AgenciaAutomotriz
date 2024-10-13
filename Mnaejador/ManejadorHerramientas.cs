using Acceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using Entidades;*/
using System.Data;
using System.Windows.Forms;

namespace Mnaejador
{
    public class ManejadorHerramientas
    {
        private Funciones funciones;

        public ManejadorHerramientas()
        {
            funciones = new Funciones();
        }

      /*  public DataSet ObtenerHerramientas()
        {
            string query = "SELECT * FROM herramientas";
            return funciones.Mostrar(query, "herramientas");
        }

        public string AgregarHerramienta(Herramientas herramienta)
        {
            string query = $"INSERT INTO herramientas (CodigoBarras, Nombre, Medida, Marca, Descripcion) VALUES ('{herramienta.CodigoBarras}', '{herramienta.Nombre}', '{herramienta.Medida}', '{herramienta.Marca}', '{herramienta.Descripcion}')";
            return funciones.Guardar(query);
        }

        public string EliminarHerramienta(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string codigoBarras = dataGridView.SelectedRows[0].Cells["CodigoBarras"].Value.ToString();
                string query = $"DELETE FROM herramientas WHERE CodigoBarras = '{codigoBarras}'";
                funciones.Borrar(query);
                return "Herramienta eliminada con éxito.";
            }
            else
            {
                return "Por favor, selecciona una herramienta para eliminar.";
            }
        }*/
    }
}
