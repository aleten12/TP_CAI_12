using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace TemplateTPCorto
{
    public partial class FormContrasena : Form
    {
        public FormContrasena()
        {
            InitializeComponent();
        }
        public Credencial UsuarioAutenticado { get; set; }

        private void btbActualizarContraseña_Click(object sender, EventArgs e)
        {
            
            string actual = txtContrasenaActual.Text;
            string nueva = txtContrasenaNueva.Text;

            ContrasenaNegocio negocio = new ContrasenaNegocio();

            if (UsuarioAutenticado == null)
            {
                MessageBox.Show("No hay un usuario autenticado.", "Error");
            }

            bool resultadoCambiarContrasena = negocio.CambiarContrasena(UsuarioAutenticado, actual, nueva);

            if (resultadoCambiarContrasena)
            {
                MessageBox.Show("Se ha cambiado la contraseña correctamente.");
            }
            else
            {
                MessageBox.Show("Error al cambiar la contraseña. Asegurate de que la actual sea correcta" +
                    " y que la nueva cumpla los requisitos.", "Error");
            }
        }

       
    }
}
