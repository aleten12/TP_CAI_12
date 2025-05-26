using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Ventas
{
    public class CategoriaProductos
    {
        String _id;
        String _detalle;

        public string Id { get => _id; set => _id = value; }
        public string Detalle { get => _detalle; set => _detalle = value; }

        public CategoriaProductos(string id, string detalle)
        {
            _id = id;
            _detalle = detalle;
        }

        public override string ToString()
        {
            return Detalle;
        }
    }
}
