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
using Datos.Seguridad;
using Persistencia;

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
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

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
                MessageBox.Show("Usuario o contraseña inválido.");
                return;
            }

            // Si es el primer login
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

            // Si debe forzar el cambio de contraseña
            if (contrasenaNegocio.DebeForzarCambio(credencial))
            {
                MessageBox.Show("Han pasado más de 30 días desde el último cambio de contraseña. Se debe realizar el cambio de contraseña.");
                FormContrasena formContrasena = new FormContrasena();
                formContrasena.UsuarioAutenticado = credencial;
                formContrasena.Show();
                this.Hide();
                return;
            }

            // Si todo está bien, mostrar selección de perfil
            SeguridadPersistencia seguridadPersistencia = new SeguridadPersistencia();
            List<Perfil> perfilesDelUsuario = seguridadPersistencia.ObtenerPerfilesPorUsuario(credencial.Legajo);

            //Verifico si encuentro Perfil
            if (perfilesDelUsuario != null)
            {
                AbrirFormularioPorPerfil(perfilesDelUsuario[0]._descripcion);
           
            }
            else
            {
                MessageBox.Show("No se encontraron perfiles asociados al usuario.");
            }
        }

        private void AbrirFormularioPorPerfil(string descripcionPerfil)
        {
            if (descripcionPerfil == "Supervisor")
            {
                FormSupervisor formSupervisor = new FormSupervisor();
                formSupervisor.Show();
            }
            else if (descripcionPerfil == "Administrador") 
            {
                FormAdministrador formAdministrador = new FormAdministrador();
                formAdministrador.Show();
            }
            else if (descripcionPerfil == "Operador")
            {
                FormOperador formOperador = new FormOperador();
                formOperador.Show();
            }
            else
            {
                MessageBox.Show("Perfil desconocido: " + descripcionPerfil);
                return;
            }
            this.Hide();
        }
    }
}





