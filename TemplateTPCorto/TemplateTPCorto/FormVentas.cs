using Datos.Ventas;
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
        public FormVentas()
        {
            InitializeComponent();
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            //VENTA EJEMPLO. BORRAR UNA VEZ INCORPORADA TODA LA LÓGICA ANTERIOR
            Venta venta = new Venta
            {
                IdCliente = Guid.Parse("d2541fe1-681c-426d-bb87-05479efdf51f"),
                IdUsuario = Guid.Parse("784c07f2-2b26-4973-9235-4064e94832b5"),
                IdProducto = Guid.Parse("8e5942df-52fb-4d84-86a9-3862c931649a"),
                Cantidad = 1
            };
            //////////////////////////

            VentaPersistencia persistencia = new VentaPersistencia();
            ResultadoVenta resultado = persistencia.agregarVenta(venta);

            if (resultado.Exito)
            {
                MessageBox.Show("Venta enviada correctamente.");
            }
            else
            {
                MessageBox.Show($"Error al enviar el producto con ID: {resultado.IdProducto}\nDetalle: {resultado.ErrorMensaje}");
            }
        }
    }
}
