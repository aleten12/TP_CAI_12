using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace TemplateTPCorto
{
    public partial class FormSupervisor : Form
    {
        public FormSupervisor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModificarPersona formModificarPersona = new FormModificarPersona();
            formModificarPersona.Show();
            this.Hide();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
