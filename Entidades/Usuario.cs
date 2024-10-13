using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public Usuario(int idUsuario, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string rfc, string contraseña)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            FechaNacimiento = fechaNacimiento;
            Rfc = rfc;
            Contraseña = contraseña;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Contraseña { get; set; }

    }
}
