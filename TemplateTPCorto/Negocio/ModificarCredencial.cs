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
        //USA SUPERVISOR
        public bool RegistrarCambioContrasena(string legajo, string nuevaContrasena)
        {
            if (string.IsNullOrWhiteSpace(legajo) || string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                return false;
            }

            if (nuevaContrasena.Length < 8)
            {
                return false;
            }

            DataBaseUtils db = new DataBaseUtils();
            List<string> registros = db.BuscarRegistro("credenciales.csv");
            string nombreUsuario = "";
            string idPerfil = "";
            string fechaAlta = "";
            string fechaUltimoLogin = "";

            foreach (string linea in registros.Skip(1))
            {
                string[] campos = linea.Split(';');

                if (campos[0] == legajo)
                {
                    nombreUsuario = campos[1];
                    fechaAlta = campos[3];
                    fechaUltimoLogin = "";
                    break;
                }
            }

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

            if (string.IsNullOrEmpty(nombreUsuario))
            {
                return false;
            }

            string idOperacion = Guid.NewGuid().ToString();

            string nuevaOperacion = string.Join(";", new string[]
            {
            idOperacion,
            legajo,
            nombreUsuario,
            nuevaContrasena,
            idPerfil,
            fechaAlta,
            fechaUltimoLogin
            });

            db.AgregarRegistro("operacion_cambio_credencial.csv", nuevaOperacion);

            return true;

        }

        //USA ADMINISTRADOR
        public bool AplicarCambioContrasena(string lineaOperacion)
        {
            if (string.IsNullOrWhiteSpace(lineaOperacion))
            {
                return false;
            }

            string[] campos = lineaOperacion.Split(';');
            string legajo = campos[1];
            string nuevaContrasena = campos[3];

            DataBaseUtils db = new DataBaseUtils();
            List<string> registros = db.BuscarRegistro("credenciales.csv");
            bool fueModificado = false;

            for (int i = 1; i < registros.Count; i++) 
            {
                string[] camposRegistro = registros[i].Split(';');
                
                if (camposRegistro[0] == legajo)
                {
                    camposRegistro[2] = nuevaContrasena; // cambiamos la contraseña
                    camposRegistro[4] = ""; //se pide vacio porque es un primer login
                    registros[i] = string.Join(";", camposRegistro);
                    fueModificado = true;
                    break;
                }
            }

            if (fueModificado)
            {
                db.SobrescribirArchivo("credenciales.csv", registros);
            }

            return fueModificado;
        }
    }

}

