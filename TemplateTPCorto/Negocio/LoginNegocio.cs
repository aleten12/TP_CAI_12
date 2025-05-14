using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            List<string> registros = File.ReadAllLines("credenciales.csv").ToList();
            Credencial credencial = usuarioPersistencia.login(usuario);

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

            RegistrarIntentoFallido(credencial.Legajo);

            if (ObtenerIntentosFallidos(credencial.Legajo) >= MAX_INTENTOS)
            {
                BloquearUsuario(credencial.Legajo);
                EsBloqueado = true;
            }

            return null;
        }
        private void RegistrarIntentoFallido(string legajo)
        {
            List<string> intentos = new List<string>();

            if (File.Exists("login_intentos.csv"))
            {
                string[] lineas = File.ReadAllLines("login_intentos.csv");
                for (int i = 0; i < lineas.Length; i++)
                {
                    intentos.Add(lineas[i]);
                }
            }

            bool encontrado = false;

            for (int i = 0; i < intentos.Count; i++)
            {
                string intento = intentos[i];
                if (intento.StartsWith(legajo + ","))
                {
                    string[] partes = intento.Split(',');
                    int cantidad = int.Parse(partes[1]);
                    cantidad += 1;
                    intentos[i] = legajo + "," + cantidad.ToString();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                intentos.Add(legajo + ",1");
            }

            File.WriteAllLines("login_intentos.csv", intentos.ToArray());

        }

        private int ObtenerIntentosFallidos(string legajo)
        {
            if (!File.Exists("login_intentos.csv"))
                return 0;

            var intento = File.ReadAllLines("login_intentos.csv").FirstOrDefault(x => x.StartsWith(legajo + ","));
            if (intento == null)
                return 0;

            return int.Parse(intento.Split(',')[1]);
        }

        private void ResetearIntentos(string legajo)
        {
            if (!File.Exists("login_intentos.csv"))
                return;

            var intentos = File.ReadAllLines("login_intentos.csv").ToList();
            var intento = intentos.FirstOrDefault(x => x.StartsWith(legajo + ","));
            if (intento != null)
            {
                intentos.Remove(intento);
                File.WriteAllLines("login_intentos.csv", intentos);
            }
        }

        private void BloquearUsuario(string legajo)
        {
            var bloqueados = File.Exists("usuario_bloqueado.csv")
                ? File.ReadAllLines("usuario_bloqueado.csv").ToList()
                : new List<string>();

            if (!bloqueados.Contains(legajo))
            {
                bloqueados.Add(legajo);
                File.WriteAllLines("usuario_bloqueado.csv", bloqueados);
            }

        }

    }
}
