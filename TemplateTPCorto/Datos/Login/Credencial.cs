using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Credencial
    {
        private String _legajo;
        private String _nombreUsuario;
        private String _contrasena;
        private DateTime _fechaAlta;
        private DateTime _fechaUltimoLogin;

        public string Legajo { get => _legajo; set => _legajo = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime FechaUltimoLogin { get => _fechaUltimoLogin; set => _fechaUltimoLogin = value; }


        public Credencial(String registro)
        {
            String[] datos = registro.Split(';');
            this._legajo = datos[0];
            this._nombreUsuario = datos[1];
            this._contrasena = datos[2];
            this._fechaAlta = DateTime.ParseExact(datos[3], "d/M/yyyy", CultureInfo.InvariantCulture);
            this._fechaUltimoLogin = DateTime.ParseExact(datos[4], "d/M/yyyy", CultureInfo.InvariantCulture);


        }

    }
}
