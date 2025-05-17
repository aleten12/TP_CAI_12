using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Login
{
    public class Contrasena
    {
        private string _contrasenaActual;
        private string _contrasenaNueva;
        private DateTime? _fechaUltimoLogin;

        public string ContrasenaActual { get => _contrasenaActual; set => _contrasenaActual = value; }
        public string ContrasenaNueva {  get => _contrasenaNueva; set =>  _contrasenaNueva = value;}
        public DateTime? FechaUltimaLogin { get =>  _fechaUltimoLogin; set => _fechaUltimoLogin = value;}

        public Contrasena(Credencial credencial)
        {
            _contrasenaActual = credencial.Contrasena;
            _fechaUltimoLogin = credencial.FechaUltimoLogin;
        }
    }
}
