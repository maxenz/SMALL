using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class AbmClienteForm : Form
    {
        private Form _padre;

        public AbmClienteForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AltaClienteForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            var nuevaForma = new FiltrarClienteForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void AbmClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

    }
}
