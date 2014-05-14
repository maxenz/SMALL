using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;
using FrbaCommerce.Comprar_Ofertar;
using FrbaCommerce.Generar_Publicacion;

namespace FrbaCommerce
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }
        
        private void btnComprarOfertar_Click_1(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new ComprarOfertarForm(this), this);
        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new frmGenerarPublicacion(), this);
        }
    }
}
