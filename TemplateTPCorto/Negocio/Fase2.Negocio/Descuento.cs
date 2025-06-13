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
            decimal subtotalElectroHogar = 0;
            const string categoriaElectroHogar = "Electro Hogar";

            foreach (var item in carrito)
            {
                Producto producto = item.Item1;
                int cantidad = item.Item2;
                decimal totalProducto = producto.Precio * cantidad;
                subtotal += totalProducto;

                var categoria = categorias.FirstOrDefault(c => c.Id == producto.IdCategoria.ToString());

                if (categoria != null && categoria.Detalle == categoriaElectroHogar)
                {
                    subtotalElectroHogar += totalProducto;
                }
            }

            aplicaDescuento = subtotalElectroHogar > 1000000;

            decimal descuentoElectroHogar = aplicaDescuento ? subtotalElectroHogar * 0.15m : 0;
            return subtotal - descuentoElectroHogar;
        }

    }
}
