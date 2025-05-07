using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        public bool EsBloqueado { get; set; } = false;

        public Credencial login(String usuario, String password)
        {
            UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();
            
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

            if (credencial.Contrasena.Equals(password))
            {
                return credencial;
            }

            return null;
        }
    }

}
