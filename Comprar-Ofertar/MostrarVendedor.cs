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
    public partial class MostrarVendedorForm : Form
    {
        Form _padre;
        int _idVendedor;

        public MostrarVendedorForm(Form Padre, int IdVendedor)
        {
            _idVendedor = IdVendedor;
            _padre = Padre;
            InitializeComponent();
        }

        private void MostrarVendedor_Load(object sender, EventArgs e)
        {

            Persona Ven =  ADOPersona.getVendedor(_idVendedor);

            lblNombre.Text = Ven.Descripcion;
            lblTel.Text = Ven.Telefono.ToString();
            lblMail.Text = Ven.Mail;
            lblCalle.Text = Ven.Domicilio_Calle;
            lblNum.Text = Ven.Nro_Calle.ToString();
            lblPiso.Text = Ven.Piso.ToString();
            lblDto.Text = Ven.Departamento.ToString();
            lblCP.Text = Ven.Cod_Postal.ToString();
            lblCiudad.Text = Ven.Ciudad;
            lblLoc.Text = Ven.Localidad;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }
    }
}
