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
        public Publicacion publicacion;
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

            if (this.publicacion != null)
            {
                setPublicacion();
            }
        }

        private void setPublicacion()
        {
            cmbTipoPublicacion.SelectedValue = publicacion.ID_Tipo_Publicacion;
            txtCodPublicacion.Text = publicacion.ID.ToString();
            txtDescPublicacion.Text = publicacion.Descripcion;
            cmbVisibilidadPublicacion.SelectedValue = publicacion.ID_Visibilidad;
            dtpInicioPublicacion.Text = publicacion.Fecha_Inicio.ToString();
            txtStock.Text = publicacion.Stock.ToString();
            txtPrecio.Text = publicacion.Precio.ToString();
            cmbEstadoPublicacion.SelectedValue = publicacion.ID_Estado;
            chkSePermitePreguntas.Checked = publicacion.Hab_Preguntas;
            for (int i = 0; i < lstBoxRubros.Items.Count; i++)
            {
                Rubro rubro = (Rubro)lstBoxRubros.Items[i];
                if (publicacion.Rubros.Exists(x => x.ID == rubro.ID))
                {
                    lstBoxRubros.SetSelected(i, true);
                }            
            }

            EstadoPublicacion estadoPublicacion = ADOPublicacion.getEstadoPublicacion(publicacion.ID_Estado);

            switch (estadoPublicacion.Descripcion)
            {
                case "Activa":
                    setCondicionesActiva();
                    break;
                case "Pausada":
                    setCondicionesPausada();
                    break;
                case "Finalizada":
                    setCondicionesFinalizada();
                    break;
            }
        }

        private string getDescripcionTipoPublicacion()
        {
            TipoPublicacion tip_pub = ADOPublicacion.getTipoPublicacion(publicacion.ID_Tipo_Publicacion);
            return tip_pub.Descripcion;
        }

        private void setCondicionesFinalizada()
        {
            disableMostOfControls();
            readonlyStockDescripcion();
            cmbEstadoPublicacion.Enabled = false;
        }

        private void setCondicionesActiva()
        {
            disableMostOfControls();

            if (getDescripcionTipoPublicacion() == "Subasta")
            {
                readonlyStockDescripcion();
            }
        }

        private void setCondicionesPausada()
        {
            disableMostOfControls();
            readonlyStockDescripcion();
        }

        private void disableMostOfControls()
        {
            List<string> vTextBox = new List<string>() { "txtCodPublicacion", "txtPrecio", "txtValorInicialSubasta" };
            List<string> vCombo = new List<string>() { "cmbTipoPublicacion", "cmbVisibilidadPublicacion" };
            lstBoxRubros.Enabled = false;
            chkSePermitePreguntas.Enabled = false;
            dtpInicioPublicacion.Enabled = false;
            setReadOnlyTextBoxes(vTextBox);
            setDisabledCombo(vCombo);
            List<EstadoPublicacion> lst = ADOPublicacion.getEstadosPublicacion();
            cmbEstadoPublicacion.DataSource = getEstadosWithFilters(new string[] { "Borrador" }, lst);
            cmbEstadoPublicacion.SelectedValue = publicacion.ID_Estado;
        }

        private void readonlyStockDescripcion()
        {
            List<string> vTextBox = new List<string>() { "txtStock", "txtDescPublicacion" };
            setReadOnlyTextBoxes(vTextBox);
        }

        private void setReadOnlyTextBoxes(List<string> vControls)
        {
            foreach (string desc in vControls)
            {
                ((TextBox)this.Controls.Find(desc, true)[0]).ReadOnly = true;
            }
        }

        private void setDisabledCombo(List<string> vControls)
        {
            foreach (string desc in vControls)
            {
                ((ComboBox)this.Controls.Find(desc, true)[0]).Enabled = false;
            }
        }

        private List<EstadoPublicacion> getEstadosWithFilters(string[] filters, List<EstadoPublicacion> lst)
        {
            foreach (string filter in filters)
            {
                lst = lst.Where(x => x.Descripcion != filter).ToList();
            }

            return lst;

        }

        private void setComboEstadosPublicacion()
        {
            List<EstadoPublicacion> lstEstados = ADOPublicacion.getEstadosPublicacion();
            if (this.publicacion == null)
            {
                lstEstados = getEstadosWithFilters(new string[] { "Pausada", "Finalizada" }, lstEstados);
            } 
            this.cmbEstadoPublicacion.DataSource = lstEstados;
            this.cmbEstadoPublicacion.DisplayMember = "Descripcion";
            this.cmbEstadoPublicacion.ValueMember = "ID";
        }

        private void setListBoxRubros()
        {
            this.lstBoxRubros.DataSource = ADORubro.getRubros();
            this.lstBoxRubros.DisplayMember = "Descripcion";
            this.lstBoxRubros.ValueMember = "ID";
            this.lstBoxRubros.SelectedItem = null;
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

            //falta validar si cuando modifican el stock se hace de forma incremental.
            //tmb aca falta diferenciar si esta editando o generando la publicacion

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
                Convert.ToDouble(txtPrecio.Text), chkSePermitePreguntas.Checked,new List<Rubro>());

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
