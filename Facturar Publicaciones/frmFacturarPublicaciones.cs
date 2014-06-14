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
            int idPersona = Convert.ToInt32(cmbPersonaFacturar.SelectedValue);
            int cantAFacturar = Convert.ToInt32(txtCantidadRendir.Text);

            idPersona = 37;

            string formaDePago;
            string descFormaDePago;
            if (cmbFormaDePago.Text == "Efectivo") {
                formaDePago = "Efectivo";
                descFormaDePago = "Pago en Efectivo";
            } else {
                formaDePago = "Tarjeta de Credito";
                descFormaDePago = txtNroTarjeta + " / " + txtVencimientoTarjeta + " / " + txtCodSegTarjeta;
            }
            
            DateTime fecUltPubFacturada = Convert.ToDateTime(ADOFacturacion
                                    .getLastPublicacionFacturada(idPersona).Rows[0]["Fecha_Vencimiento"]);
            //primero obtengo cual es la ultima publicacion facturada. para que sea mas sencillo
            //las ordeno segun fecha de vencimiento

            DataTable dtPubAFacturar = ADOFacturacion
                                        .getPublicacionesAFacturar(cantAFacturar, fecUltPubFacturada, idPersona);


            // Genero factura y devuelvo el id que fue creado.
            int nroFactura = Convert.ToInt32(ADOFacturacion
                                .setFactura(formaDePago, descFormaDePago, idPersona).Rows[0]["ID"]);

            double acumFactura = 0;

            foreach (DataRow dr in dtPubAFacturar.Rows)
            {
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

                if (tipoDePublicacion == 1)
                {

                    DataTable comprasDePublicacion = ADOFacturacion
                                                    .getComprasPublicacion(idPublicacion);
                    foreach (DataRow drComp in comprasDePublicacion.Rows)
                    {
                        int cantidadCompra = Convert.ToInt32(drComp["Cantidad"]);    
                        double cobroPorCompras = precioPublicacion * cantidadCompra * coefVisibilidad;
                        acumImportePublicacion += cobroPorCompras;
                        acumCantidadPublicacion += cantidadCompra;
                    }


                    //es una compra inmediata
                }
                else
                {
                    DataRow ofertaGanadora = ADOFacturacion
                                                .retrieveDataTable("GetOfertaGanadora", idPublicacion).Rows[0];

                    double montoOfertado = Convert.ToDouble(ofertaGanadora["Monto"]);
                    double cobroPorMontoOfertado = montoOfertado * coefVisibilidad;
                    acumImportePublicacion += cobroPorMontoOfertado;
                    //es una subasta
                }

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


        }
    }
}
