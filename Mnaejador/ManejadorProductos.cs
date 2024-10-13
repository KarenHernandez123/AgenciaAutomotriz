using Acceso;
/*using Entidades;*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnaejador
{
    public class ManejadorProductos
    {
        private Funciones funciones;

        public ManejadorProductos()
        {
            funciones = new Funciones();
        }

       /* public void AgregarProducto(Producto producto)
        {
            string query = $"INSERT INTO Productos (codigoBarras, nombre, descripcion, marca) VALUES ('{producto.CodigoBarras}', '{producto.Nombre}', '{producto.Descripcion}', '{producto.Marca}')";
            funciones.Guardar(query);
        }

        public DataSet ObtenerProductos()
        {
            string query = "SELECT * FROM Productos";
            return funciones.Mostrar(query, "Productos");
        }

        public void EliminarProducto(string codigoBarras)
        {
            string query = $"DELETE FROM Productos WHERE codigoBarras = '{codigoBarras}'";
            funciones.Borrar(query);
        }

        public void ActualizarProducto(Producto producto)
        {
            string query = $"UPDATE Productos SET nombre = '{producto.Nombre}', descripcion = '{producto.Descripcion}', marca = '{producto.Marca}' WHERE codigoBarras = '{producto.CodigoBarras}'";
            funciones.Modificar(query);
        }*/
    }
}
