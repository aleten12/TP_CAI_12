using Datos;
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
        public Credencial Credencial { get; }

        public FormOperador()
        {
            InitializeComponent();
        }

        public FormOperador(Credencial credencial)
        {
            InitializeComponent();
            Credencial = credencial;
            
        }
        private void FormOperador_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas(this);
            formVentas.Show();
            this.Hide();
        }

    }
}
