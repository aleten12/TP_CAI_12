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
        private FormOperador formAnterior;
        public FormContrasena()
        {
            InitializeComponent();
        }

        private GUIPrincipal formPadre;
        public Credencial UsuarioAutenticado { get; set; }

        public FormContrasena(Credencial usuario, GUIPrincipal principal)
        {
            InitializeComponent();
            UsuarioAutenticado = usuario;
            formPadre = principal;
        }

        public FormContrasena(FormOperador operador)
        {
            InitializeComponent();
            formAnterior = operador;

            // Cuando se cierra esta ventana, que se muestre la anterior
            this.FormClosed += FormContrasena_FormClosed;
        }

        private void FormContrasena_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Show();
        }
        
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
                formPadre.AbrirFormInPanel(new FormLogin(formPadre));
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al cambiar la contraseña. Asegurate de que la actual sea correcta" +
                    " y que la nueva cumpla los requisitos.", "Error");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
