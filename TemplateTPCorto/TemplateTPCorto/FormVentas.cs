using Datos.Seguridad;
using Datos.Ventas;
using Negocio.Fase2.Negocio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormVentas : Form
    { 
        private List<Cliente> listaClientes = new List<Cliente>();
        public FormVentas()
        {
            InitializeComponent();
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            if (cbxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Cliente.");
                return;
            }

            Cliente clienteSeleccionado = listaClientes[cbxClientes.SelectedIndex];
            Guid idUsuario = Guid.Parse("784c07f2-2b26-4973-9235-4064e94832b5"); // REEMPLAZAR CON ID DEL USUARIO LOGUEADO

            VentaPersistencia persistencia = new VentaPersistencia();

            for (int i = 0; i < carrito.Count; i++)
            {
                Producto producto = carrito[i].Item1;
                int cantidad = carrito[i].Item2;

                Venta venta = new Venta
                {
                    IdCliente = clienteSeleccionado.Id,
                    IdUsuario = idUsuario,
                    IdProducto = producto.Id,
                    Cantidad = cantidad
                };

                ResultadoVenta resultado = persistencia.agregarVenta(venta);

                if (!resultado.Exito)
                {
                    MessageBox.Show("Error al enviar producto: " + producto.Nombre + "\nDetalle: " + resultado.ErrorMensaje);
                }
            }

            MessageBox.Show("Venta enviada con éxito.");

            carrito.Clear();
            lstCarrito.Items.Clear();
            ActualizarTotales();
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (cbxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Cliente antes de continuar la operación.");
                return;
            }

            if (lstProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            Producto productoSeleccionado = (Producto)lstProducto.SelectedItem;
            int cantidad = 1; 

            carrito.Add(new Tuple<Producto, int>(productoSeleccionado, cantidad));
            lstCarrito.Items.Add(productoSeleccionado.Nombre + " x" + cantidad + " = $" + (productoSeleccionado.Precio * cantidad).ToString("0.00"));

            ActualizarTotales();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            if (cbxCategoriaProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            CategoriaProductos categoriaSeleccionada = (CategoriaProductos)cbxCategoriaProductos.SelectedItem;

            ProductoPersistencia persistencia = new ProductoPersistencia();
            List<Producto> productos = persistencia.obtenerProductosPorCategoria(categoriaSeleccionada.Id);

            lstProducto.Items.Clear();

            foreach (Producto p in productos)
            {
                lstProducto.Items.Add(p);
            }
        }

        private void cbxCategoriaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCategoria = cbxCategoriaProductos.SelectedItem.ToString();

            VentasNegocio ventasNegocio = new VentasNegocio();
            List<CategoriaProductos> categorias = ventasNegocio.obtenerCategoriaProductos();

            CategoriaProductos categoriaSeleccionada = null;

            foreach (CategoriaProductos categoria in categorias)
            {
                if (categoria.ToString() == nombreCategoria)
                {
                    categoriaSeleccionada = categoria;
                    break;
                }
            }

            if (categoriaSeleccionada != null)
            {
                ProductoPersistencia productoPersistencia = new ProductoPersistencia();
                List<Producto> productos = productoPersistencia.obtenerProductosPorCategoria(categoriaSeleccionada.Id);

                lstProducto.Items.Clear();

                foreach (Producto producto in productos)
                {
                    lstProducto.Items.Add(producto);
                }
            }
        }

        private void IniciarTotales()
        {
            lblSubtotal.Text = "0.00";
            lblTotal.Text = "0.00";
        }

        private void ActualizarTotales()
        {
            VentasNegocio ventasNegocio = new VentasNegocio();
            List<CategoriaProductos> categorias = ventasNegocio.obtenerCategoriaProductos();

            decimal subtotal;
            bool aplicaDescuento;

            decimal total = Descuento.CalcularDescuento(carrito, categorias, out subtotal, out aplicaDescuento);

            lblSubtotal.Text = subtotal.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");


        }

        private List<Tuple<Producto, int>> carrito = new List<Tuple<Producto, int>>();


        private void CargarCategoriasProductos()
        {
            VentasNegocio ventasNegocio = new VentasNegocio();
            List<CategoriaProductos> categorias = ventasNegocio.obtenerCategoriaProductos();

            cbxCategoriaProductos.Items.Clear();
            foreach (CategoriaProductos categoria in categorias)
            {
                cbxCategoriaProductos.Items.Add(categoria);
            }

            cbxCategoriaProductos.DisplayMember = "_descripcion";
            cbxCategoriaProductos.ValueMember = "_id";            
        }

        private void CargarClientes()
        {
            VentasNegocio vn = new VentasNegocio();
            listaClientes = vn.obtenerClientes();

            foreach (Cliente cliente in listaClientes)
            {
                cbxClientes.Items.Add(cliente.ToString());
            }

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
          CargarClientes();   
          IniciarTotales();
          CargarCategoriasProductos();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstCarrito.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto del carrito para quitar.");
                return;
            }

            int indiceSeleccionado = lstCarrito.SelectedIndex;

            // Quitar de la lista lógica
            carrito.RemoveAt(indiceSeleccionado);

            // Quitar de la lista visual
            lstCarrito.Items.RemoveAt(indiceSeleccionado);

            // Actualizar totales
            ActualizarTotales();
        }
    }
}
