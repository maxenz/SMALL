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
    }
}
