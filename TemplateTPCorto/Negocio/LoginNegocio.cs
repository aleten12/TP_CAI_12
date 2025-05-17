using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Persistencia.DataBase;

namespace Negocio
{
    public class LoginNegocio
    {
        public bool EsBloqueado { get; set; } = false;
        public bool EsPrimerLogin { get; set; } = false;

        private int MAX_INTENTOS = 3;

        private readonly DataBaseUtils db = new DataBaseUtils();

        public Credencial login(string usuario, string password)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            Credencial credencial = usuarioPersistencia.login(usuario);

            if (credencial == null)
            {
                return null; 
            }

            if (UsuarioEstaBloqueado(credencial.Legajo))
            {
                EsBloqueado = true;
                return null;
            }

            if (credencial.Contrasena == password)
            {
                if (usuarioPersistencia.UsuarioPrimerLogin(credencial.Legajo))
                {
                    EsPrimerLogin = true; 
                }

                LimpiarIntentos(credencial.Legajo);
                return credencial;
            }
            else
            {
                Console.WriteLine("Login fallido para legajo: " + credencial.Legajo);
                RegistrarIntentoFallido(credencial.Legajo);

                int intentos = ContarIntentosFallidos(credencial.Legajo);
                Console.WriteLine($"Intentos fallidos actuales: {intentos}");

                if (intentos >= MAX_INTENTOS)
                {
                    Console.WriteLine($"Bloqueando usuario: {credencial.Legajo}");
                    BloquearUsuario(credencial.Legajo);
                    EsBloqueado = true;
                }

                return null;
            }
        }

        private bool UsuarioEstaBloqueado(string legajo)
        {
            List<string> bloqueados = db.BuscarRegistro("usuario_bloqueado.csv");
            return bloqueados.Any(leg => leg.Trim() == legajo);
        }

        private void RegistrarIntentoFallido(string legajo)
        {
            string linea = $"{legajo};{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            db.AgregarRegistro("login_intentos.csv", linea);
        }

        private int ContarIntentosFallidos(string legajo)
        {
            List<string> intentosArchivo = db.BuscarRegistro("login_intentos.csv");
            return intentosArchivo.Count(linea => linea.Trim().StartsWith(legajo.Trim() + ";"));
        }

        private void LimpiarIntentos(string legajo)
        {
            List<string> intentos = db.BuscarRegistro("login_intentos.csv");
            List<string> otrosLegajos = intentos.Where(l => !l.StartsWith(legajo + ";")).ToList(); //Filtra los intentos de los otros usuarios y "borra"/no guarada el del legajo
            db.SobrescribirArchivo("login_intentos.csv", otrosLegajos);
        }

        private void BloquearUsuario(string legajo)
        {
            List<string> bloqueados = db.BuscarRegistro("usuario_bloqueado.csv");
            if (!bloqueados.Contains(legajo))
            {
                bloqueados.Add(legajo);
                db.SobrescribirArchivo("usuario_bloqueado.csv", bloqueados);
            }
        }

    }
}
