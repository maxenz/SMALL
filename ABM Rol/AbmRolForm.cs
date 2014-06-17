using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.ABM_Rol
{
    public partial class AbmRolForm : Form
    {
        private Form _padre;

        public AbmRolForm(Form padre)
        {
            InitializeComponent(); 
            _padre = padre;
        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AltaRolForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void AbmEmpresaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void bModificacion_Click(object sender, EventArgs e)
        {
            var nuevaForma = new FiltrarRolForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }
    }
}
