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
    public partial class FormOperador : Form
    {
        public FormOperador()
        {
            InitializeComponent();
        }

        private void FormOperador_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show();
            this.Hide();
        }
    }
}
