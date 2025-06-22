using Datos;
using Datos.Seguridad;
using Datos.Ventas;
using Negocio.Fase2.Negocio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private FormOperador formAnterior;

        public FormVentas(FormOperador operador)
        {
            InitializeComponent();
            formAnterior = operador;
            this.FormClosed += FormVentas_FormClosed;
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            if (cbxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Cliente.");
                return;
            }

            Cliente clienteSeleccionado = listaClientes[cbxClientes.SelectedIndex];
            Guid idUsuario = Guid.Parse("784c07f2-2b26-4973-9235-4064e94832b5");

            VentaPersistencia persistencia = new VentaPersistencia();
            bool FlagError = false;

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
                    FlagError = true; //Si poseo un error no borro el carrito
                }
                else
                {
                    MessageBox.Show("Venta enviada con éxito del producto: " + producto.Nombre);
                }
            }
            if(!FlagError)
            {
                carrito.Clear();
                lstCarrito.Items.Clear();
                lstProducto.Items.Clear();
                cbxClientes.Text = "";
                cbxCategoriaProductos.Text = "";
                ActualizarTotales();
            }
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

            int cantidad;
            if (!int.TryParse(txbCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a cero.");
                return;
            }

            Producto productoSeleccionado = (Producto)lstProducto.SelectedItem;

            carrito.Add(new Tuple<Producto, int>(productoSeleccionado, cantidad));
            lstCarrito.Items.Add(productoSeleccionado.Nombre + " x" + cantidad + " = $" + (productoSeleccionado.Precio * cantidad).ToString("0.00"));

            ActualizarTotales();
            txbCantidad.Text = "";
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
          txbCantidad.Enabled = false; // Por defecto deshabilitado

        }

        private void FormVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Show(); // Vuelve a mostrar el operador
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

        private void txbCantidad_TextChanged_1(object sender, EventArgs e)
        {
            btnAgregarCarrito.Enabled = false;

            if (!int.TryParse(txbCantidad.Text, out int cantidadIngresada))
            {
                lblErrorStock.Text = "Ingrese una cantidad válida.";
                lblErrorStock.Visible = true;
                return;
            }

            Producto productoSeleccionado = (Producto)lstProducto.SelectedItem;
            int stockDisponible = productoSeleccionado.Stock;

            VentasNegocio negocio = new VentasNegocio();
            string mensaje = negocio.ValidarStockMensaje(cantidadIngresada, stockDisponible);

            lblErrorStock.Visible = !string.IsNullOrEmpty(mensaje);
            lblErrorStock.Text = mensaje;

            //Si el mensaje de error es vacio, muestra el boton
            btnAgregarCarrito.Enabled = string.IsNullOrEmpty(mensaje);
        }
       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lstProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Si hay un producto seleccionado, habilita el TextBox
            if (lstProducto.SelectedIndex != -1)
            {
                txbCantidad.Enabled = true;
            }

            // se limpia el campo de cantidad y errores previos
            txbCantidad.Text = "";
            lblErrorStock.Visible = false;
            btnAgregarCarrito.Enabled = false;
        }
    }
    
}
