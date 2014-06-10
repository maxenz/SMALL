using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;
using FrbaCommerce.DAO;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class frmFacturarPublicaciones : Form
    {
        public frmFacturarPublicaciones()
        {
            InitializeComponent();
        }

        private void frmFacturarPublicaciones_Load(object sender, EventArgs e)
        {
            // --> Seteo opciones generales del form
            setComboFormasDePago();
            setComboPersonas();
        }

        // --> Seteo el combo de formas de pago
        private void setComboFormasDePago()
        {

            cmbFormaDePago.Items.Add("Efectivo");
            cmbFormaDePago.Items.Add("Tarjeta de Credito");
            cmbFormaDePago.SelectedIndex = 0;

        }

        // --> Seteo el combo de las personas
        private void setComboPersonas()
        {
            cmbPersonaFacturar.DataSource = ADOPersona.getPersonas();
            cmbPersonaFacturar.DisplayMember = "Descripcion";
            cmbPersonaFacturar.ValueMember = "ID";
        }

        // --> Cuando cambio la forma de pago..
        private void cmbFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TextBox> txtsTarjeta = new List<TextBox>() { txtNroTarjeta, txtVencimientoTarjeta, txtCodSegTarjeta };

            // --> Limpio los campos de la tarjeta de credito, si es tarjeta los habilito
            // --> Si es efectivo, los deshabilito.
            CleanFormHelper cfh = new CleanFormHelper();
            cfh.cleanTextBoxes(this, txtsTarjeta);

            if (cmbFormaDePago.SelectedIndex == 0)
            {
                cfh.setReadOnlyTextBoxes(this,txtsTarjeta, true);
            }
            else
            {
                cfh.setReadOnlyTextBoxes(this, txtsTarjeta, false);
            }
        }

        private void btnFacturarPublicaciones_Click(object sender, EventArgs e)
        {
            string fecUltPubFacturada = ADOFacturacion
                                    .getLastPublicacionFacturada(37).Rows[0]["Fecha_Vencimiento"].ToString();
            //primero obtengo cual es la ultima publicacion facturada. para que sea mas sencillo
            //las ordeno segun fecha de vencimiento

            DataTable dtPubAFacturar = ADOFacturacion
                                        .getPublicacionesAFacturar(2, fecUltPubFacturada, 37);



            //al tener la ultima publicacion facturada, obtengo la siguiente publicacion finalizada, que
            // obviamente por logica no va a estar facturada (ya que no puedo saltear publicaciones)

            // entonces a partir de esa publicacion, facturo la cantidad pedida por la persona

            //en un store procedure, creo factura. obtengo id y la seteo en una variable.
            // entonces, voy creando items_factura segun las compras de cada publicacion + 
            // el costo de publicacion. aca hay que ver el tema de gratis tambien
        }
    }
}
