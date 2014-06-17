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
using FrbaCommerce.Modelo;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class frmFacturarPublicaciones : Form
    {

        private Form _padre;

        public frmFacturarPublicaciones(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void frmFacturarPublicaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void frmFacturarPublicaciones_Load(object sender, EventArgs e)
        {
            // --> Seteo opciones generales del form
            setComboFormasDePago();
            setComboPersonas();

            if (!Globals.adminLoggeado())
            {
                cmbPersonaFacturar.DataSource = ADOPersona.getPersonas()
                                                .Where(x => x.ID == Globals.userID).ToList();
                cmbPersonaFacturar.SelectedIndex = 0;
            }
           
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
            cmbPersonaFacturar.DisplayMember = "Descripcion";
            cmbPersonaFacturar.ValueMember = "ID";
            cmbPersonaFacturar.DataSource = ADOPersona.getPersonas();
            cmbPersonaFacturar.SelectedIndex = 0;

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
            // --> obtengo idPersona del combo, y cantidad a facturar de textbox
            int idPersona = Convert.ToInt32(cmbPersonaFacturar.SelectedValue);
            int cantAFacturar = Convert.ToInt32(txtCantidadRendir.Text);

            // --> dependiendo de la forma de pago seleccionado, son los datos que genero en la factura
            string formaDePago;
            string descFormaDePago;
            if (cmbFormaDePago.Text == "Efectivo") {
                formaDePago = "Efectivo";
                descFormaDePago = "Pago en Efectivo";
            } else {
                formaDePago = "Tarjeta de Credito";
                descFormaDePago = txtNroTarjeta + " / " + txtVencimientoTarjeta + " / " + txtCodSegTarjeta;
            }
            
            // --> obtengo la fecha de la ultima publicacion facturada
            DateTime fecUltPubFacturada = Convert.ToDateTime(ADOFacturacion
                                    .getLastPublicacionFacturada(idPersona).Rows[0]["Fecha_Vencimiento"]);
            
            // --> obtengo las publicaciones a facturar
            DataTable dtPubAFacturar = ADOFacturacion
                                        .getPublicacionesAFacturar(cantAFacturar, fecUltPubFacturada, idPersona);


            // --> Genero factura y devuelvo el id que fue creado.
            int nroFactura = Convert.ToInt32(ADOFacturacion
                                .setFactura(formaDePago, descFormaDePago, idPersona).Rows[0]["ID"]);

            double acumFactura = 0;

            // --> Para cada publicacion a facturar..
            foreach (DataRow dr in dtPubAFacturar.Rows)
            {
                // --> seteo los datos generales que me van a servir para generar la facturacion de la pub.

                int tipoDePublicacion = Convert.ToInt32(dr["ID_Tipo_Publicacion"]);
                int idPublicacion = Convert.ToInt32(dr["ID"]);
                int idVisibilidad = Convert.ToInt32(dr["ID_Visibilidad"]);
                Visibilidad vsb = ADOVisibilidad.getVisibilidad(idVisibilidad);
                double coefVisibilidad = vsb.Porcentaje;
                double impFijoVisibilidad = vsb.Precio;
                int stockPublicacion = Convert.ToInt32(dr["Stock"]);
                double precioPublicacion = Convert.ToDouble(dr["Precio"]);

                double acumImportePublicacion = 0;
                int acumCantidadPublicacion = 0;

                // --> Si es una compra inmediata..
                if (tipoDePublicacion == 1)
                {
                    // --> Obtengo todas las compras hechas de esa publicacion
                    DataTable comprasDePublicacion = ADOFacturacion
                                                    .getComprasPublicacion(idPublicacion);
                    foreach (DataRow drComp in comprasDePublicacion.Rows)
                    {
                        // Sumo precio * cantidad * coefVisibilidadDescuento
                        int cantidadCompra = Convert.ToInt32(drComp["Cantidad"]);    
                        double cobroPorCompras = precioPublicacion * cantidadCompra * coefVisibilidad;
                        acumImportePublicacion += cobroPorCompras;
                        acumCantidadPublicacion += cantidadCompra;
                    }

                }
                else
                {
                    // --> Obtengo la oferta ganadora de la subasta
                    DataRow ofertaGanadora = ADOFacturacion
                                                .retrieveDataTable("GetOfertaGanadora", idPublicacion).Rows[0];

                    double montoOfertado = Convert.ToDouble(ofertaGanadora["Monto"]);
                    double cobroPorMontoOfertado = montoOfertado * coefVisibilidad;
                    acumImportePublicacion += cobroPorMontoOfertado;
                    acumCantidadPublicacion = stockPublicacion;
  
                }

                // --> Le sumo al importe por las ventas, el importe fijo de la visibilidad
                acumImportePublicacion += impFijoVisibilidad;

                Visibilidad vs = ADOVisibilidad.getVisibilidad(idVisibilidad);
                int cantFactDeTipoVis = vs.Contador;
                if (cantFactDeTipoVis == 9)
                {
                    acumImportePublicacion = 0;
                    ADOVisibilidad.setContadorVisibilidad(idVisibilidad, 0);
                    //seter valor contador en 0
                }
                else
                {
                    ADOVisibilidad.setContadorVisibilidad(idVisibilidad, cantFactDeTipoVis + 1);
                    //setear en cantFact + 1
                }
               
                ADOFacturacion.executeProcedure("SetItemFactura", nroFactura, acumCantidadPublicacion,
                    acumImportePublicacion, idPublicacion);


                acumFactura += acumImportePublicacion;
                
            }

            ADOFacturacion.executeProcedure("UpdateMontoFactura", nroFactura, acumFactura);

            MessageBox.Show("La facturación se ha procesado correctamente. Se realizo la factura N°: "
                + nroFactura.ToString() + ", por el importe de: $" + acumFactura.ToString());
            FormHelper.mostrarNuevaVentana(new MenuInicio(), this);
        }
    }
}
