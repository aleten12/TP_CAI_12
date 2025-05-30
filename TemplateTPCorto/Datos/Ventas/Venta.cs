using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Ventas
{
    public class Venta
    {
        Guid _IdCliente;
        Guid _IdUsuario;
        Guid _IdProducto;
        int _Cantidad;

        public Guid IdCliente { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdProducto { get; set; }
        public int Cantidad { get; set; }

    }
}
