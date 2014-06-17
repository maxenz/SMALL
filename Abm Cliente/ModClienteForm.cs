using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Helpers;
using FrbaCommerce.Model;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class ModClienteForm : Form
    {
        private Cliente _cliente;
        private Form _padre;
        private int ID;
        public ModClienteForm(int id, Form padre)
        {
            InitializeComponent();
            _padre = padre;
            _padre.Enabled = false;
            _cliente = DAOCliente.getCliente(id);
            ID = id;
            cbTipoDoc.DataSource = DAOCliente.TiposDocumento().DefaultView;
            cbTipoDoc.DisplayMember = "Descripcion";
            CargarComponentes();
        }

        private void CargarComponentes()
        {
            var p = _cliente.Persona;

            tbCalle.Text = p.calle;
            tbNroCalle.Text = p.nroCalle.ToString();
            tbCiudad.Text = p.ciudad;
            tbCodigoPostal.Text = p.codPostal;
            tbDepartamento.Text = p.departamento;
            tbEMail.Text = p.eMail;
            tbLocalidad.Text = p.localidad;
            tbPiso.Text = p.piso;
            tbTelefono.Text = p.telefono;

            tbNombre.Text = _cliente.Nombre;
            tbApellido.Text = _cliente.Apellido;
            tbDni.Text = _cliente.Documento;
            tbCuil.Text = _cliente.Cuil;
            cbTipoDoc.SelectedIndex = _cliente.TipoDoc - 1;
            dtpFechaNac.Value = _cliente.FechaDeNacimiento;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {

                try
                {
                    DAOCliente.UpdateCliente(GenerarCliente(), ID);
                    MessageBox.Show("Cliente modificado correctamente.");
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
            Close();
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
            return new Cliente(persona, tbNombre.Text, tbApellido.Text, tbDni.Text, tbCuil.Text, (byte)(cbTipoDoc.SelectedIndex + 1), dtpFechaNac.Value);
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarDni() != null) listaDeErrores.Add(ValidarDni());
            if (ValidarTelefono() != null) listaDeErrores.Add(ValidarTelefono());

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarDni()
        {
            return (DAOCliente.existeDni(tbDni.Text, cbTipoDoc.SelectedIndex + 1) && tbDni.Text != _cliente.Documento )? new Error("El documento ingresado ya está asignado a un usuario registrado.") : null;
        }

        private Error ValidarTelefono()
        {
            return (DAOCliente.existeTelefono(tbTelefono.Text) && tbDni.Text != _cliente.Documento )? new Error("El telefono ingresado ya está asignado a un usuario registrado.") : null;
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
            dtpFechaNac.Value = new DateTime(1996, 1, 1);
        }

        private void ModClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _padre.Enabled = true;
        }
    }
}
