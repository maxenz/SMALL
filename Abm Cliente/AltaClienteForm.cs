using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Model;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class AltaClienteForm : Form
    {
        private Form _padre;
        
        public AltaClienteForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
            cbTipoDoc.DataSource = DAOCliente.TiposDocumento().DefaultView;
            cbTipoDoc.DisplayMember = "Descripcion";
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
            dtpFechaNac.Value = new DateTime(1996,1,1);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;
            try
            {
                DAOCliente.AgregarCliente(GenerarCliente());
                MessageBox.Show("Cliente agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarDni() != null) listaDeErrores.Add(ValidarDni());
            if(ValidarTelefono() != null) listaDeErrores.Add(ValidarTelefono());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarDni()
        {
            return DAOCliente.existeDni(tbDni.Text, cbTipoDoc.SelectedIndex + 1)? new Error("El documento ingresado ya está asignado a un usuario registrado."):null;
        }

        private Error ValidarTelefono()
        {
            return DAOCliente.existeTelefono(tbTelefono.Text) ? new Error("El telefono ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Cliente GenerarCliente()
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
            return new Cliente(persona,tbNombre.Text,tbApellido.Text,tbDni.Text,tbCuil.Text,(byte)(cbTipoDoc.SelectedIndex+1),dtpFechaNac.Value);
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b')) e.Handled = true;
        }

        private void tbPiso_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(tbPiso.Text) > 255) tbPiso.Text = "";
        }
    }
}
