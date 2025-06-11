using Datos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Fase2.Negocio
{
    public class Descuento
    {
        public static decimal CalcularDescuento(
            List<Tuple<Producto, int>> carrito,
            List<CategoriaProductos> categorias,
            out decimal subtotal,
            out bool aplicaDescuento)
        {
            subtotal = 0;
            bool contieneElectroHogar = false;

            foreach (var item in carrito)
            {
                Producto producto = item.Item1;
                int cantidad = item.Item2;
                subtotal += producto.Precio * cantidad;

                var categoria = categorias.FirstOrDefault(c => c.Id == producto.IdCategoria.ToString());

                if (categoria != null && categoria.Detalle == "Electro Hogar")
                {
                    contieneElectroHogar = true;
                }
            }

            // Aplica descuento si contiene Electro Hogar O si el subtotal supera 1 millón
            aplicaDescuento = contieneElectroHogar && subtotal > 1000000;

            return aplicaDescuento ? subtotal * 0.85m : subtotal;
        }


    }
}
