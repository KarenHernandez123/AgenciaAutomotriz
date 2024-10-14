using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramientas
    {
        public Herramientas(int idHerramienta, string codigoBarras, string nombre, string medida, string marca, string descripcion)
        {
            this.idHerramienta = idHerramienta;
            CodigoBarras = codigoBarras;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public int idHerramienta { get; set; }
        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
