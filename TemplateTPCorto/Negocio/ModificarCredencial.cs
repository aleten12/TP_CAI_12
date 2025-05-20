using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Seguridad;
using Persistencia.DataBase;

namespace Negocio
{
    public class ModificarCredencial
    {
        public bool CambiarContrasena(string legajo, string nuevaContrasena)
        {
            if (string.IsNullOrWhiteSpace(legajo) || string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                return false;
            }

            DataBaseUtils db = new DataBaseUtils();
            List<string> registros = db.BuscarRegistro("credenciales.csv");
            bool modificado = false;
            string nombreUsuario = "";
            string fechaAlta = "";

            for (int i = 1; i < registros.Count; i++)
            {
                string[] campos = registros[i].Split(';');

                if (campos[0] == legajo)
                {
                    nombreUsuario = campos[1];
                    campos[2] = nuevaContrasena;
                    fechaAlta = campos[3];
                    campos[4] = "";

                    registros[i] = string.Join(";", campos);
                    modificado = true;
                    break;
                }
            }

            string idPerfil = "";
            List<string> usuarioPerfil = db.BuscarRegistro("usuario_perfil.csv");
            foreach (string linea in usuarioPerfil.Skip(1))
            {
                string[] campos = linea.Split(';');
                if (campos[0] == legajo)
                {
                    idPerfil = campos[1];
                    break;
                }
            }

            RegistrarLinea(legajo, nombreUsuario, nuevaContrasena, idPerfil, fechaAlta);

            return modificado;
        }

        public void RegistrarLinea(string legajo, string nombreUsuario, string nuevaContrasena, string idPerfil, string fechaAlta)
        {
            string idOperacion = Guid.NewGuid().ToString();
            string nuevaOperacion = string.Join(";", new string[]
            {
            idOperacion,
            legajo,
            nombreUsuario,
            nuevaContrasena,
            idPerfil,
            fechaAlta,
            "" // fechaUltimoLogin vacía
            });

            DataBaseUtils db = new DataBaseUtils();
            db.AgregarRegistro("operacion_cambio_credencial.csv", nuevaOperacion);
        }

    }
}
