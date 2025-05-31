using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Ventas
{
    public class Producto
    {

        Guid _id;
        int _idCategoria;
        String _nombre;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        int _precio;
        int _stock;

        public Guid Id { get => _id; set => _id = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public override string ToString()
        {
            return Nombre + " - $" + Precio.ToString("0.00");
        }
    }
}
