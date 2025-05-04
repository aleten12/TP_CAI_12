using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Login
{
    internal class Contrasena
    {
        private string _contrasenaActual;
        private string _contrasenaAnterior;
        private DateTime _fechaUltimaContrasena;

        public string ContrasenaActual { get => _contrasenaActual; set => _contrasenaActual = value; }
        public string ContrasenaAnterior {  get => _contrasenaAnterior; set =>  _contrasenaAnterior = value;}
        public DateTime FechaUltimaContrasena { get =>  _fechaUltimaContrasena; set => _fechaUltimaContrasena = value;}

        public Contrasena (string registro)
        {
            String[] datos = registro.Split(';');
            this._contrasenaActual = datos[0];
            this._contrasenaAnterior = datos[1];
            this._fechaUltimaContrasena = DateTime.ParseExact(datos[2], "d/M/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
