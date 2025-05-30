using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Ventas
{
    public class ResultadoVenta
    {
        bool _Exito;
        Guid _IdProducto;
        string _ErrorMensaje;

        public bool Exito { get; set; }
        public Guid IdProducto { get; set; }
        public string ErrorMensaje { get; set; }
    }
}
