using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Modelo;
using FrbaCommerce.DAO;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class MostrarPublicacionForm : Form
    {
        int _IdPublicacion;
        Form _padre;

        public MostrarPublicacionForm(Form Padre, int i)
        {
            _IdPublicacion = i;
            InitializeComponent();
        }

        private void MostrarPublicacionForm_Load(object sender, EventArgs e)
        {

            Publicacion p = ADOPublicacion.getPublicacion(_IdPublicacion);

            lblMuestraInicio.Text = p.Fecha_Inicio.ToShortDateString();
            lblMuestraVenc.Text = p.Fecha_Vencimiento.ToShortDateString();
            lblMuestraStock.Text = p.Stock.ToString();
            lblMuestraPrecio.Text = p.Precio.ToString();
            txtDescripcion.Text = p.Descripcion;

            gbPreguntar.Visible = false;

            bool PermitePreguntas = true;

            if (PermitePreguntas)
            {
                lblNoPermite.Visible = false;
                btnPreguntar.Visible = true;
            }

        }

        private void btnPreguntar_Click(object sender, EventArgs e)
        {
            gbPreguntar.Visible = true;
            btnVolver.Location = new Point(303, 503);
            this.Width = 694;
            this.Height = 576;
            btnPreguntar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbPreguntar.Visible = false;
            btnVolver.Location = new Point(470, 308);
            this.Width = 694;
            this.Height = 375;
            btnPreguntar.Visible = true;
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            if (txtOfertar.Text == "")
                MessageBox.Show("Por favor, indique un precio de oferta.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if ( Convert.ToDouble(lblMuestraPrecio.Text) > Int32.Parse(txtOfertar.Text))
            {
                MessageBox.Show("El Precio de oferta debe ser mayor al precio actual.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOfertar.Text = "0";
            }
        }

        private void txtOfertar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.SoloNumeroEntero(e);
        }

        private void txtComprar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.SoloNumeroEntero(e);
        }

    }
}
