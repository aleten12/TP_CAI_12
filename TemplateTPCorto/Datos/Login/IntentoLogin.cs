using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Login
{
    public class IntentoLogin
    {
        private String _legajo;
        private DateTime _fechaIntento;

        public string Legajo { get => _legajo; set => _legajo = value; }
        public DateTime FechaIntento { get => _fechaIntento; set => _fechaIntento = value; }


        public IntentoLogin(String registro)
        {
            String[] datos = registro.Split(';');
            this._legajo = datos[0];
            this._fechaIntento = DateTime.ParseExact(datos[1], "d/M/yyyy", CultureInfo.InvariantCulture);
        }

    }
}
