using Datos;
using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuarioPersistencia
    {
        public Credencial login(string username)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<string> registros = dataBaseUtils.BuscarRegistro("credenciales.csv");
            Credencial credencial = buscarUsuario(registros, username);
            return credencial;

        }

        public Credencial buscarUsuario(List<string> registros, string username)
        {
            foreach (var registro in registros.Skip(1)) // Salta la primer linea de cabecera
            {
                string[] campos = registro.Split(';');

                if (campos[1].Equals(username))
                {
                    return new Credencial(registro);
                }
            }
            return null; // No se encontró el usuario
        }

        public bool UsuarioBloqueado(string legajo)
        {
            DataBaseUtils dbUtils = new DataBaseUtils();
            List<string> bloqueados = dbUtils.BuscarRegistro("usuario_bloqueado.csv");

            for (int i = 1; i < bloqueados.Count; i++) // Salteamos la cabecera
            {
                string legajoCsv = bloqueados[i].Trim();

                if (legajoCsv == legajo.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        public bool UsuarioPrimerLogin(List<string> registros, string username)
        {
            DataBaseUtils dbUtils = new DataBaseUtils();
            List<string> primerLogin = dbUtils.BuscarRegistro("credenciales.csv");

            foreach (var registro in registros.Skip(1)) // Salta la primer linea de cabecera
            {
                string[] campos = registro.Split(';');

                if (campos[1].Equals(username) && string.IsNullOrEmpty(campos[4]))
                {
                    return true;
                }
            }
            return false; // No es primer login
        }


    }
}
