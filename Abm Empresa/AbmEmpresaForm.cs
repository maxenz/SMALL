using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class AbmEmpresaForm : Form
    {
        private Form _padre;

        public AbmEmpresaForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AltaEmpresaForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void AbmEmpresaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            var nuevaForma = new FiltrarEmpresaForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }
        
    }
}
