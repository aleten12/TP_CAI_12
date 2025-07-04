﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TemplateTPCorto
{
    public partial class FormDesbloquearCredencial : Form
    {
        public FormDesbloquearCredencial()
        {
            InitializeComponent();
        }

        private FormSupervisor formAnterior;
        public FormDesbloquearCredencial(FormSupervisor supervisor)
        {
            InitializeComponent();
            formAnterior = supervisor;
            this.FormClosed += FormDesbloquearCredencial_FormClosed;
        }
        private void FormDesbloquearCredencial_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Show(); // Vuelve a mostrar el operador
        }

        private void btbModificarContrasena_Click(object sender, EventArgs e)
        {
            if (cbxLegajos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un legajo para continuar.");
                return;
            }

            string legajo = cbxLegajos.SelectedItem.ToString();
            string nuevaContrasena = txbContrasena.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                MessageBox.Show("Debes ingresar una nueva contraseña.");
                return;
            }

            ModificarCredencial negocio = new ModificarCredencial();

            if (negocio.RegistrarCambioContrasena(legajo, nuevaContrasena))
            {
                MessageBox.Show("La modificación fue registrada para su aprobación.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el cambio de contraseña.");
            }
        }

        private void FormDesbloquearCredencial_Load(object sender, EventArgs e)
        {
            ModificarPersona mp = new ModificarPersona();
            List<string> listaLegajos = mp.ListarLegajos();

            foreach (string legajo in listaLegajos)
            {
                cbxLegajos.Items.Add(legajo);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
