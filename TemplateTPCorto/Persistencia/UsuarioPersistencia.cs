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
        
    }
}
