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
using System.Runtime.InteropServices;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class frmGenerarPublicacion : Form
    {
        Form _padre;
        public Publicacion publicacion;

        public frmGenerarPublicacion(Form padre)
        {
            _padre = padre;
            InitializeComponent();

        }

        // --> Inicializo cosas controles generales del form
        private void frmGenerarPublicacion_Load(object sender, EventArgs e)
        {

            setComboTiposDePublicacion();
            setComboVisibilidades();

            // --> Cuando inicializo, que me muestre todos los estados menos pausada
            setComboEstadosPublicacion(new List<string>() { "Pausada" });
            setNumberPublicacion();
            setListBoxRubros();
            setGeneralInputs();

            // --> Formato para el datetimepicker de fecha de inicio de publicación
            dtpInicioPublicacion.Value = DateTime.Now;
            dtpInicioPublicacion.Format = DateTimePickerFormat.Custom;
            dtpInicioPublicacion.CustomFormat = "dd/MM/yyyy";

            // --> Si publicacion no es null, entonces estoy abriendo una publicacion ya hecha ..
            if (this.publicacion != null)
            {
                setPublicacion();
            }
        }

        private void frmGenerarPublicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        // --> Lleno el todos los controles del form con los datos de la publicacion
        private void setPublicacion()
        {
            // --> Si estoy editando, no quiero usar el boton limpiar, porque no tiene sentido
            // --> limpiar los readonly que necesito que no se modifiquen..
            btnLimpiarForm.Enabled = false;

            cmbTipoPublicacion.SelectedValue = publicacion.ID_Tipo_Publicacion;
            txtCodPublicacion.Text = publicacion.ID.ToString();
            txtDescPublicacion.Text = publicacion.Descripcion;
            cmbVisibilidadPublicacion.SelectedValue = publicacion.ID_Visibilidad;
            dtpInicioPublicacion.Text = publicacion.Fecha_Inicio.ToString();
            txtStock.Text = publicacion.Stock.ToString();
            txtPrecio.Text = publicacion.Precio.ToString();
            cmbEstadoPublicacion.SelectedValue = publicacion.ID_Estado;
            chkSePermitePreguntas.Checked = publicacion.Hab_Preguntas;

            // --> Voy seleccionando los rubros en la lista
            for (int i = 0; i < lstBoxRubros.Items.Count; i++)
            {
                Rubro rubro = (Rubro)lstBoxRubros.Items[i];
                if (publicacion.Rubros.Exists(x => x.ID == rubro.ID))
                {
                    lstBoxRubros.SetSelected(i, true);
                }
            }

            EstadoPublicacion estadoPublicacion = ADOPublicacion.getEstadoPublicacion(publicacion.ID_Estado);

            // --> Segun el estado de la publicacion, voy a activar o desactivar diferentes cosas
            switch (estadoPublicacion.Descripcion)
            {
                case "Publicada":
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

        // --> Si la publicación está finalizada, disableo todo
        private void setCondicionesFinalizada()
        {
            disableMostOfControls();
            readonlyStockDescripcion();
            cmbEstadoPublicacion.Enabled = false;
            btnGenerarPublicacion.Enabled = false;
        }

        // --> Si la publicacion esta activa.. (publicada)
        private void setCondicionesActiva()
        {
            disableMostOfControls();

            // --> Si es una subasta publicada, solo puedo cambiar el estado a finalizada, nada mas.
            if (getDescripcionTipoPublicacion() == "Subasta")
            {
                readonlyStockDescripcion();
                setComboEstadosPublicacion(new List<string>() { "Borrador","Pausada" });

            }
            // --> Si es una compra inmediata, puedo pausarla, solo filtro borrador.
            else
            {
                setComboEstadosPublicacion(new List<string>() { "Borrador" });
            }
        }

        // --> Seteo las condiciones para una compra inmediata que está pausada
        private void setCondicionesPausada()
        {
            disableMostOfControls();
            readonlyStockDescripcion();
            setComboEstadosPublicacion(new List<string>() { "Borrador" });
        }

        // --> Método para disablear la mayoría de los controles del form
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
            cmbEstadoPublicacion.DataSource = getEstadosWithFilters(new List<string>() { "Borrador" }, lst);
            cmbEstadoPublicacion.SelectedValue = publicacion.ID_Estado;
        }


        // --> Seteo en readonly stock y descripción
        private void readonlyStockDescripcion()
        {
            List<string> vTextBox = new List<string>() { "txtStock", "txtDescPublicacion" };
            setReadOnlyTextBoxes(vTextBox);
        }

        // --> Seteo readonly los textboxes
        private void setReadOnlyTextBoxes(List<string> vControls)
        {
            foreach (string desc in vControls)
            {
                ((TextBox)this.Controls.Find(desc, true)[0]).ReadOnly = true;
            }
        }

        // --> Seteo disabled los combos
        private void setDisabledCombo(List<string> vControls)
        {
            foreach (string desc in vControls)
            {
                ((ComboBox)this.Controls.Find(desc, true)[0]).Enabled = false;
            }
        }

        // --> Filtro los estados de la publicacion pasandole como parametro una lista de los que 
        // --> no quiero que estén disponibles.
        private List<EstadoPublicacion> getEstadosWithFilters(List<string> filters, List<EstadoPublicacion> lst)
        {
            foreach (string filter in filters)
            {
                lst = lst.Where(x => x.Descripcion != filter).ToList();
            }

            return lst;

        }

        // --> Seteo el combo de estados de publicación
        private void setComboEstadosPublicacion(List<string> filtros)
        {
            List<EstadoPublicacion> lstEstados = ADOPublicacion.getEstadosPublicacion();

            lstEstados = getEstadosWithFilters(filtros, lstEstados);

            this.cmbEstadoPublicacion.DataSource = lstEstados;
            this.cmbEstadoPublicacion.DisplayMember = "Descripcion";
            this.cmbEstadoPublicacion.ValueMember = "ID";
        }

        // --> Seteo la lista de rubros
        private void setListBoxRubros()
        {
            this.lstBoxRubros.DataSource = ADORubro.getRubros();
            this.lstBoxRubros.DisplayMember = "Descripcion";
            this.lstBoxRubros.ValueMember = "ID";
            this.lstBoxRubros.SelectedItem = null;
        }

        // --> Inputs generales del form
        private void setGeneralInputs()
        {
            this.ActiveControl = txtDescPublicacion;
            this.txtDescPublicacion.Focus();
        }

        // --> Seteo el combo de los tipos de publicacion
        private void setComboTiposDePublicacion()
        {
            this.cmbTipoPublicacion.DataSource = ADOPublicacion.getTiposDePublicacion();
            this.cmbTipoPublicacion.DisplayMember = "Descripcion";
            this.cmbTipoPublicacion.ValueMember = "ID";
        }

        // --> Seteo el codigo de la publicacion
        private void setNumberPublicacion()
        {
            int newPublicacionNumber = ADOPublicacion.getNewPublicacionNumber();
            newPublicacionNumber++;
            this.txtCodPublicacion.Text = newPublicacionNumber.ToString();

        }

        // --> Seteo el combo de las visibilidades de la publicación
        private void setComboVisibilidades()
        {
            this.cmbVisibilidadPublicacion.DisplayMember = "Descripcion";
            this.cmbVisibilidadPublicacion.ValueMember = "ID";
            this.cmbVisibilidadPublicacion.DataSource = ADOVisibilidad.getVisibilidades();

        }

        // --> Evento al cambiar el valor de la fecha de inicio de la publicación
        private void dtpInicioPublicacion_ValueChanged(object sender, EventArgs e)
        {
            syncVisibilidadFecha();
        }

        // --> Sincronizo la fecha de inicio con la visibilidad. Al seleccionar la fecha,
        // sabiendo la visibilidad, calculo la fecha de vencimiento y la pongo en el textbox vencimiento.
        private void syncVisibilidadFecha()
        {
            DateTime fecInicioPubl = this.dtpInicioPublicacion.Value;
            int idVisibilidad = Convert.ToInt32(cmbVisibilidadPublicacion.SelectedValue);
            // --> Obtengo los dias activos de la visibilidad seleccionada
            int diasActivo = DAO.ADOVisibilidad.getVisibilidades()
                                .Where(x => x.ID == idVisibilidad)
                                .Select(x => x.DiasActivo).FirstOrDefault();
            // --> Sumo los diasActivo a la fecha de inicio y ese resultado es el vencimiento
            fecInicioPubl = fecInicioPubl.AddDays(diasActivo);
            this.txtVencimientoPublicacion.Text = fecInicioPubl.ToShortDateString();

        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            cleanErrorProviderInLabels();
            // --> Si el form pasó la validación
            if (formIsValidated())
            {
                // --> Si estoy generando una publicación..
                if (this.publicacion == null)
                {
                    generarPublicacion();
                }
                // --> Si estoy editando una publicación..
                else
                {
                    editarPublicacion();
                }

            }
        }

        // --> Edito la publicación
        private void editarPublicacion()
        {
            int estadoPublicacionID = this.publicacion.ID_Estado;
            string descEstPublicacion = DAO.ADOPublicacion.getEstadoPublicacion(estadoPublicacionID).Descripcion;

            if (descEstPublicacion == "Publicada")
            {
                // --> Si estoy editando una publicación, veo por las dudas si se modificó el stock.
                // Sólo permito un incremento del stock, si no, no dejo editar.
                if (Convert.ToInt32(txtStock.Text) < this.publicacion.Stock)
                {
                    MessageBox.Show("Solo puede modificar el stock de forma incremental");
                    return;
                }

            }

                    setPublicacionFromFields();
                    DAO.ADOPublicacion.updatePublicacion(publicacion);

                    List<Rubro> rubFromPub = DAO.ADOPublicacion.getRubrosFromPublicacion(publicacion);

                    foreach (Rubro r in rubFromPub)
                    {
                        DAO.ADOPublicacion.deleteRubroPublicacion(Convert.ToInt32(publicacion.ID), r.ID);
                    }
                
                    DAO.ADOPublicacion.setRubrosPublicacion(getSelectedRubPubl());
                                
                    MessageBox.Show("La publicación se ha modificado exitosamente");

                    this.Hide();
                    FormHelper.volverAPadre(_padre);
            
        }

        // --> Genero la publicacion
        private void generarPublicacion()
        {

            setPublicacionFromFields();

            DAO.ADOPublicacion.setPublicacion(publicacion);

            List<RubroPublicacion> lstRubrosPublicacion = getSelectedRubPubl();

            DAO.ADOPublicacion.setRubrosPublicacion(lstRubrosPublicacion);

            MessageBox.Show("La publicación se ha generado exitosamente");

            this.Hide();
            FormHelper.volverAPadre(_padre);
             
          
        }

        private List<RubroPublicacion> getSelectedRubPubl()
        {
            List<RubroPublicacion> lstRubrosPublicacion = new List<RubroPublicacion>();
            foreach (Rubro rub in lstBoxRubros.SelectedItems)
            {
                RubroPublicacion rp = new RubroPublicacion(Convert.ToInt32(publicacion.ID), rub.ID);
                lstRubrosPublicacion.Add(rp);
            }

            return lstRubrosPublicacion;
        }

        private void setPublicacionFromFields()
        {
            double vis;
            vis = txtValorInicialSubasta.Text == "" ? 0 : Convert.ToDouble(txtValorInicialSubasta.Text);

            int idPersona = Globals.userID;
            int codPublicacion = Convert.ToInt32(txtCodPublicacion.Text);

            publicacion = new Publicacion(codPublicacion,
                Convert.ToInt32(cmbVisibilidadPublicacion.SelectedValue),
                Convert.ToInt32(cmbTipoPublicacion.SelectedValue),
                Convert.ToInt32(cmbEstadoPublicacion.SelectedValue),
                idPersona, txtDescPublicacion.Text, dtpInicioPublicacion.Value,
                Convert.ToDateTime(txtVencimientoPublicacion.Text), Convert.ToInt32(txtStock.Text),
                Convert.ToDouble(txtPrecio.Text), chkSePermitePreguntas.Checked, new List<Rubro>(),
                vis);

        }

        // --> Limpio los error providers del form
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

        // --> Valido el form por las dudas que falte llenar un campo, o estén mal los tipos de datos
        // ingresados.
        private bool formIsValidated()
        {
            bool vBool = true;

            var idUsuario = Globals.userID;

            //valido que el usr no puede tener mas de 3 publicaciones gratis al mismo tiempo

            if (ADOPublicacion.getCantPublActualesGratis(idUsuario) == 3)
            {
                MessageBox.Show("Ya tiene 3 publicaciones gratis sin finalizar, no puede tener más");
                return false;
            }

            if (cmbTipoPublicacion.SelectedText == "Subasta")
            {
                if (txtValorInicialSubasta.Text == "")
                {
                    errorProvider1.SetError(lblValorInicialSubasta, "Debe ingresar el valor inicial de la subasta");
                    vBool = false;
                }
            }

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

        // --> Si es una subasta, habilito el valor inicial. Si no, lo inhabilito.
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

        // --> Cuando cambio la visibilidad, seteo la fecha de hoy para sincronizar con el vencimiento
        private void cmbVisibilidadPublicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpInicioPublicacion.Value = DateTime.Now;
        }

        // --> Limpio el formulario entero por si quiero volver a escribir todo
        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            CleanFormHelper cfh = new CleanFormHelper();
            List<TextBox> lstTextbox = cfh.collectTextBoxes(this, gpGenerarPublicacion.Controls);
            List<ComboBox> lstCombobox = cfh.collectComboBoxes(this, gpGenerarPublicacion.Controls);
            cfh.cleanTextBoxes(this, lstTextbox);
            cfh.cleanComboBoxes(this, lstCombobox);
            chkSePermitePreguntas.Checked = false;
            lstBoxRubros.ClearSelected();
        }



    }
}
