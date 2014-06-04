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
        bool _soloVeo;
        Form _padre;

        public MostrarPublicacionForm(Form Padre, int IdPublicacion, bool SoloVeo)
        {
            _padre = Padre;
            _IdPublicacion = IdPublicacion;
            _soloVeo = SoloVeo;
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
            txtComprar.Text = "0";
            txtOfertar.Text = "0";

            //Probar bien esto para los casos en que transacciono y es compra, es oferta y no transacciono.

            if (_soloVeo)
            {
                lblNoPermite.Visible = false;
                btnPreguntar.Visible = false;
                gbOfertar.Visible = false;
                gbComprar.Visible = false;
            }
            else
            {
                bool PermitePreguntas = p.Hab_Preguntas;

                if (PermitePreguntas)
                {
                    lblNoPermite.Visible = false;
                    btnPreguntar.Visible = true;
                }
                else gbPreguntar.Visible = false;

                if (p.ID_Tipo_Publicacion == 1)
                {
                    gbOfertar.Visible = false;
                }
                if (p.ID_Tipo_Publicacion == 2)
                {
                    gbComprar.Visible = false;
                }
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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtComprar.Text == "" || txtComprar.Text == "0")
                MessageBox.Show("Por favor, indique un precio de compra.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (Convert.ToDouble(lblMuestraStock.Text) < Int32.Parse(txtComprar.Text))
            {
                MessageBox.Show("La cantidad a comprar debe ser menor o igual al stock.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOfertar.Text = "0";
            }
            else
                ;//Inserto la compra en la tabla
                //Muestro la info del vendedor.
                // hay que validar que no pueda preguntar ni comprar el usuario que vende.
                //Verificar si tiene mas de 5 compras inmediatas u ofertas sin calificar!!!!!!!!!!
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            if (txtOfertar.Text == "" || txtOfertar.Text == "0")
                MessageBox.Show("Por favor, indique un precio de oferta.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (Convert.ToDouble(lblMuestraPrecio.Text) > Int32.Parse(txtOfertar.Text))
            {
                MessageBox.Show("El Precio de oferta debe ser mayor al precio actual.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOfertar.Text = "0";
            }
            else
                ;//inserto la oferta en la tabla
        }

        private void txtOfertar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.SoloNumeroEntero(e);
        }

        private void txtComprar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.SoloNumeroEntero(e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Ocultar el gbox de preguntar.
            //validar los 255 caracteres!
            //Inserto la pregunta en tabla!!!!!
        }

    }
}
