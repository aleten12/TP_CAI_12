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

            if (credencial != null)
            {
                // Verificar si el cambio de contraseña debe ser forzado
                if (contrasenaNegocio.DebeForzarCambio(credencial))
                {
                    MessageBox.Show("Han pasado más de 30 días desde el último cambio de contraseña. Se debe realizar el cambio de contraseña");
                    FormContrasena formContrasena = new FormContrasena();
                    formContrasena.UsuarioAutenticado = credencial;
                    formContrasena.Show();
                }
                else
                {
                    // Si no es necesario el cambio de contraseña, continuar con el Perfil
                    SeguridadPersistencia seguridadPersistencia = new SeguridadPersistencia();
                    List<Rol> rolesDelUsuario = seguridadPersistencia.ObtenerRolesPorPerfil(credencial.Legajo);

                    if (rolesDelUsuario.Count == 1)
                    {
                        string descripcionRol = rolesDelUsuario[0]._descripcion;

                        if (descripcionRol == "Supervisor")
                        {
                            FormSupervisor formSupervisor = new FormSupervisor();
                            formSupervisor.Show();
                        }
                        else if (descripcionRol == "Operador")
                        {
                            FormOperador formOperador = new FormOperador();
                            formOperador.Show();
                        }
                        else if (descripcionRol == "Administrador")
                        {
                            FormAdministrador formAdministrador = new FormAdministrador();
                            formAdministrador.Show();
                        }

                        this.Hide();
                    }
                    else if (rolesDelUsuario.Count > 1)
                    {
                        FormSeleccionRol formSeleccionRol = new FormSeleccionRol(rolesDelUsuario);

                        if (formSeleccionRol.ShowDialog() == DialogResult.OK)
                        {
                            Rol rolElegido = formSeleccionRol.RolSeleccionado;

                            if (rolElegido._descripcion == "Supervisor")
                            {
                                FormSupervisor formSupervisor = new FormSupervisor();
                                formSupervisor.Show();
                            }
                            else if (rolElegido._descripcion == "Operador")
                            {
                                FormOperador formOperador = new FormOperador();
                                formOperador.Show();
                            }
                            else if (rolElegido._descripcion == "Administrador")
                            {
                                FormAdministrador formAdministrador = new FormAdministrador();
                                formAdministrador.Show();
                            }

                            this.Hide();
                        }
            }
            else
                    {
                        MessageBox.Show("No se encontraron roles asociados al usuario.");
                    }
                }
            }
        }
    }
}

                
    


