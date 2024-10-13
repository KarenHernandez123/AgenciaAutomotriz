using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso;


namespace Mnaejador
{
    public class Manejadorlogin
    {
       /* private Funciones manejador = new Funciones();

        public void ProcesarLogin(string nombre, string contraseña, Form formularioActual)
        {
            if (VerificarCredenciales(nombre, contraseña))
            {
                MessageBox.Show("Credenciales correctas.");
                Principal frmPrincipal = new Principal(nombre);
                frmPrincipal.Show();
                formularioActual.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
        private bool VerificarCredenciales(string nombre, string contraseña)
        {
            string query = $"SELECT * FROM Usuarios WHERE nombre = '{nombre}' AND contraseña = '{contraseña}'";
            return !string.IsNullOrEmpty(manejador.ObtenerDatos(query, "Usuarios", "nombre"));
        }
        
        public bool TienePermiso(string nombreUsuario, string formulario)
        {
            string query = $"SELECT * FROM Permisos WHERE nombreUsuario = '{nombreUsuario}' AND formulario = '{formulario}'";
            return manejador.ObtenerDatos(query, "Permisos", "nombreUsuario") != null;
        }*/
    }
}

