using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;

            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            LoginNegocio loginNegocio = new LoginNegocio();
            Credencial credencial = loginNegocio.login(usuario, password);

            if (loginNegocio.EsBloqueado)
            {
                MessageBox.Show("El usuario está bloqueado.");
                return;
            }

            if (credencial == null)
            {

                MessageBox.Show("Usuario o contraseña inválido");
            }

            
            // Verificar si es primer login
            if (loginNegocio.EsPrimerLogin)
            {
                MessageBox.Show("Este es tu primer ingreso. Debés cambiar tu contraseña.", "Primer Login", MessageBoxButtons.OK);

                FormContrasena formContrasena = new FormContrasena();
                formContrasena.UsuarioAutenticado = credencial;
                formContrasena.Show();
                this.Hide();
                return;
            }


            ContrasenaNegocio contrasenaNegocio = new ContrasenaNegocio();

            // Verificar si el cambio de contraseña debe ser forzado
            if (contrasenaNegocio.DebeForzarCambio(credencial))
            {
                DialogResult respuesta = MessageBox.Show(
                   "Han pasado más de 30 días desde el último cambio de contraseña. ¿Quieres cambiar tu contraseña ahora?",
                    "Cambio de contraseña",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // Abrir el formulario de cambio de contraseña
                    FormContrasena formContrasena = new FormContrasena();
                    formContrasena.UsuarioAutenticado = credencial;
                    formContrasena.Show();
                }
            }
            else
            {
                // Si no es necesario el cambio de contraseña, continuar con el flujo normal
                MessageBox.Show("Ingreso exitoso.");
            }

        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
