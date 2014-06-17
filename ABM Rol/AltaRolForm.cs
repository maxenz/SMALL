using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Helpers;
using FrbaCommerce.Model;

namespace FrbaCommerce.ABM_Rol
{
    public partial class AltaRolForm : Form
    {
        private Form _padre;
        public AltaRolForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
            CargarFuncionalidades();
        }

        private void CargarFuncionalidades()
        {
            clbFuncionalidades.DataSource = DAOFuncionalidades.getFuncionalidades().DefaultView;
            clbFuncionalidades.DisplayMember = "Descripcion";
            clbFuncionalidades.ValueMember = "ID";
        }

        private void AltaRolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            if (!Validaciones()) return;
            try
            {
                DAORol.AgregarRol(GenerarRol());
                MessageBox.Show("Rol agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private Rol GenerarRol()
        {
            var lista = clbFuncionalidades.CheckedIndices.Cast<int>().ToList();

            return new Rol(tbNombre.Text, lista);
        }

        private bool Validaciones()
        {
            var listaDeErrores = new List<Error>();

            if (ValidarNombre() != null) listaDeErrores.Add(ValidarNombre());
            if (clbFuncionalidades.CheckedIndices.Cast<int>().ToList() == null) listaDeErrores.Add(new Error("Debe seleccionar al menos una Funcionalidad."));

            if (listaDeErrores.Count < 1) return true;

            var mensaje = listaDeErrores.Aggregate("Error en la validacion de datos:", (current, error) => current + ("\n" + error.Descripcion));
            MessageBox.Show(mensaje);
            return false;
        }

        private Error ValidarNombre()
        {
            bool existe = DAORol.existeRol(tbNombre.Text);
            return (tbNombre.Text != "" && !existe)
                ? null
                : new Error("Nombre de Rol invalido o ya existe uno con el mismo nombre.");
        }
    }
}
