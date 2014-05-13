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

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class frmGenerarPublicacion : Form
    {
        Publicacion publicacion;
        List<Rubro> rubros;

        public frmGenerarPublicacion()
        {
            InitializeComponent();
        }

        private void frmGenerarPublicacion_Load(object sender, EventArgs e)
        {
            setComboTiposDePublicacion();
            setComboVisibilidades();
            setComboEstadosPublicacion();
            setNumberPublicacion();
            setListBoxRubros();
            setGeneralInputs();
        }

        private void setComboEstadosPublicacion()
        {
            this.cmbEstadoPublicacion.DataSource = ADOPublicacion.getEstadosPublicacion();
            this.cmbEstadoPublicacion.DisplayMember = "Descripcion";
            this.cmbEstadoPublicacion.ValueMember = "ID";
        }

        private void setListBoxRubros()
        {
            this.lstBoxRubros.DataSource = ADORubro.getRubros();
            this.lstBoxRubros.DisplayMember = "Descripcion";
            this.lstBoxRubros.ValueMember = "ID";
        }

        private void setGeneralInputs()
        {
            this.ActiveControl = txtDescPublicacion;
            this.txtDescPublicacion.Focus();
        }

        private void setComboTiposDePublicacion()
        {
            this.cmbTipoPublicacion.DataSource = ADOPublicacion.getTiposDePublicacion();
            this.cmbTipoPublicacion.DisplayMember = "Descripcion";
            this.cmbTipoPublicacion.ValueMember = "ID";

        }

        private void setNumberPublicacion()
        {
            this.txtCodPublicacion.Text = ADOPublicacion.getNewPublicacionNumber().ToString();

        }

        private void setComboVisibilidades()
        {
            this.cmbVisibilidadPublicacion.DataSource = ADOVisibilidad.getVisibilidades();
            this.cmbVisibilidadPublicacion.DisplayMember = "Descripcion";
            this.cmbVisibilidadPublicacion.ValueMember = "ID";
        }

        private void dtpInicioPublicacion_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecInicioPubl = this.dtpInicioPublicacion.Value;
            fecInicioPubl = fecInicioPubl.AddDays(10);
            this.txtVencimientoPublicacion.Text = fecInicioPubl.ToString();
        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            cleanErrorProviderInLabels();
            if (formIsValidated())
            {
                generarPublicacion();
            }
        }

        private void generarPublicacion()
        {
            int idPersona = 1;
            publicacion = new Publicacion(0,Convert.ToInt32(cmbVisibilidadPublicacion.SelectedValue),
                Convert.ToInt32(cmbTipoPublicacion.SelectedValue),
                Convert.ToInt32(cmbEstadoPublicacion.SelectedValue),
                idPersona, txtDescPublicacion.Text, dtpInicioPublicacion.Value,
                Convert.ToDateTime(txtVencimientoPublicacion.Text), Convert.ToInt32(txtStock.Text),
                Convert.ToDouble(txtPrecio.Text), chkSePermitePreguntas.Checked);

            rubros = new List<Rubro>();
            //foreach (var itm in lstBoxRubros.SelectedItems) {
            //    rubros = new Rubro(
            //}

        }

        private void cleanErrorProviderInLabels()
        {
            foreach (Control ctrl in this.gpGenerarPublicacion.Controls)
            {
                if (ctrl is Label)
                {
                    errorProvider1.SetError(ctrl, "");
                }
            }

        }

        private bool formIsValidated()
        {
            bool vBool = true;

            if (txtStock.Text == "")
            {
                
                errorProvider1.SetError(lblStock, "Debe ingresar el stock");
                vBool = false;
            }

            if (txtDescPublicacion.Text == "")
            {
                errorProvider1.SetError(lblDescripcion, "Debe ingresar la descripción de la publicación");
                vBool = false;
            }

            if (txtVencimientoPublicacion.Text == "")
            {
                errorProvider1.SetError(lblFechaVencimiento, "Debe ingresar fecha de publicación");
                vBool = false;
            }

            if (txtPrecio.Text == "")
            {
                errorProvider1.SetError(lblPrecioUnitario, "Debe ingresar el precio unitario");
                vBool = false;
            }

            if (lstBoxRubros.SelectedItems.Count == 0)
            {
                errorProvider1.SetError(lblRubros, "Debe seleccionar al menos un rubro");
                vBool = false;
            }

            return vBool;

        }

        private void cmbTipoPublicacion_TextChanged(object sender, EventArgs e)
        {
            txtValorInicialSubasta.Text = "";

            if (this.cmbTipoPublicacion.Text == "Subasta")
            {

                txtValorInicialSubasta.ReadOnly = false;
            }
            else
            {
                txtValorInicialSubasta.ReadOnly = true;
            }
        }



       
    }
}
