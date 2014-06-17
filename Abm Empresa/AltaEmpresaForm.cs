using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Model;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class AltaEmpresaForm : Form
    {
        private Form _padre;
        
        public AltaEmpresaForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();   
        }

        private void LimpiarCampos()
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                control.Text = "";
            }
            dtpFechaCreacion.Value = DateTime.Today;
        }

        private void AltaEmpresaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {

                try
                {
                    DAOEmpresa.AgregarEmpresa(GenerarEmpresa());
                    MessageBox.Show("Empresa agregada correctamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error." + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error en la validacion de datos. Corroborá que todos los campos ingresados esten llenos con la imformación correcta.");
            }

        }

        private bool Validaciones()
        {
            try
            {
                if (tbCuit.Text.Count() > 50) throw new Exception("Cuit demasiado largo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
            return true;
        }

        private Empresa GenerarEmpresa()
        {
            var persona = new Persona
            {
                calle = tbCalle.Text,
                nroCalle = Convert.ToInt32(tbNroCalle.Text),
                ciudad = tbCiudad.Text,
                codPostal = tbCodigoPostal.Text,
                departamento = tbDepartamento.Text,
                eMail = tbEMail.Text,
                localidad = tbLocalidad.Text,
                piso = tbPiso.Text,
                telefono = tbTelefono.Text
            };
            return new Empresa(persona, tbRazonSocial.Text, tbCuit.Text, tbNombreContacto.Text, dtpFechaCreacion.Value);
               
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFechaCreacion.Value = DateTime.Today;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') ) e.Handled = true;
        }

        private void tbPiso_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(tbPiso.Text) > 255) tbPiso.Text = "";
        }
        
    }
}
