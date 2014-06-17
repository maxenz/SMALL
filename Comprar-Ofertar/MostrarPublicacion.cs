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
        int _personaPublica;
        int _persona;
        int _IdPublicacion;
        bool _soloVeo;
        Form _padre;

        public MostrarPublicacionForm(Form Padre, int IdPublicacion, bool SoloVeo, int IdPersona)
        {
            
            _persona = IdPersona;
            _padre = Padre;
            _IdPublicacion = IdPublicacion;
            _soloVeo = SoloVeo;
            InitializeComponent();
        }

        private void MostrarPublicacionForm_Load(object sender, EventArgs e)
        {

            Publicacion p = ADOPublicacion.getPublicacion(_IdPublicacion);

            _personaPublica = p.ID_Persona;
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
                else btnPreguntar.Visible = false;

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
            int IdPersonaCompra = _persona;
            int DebeMasDeCinco;
            DebeMasDeCinco = ADOComprar.CheckDebeCalificaciones(_persona);

            if (IdPersonaCompra == _personaPublica)
                MessageBox.Show("Usted no se puede autocomprar!", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                //if (Convert.ToBoolean(DebeMasDeCinco) == true)
                //     MessageBox.Show("Usted tiene mas de 5 calificaciones pendientes, regularice su situacion y vuelva a intentarlo", "Deshabilitado para transaccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //else
                {
                    if (txtComprar.Text == "" || Convert.ToInt32(txtComprar.Text) == 0)
                        MessageBox.Show("Por favor, indique una cantidad de compra.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (Convert.ToDouble(lblMuestraStock.Text) < Int32.Parse(txtComprar.Text))
                    {
                        MessageBox.Show("La cantidad a comprar debe ser menor o igual al stock.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtComprar.Text = "0";
                    }
                    else
                    {
                        ADOComprar.InsertaCompra(_IdPublicacion, _persona, Convert.ToInt32(txtComprar.Text), Globals.getFechaSistema());
                        Form MostrarPubForm = new MostrarVendedorForm(this, _personaPublica);

                        MostrarPubForm.Visible = true;
                        MostrarPubForm.Activate();
                        MostrarPubForm.Select();
                        this.Hide();
                    }

                }
            }
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            int IdPersonaOferta = _persona;
            int DebeMasDeCinco;
            DebeMasDeCinco = ADOComprar.CheckDebeCalificaciones(_persona);

            if (IdPersonaOferta == _personaPublica)
                MessageBox.Show("Usted no se puede autofertar!", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                //if (Convert.ToBoolean(DebeMasDeCinco) == true)
                //     MessageBox.Show("Usted tiene mas de 5 calificaciones pendientes, regularice su situacion y vuelva a intentarlo", "Deshabilitado para transaccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //else
                {
                    if (txtOfertar.Text == "" || Convert.ToInt32(txtOfertar.Text) == 0)
                        MessageBox.Show("Por favor, indique un precio de oferta.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (Convert.ToDouble(lblMuestraPrecio.Text) >= Int32.Parse(txtOfertar.Text))
                    {
                        MessageBox.Show("El Precio de oferta debe ser mayor al precio actual.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtOfertar.Text = "0";
                    }
                    else
                    {
                        ADOComprar.InsertaOferta(_IdPublicacion, _persona, Convert.ToInt32(txtOfertar.Text), Globals.getFechaSistema());
                        MessageBox.Show("Felicitaciones! Acaba de ofertar por un producto!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }
        }
        
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int IdPersonaPregunta = _persona;

            if (IdPersonaPregunta == _personaPublica)
                MessageBox.Show("Usted no se puede autopreguntar!", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (Convert.ToInt32(txtPregunta.Text.Length.ToString()) >= 255)
                MessageBox.Show("Su pregunta es muy larga y supera los 255 caracteres, acórtela.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                ADOPreguntarResponder.InsertaPregunta(_IdPublicacion, IdPersonaPregunta, txtPregunta.Text);
                MessageBox.Show("Su pregunta ya ha sido procesada!!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPregunta.Text = "";
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }
    }
}
