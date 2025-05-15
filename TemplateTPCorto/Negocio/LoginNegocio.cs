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

        public Credencial login(String usuario, String password)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            Credencial credencial = usuarioPersistencia.login(usuario);
            DataBaseUtils db = new DataBaseUtils();
            List<String> registros = db.BuscarRegistro("credenciales.csv");

            if (credencial == null)
            {
                return null;
            }

            // Ver si esta bloqueado
            if (usuarioPersistencia.UsuarioBloqueado(credencial.Legajo))
            {
                EsBloqueado = true;
                return null;
            }

            if (credencial.Contrasena == password)
            {
                // Verificar si es primer login
                if (usuarioPersistencia.UsuarioPrimerLogin(registros, credencial.Legajo))
                {
                    EsPrimerLogin = true;
                }

                // Resetear intentos al loguear correctamente
                ResetearIntentos(credencial.Legajo);
                return credencial;

            } 
            else
            { 
                RegistrarIntentoFallido(credencial.Legajo);

                if (ObtenerIntentosFallidos(credencial.Legajo) >= MAX_INTENTOS)
                {
                    BloquearUsuario(credencial.Legajo);
                    EsBloqueado = true;
                }
                return null;
            }
        }
        private void RegistrarIntentoFallido(string legajo)
        {
            DataBaseUtils db = new DataBaseUtils();
            List<string> registro = db.BuscarRegistro("login_intentos.csv");

            bool encontrado = false;

            for (int i = 0; i < registro.Count; i++)
            {
                string linea = registro[i];
                if (linea.StartsWith(legajo + ";"))
                {
                    string[] partes = linea.Split(';');
                    int cantidad = int.Parse(partes[1]);
                    cantidad += 1;
                    string nuevaLinea = $"{legajo};{cantidad};{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                    registro[i] = nuevaLinea;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                string nuevaLinea = $"{legajo};1;{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                registro.Add(nuevaLinea);
            }

            db.SobrescribirArchivo("login_intentos.csv", registro);

        }

        private int ObtenerIntentosFallidos(string legajo)
        {
            if (!File.Exists("login_intentos.csv"))
            { return 0; }

            DataBaseUtils db = new DataBaseUtils();
            List<string> registro = db.BuscarRegistro("login_intentos.csv");

            foreach (string linea in registro)
            {
                var partes = linea.Split(';');
                if (partes[0] == legajo)
                {
                    return int.Parse(partes[1]);
                }
            }

            return 0; // Si no hay intentos, asumimos 0
        }

        private void ResetearIntentos(string legajo)
        {
            DataBaseUtils db = new DataBaseUtils();
            List<string> registro = db.BuscarRegistro("login_intentos.csv");

            bool actualizado = false;

            for (int i = 0; i < registro.Count; i++)
            {
                var partes = registro[i].Split(';');
                if (partes[0] == legajo)
                {
                    string nuevaLinea = $"{legajo};0;{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                    registro[i] = nuevaLinea;
                    actualizado = true;
                    break;
                }
            }

            if (!actualizado)
            {
                // Por si no existía registro antes
                registro.Add($"{legajo};0;{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            }

            db.SobrescribirArchivo("login_intentos.csv", registro);
        }

        private void BloquearUsuario(string legajo)
        {
            DataBaseUtils db = new DataBaseUtils();
            List<string> bloqueados = db.BuscarRegistro("usuario_bloqueado.csv");

            if (!bloqueados.Contains(legajo))
            {
                bloqueados.Add(legajo);
                db.SobrescribirArchivo("usuario_bloqueado.csv", bloqueados);
            }

        }

    }
}
