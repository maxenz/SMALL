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

namespace FrbaCommerce.ABM_Rol
{
    public partial class ModificarRolForm : Form
    {
        private Form _padre;
        private Rol _rol;

        public ModificarRolForm(int id, Form padre)
        {
            InitializeComponent();
            _padre = padre;
            CargarRol(id);
            tbNombre.Text = _rol.Nombre;
            CargarFuncionalidades();
        }

        private void CargarRol(int id)
        {
            _rol = DAORol.getRol(id);
        }

        private void CargarFuncionalidades()
        {
            clbFuncionalidades.DataSource = DAOFuncionalidades.getFuncionalidades().DefaultView;
            clbFuncionalidades.DisplayMember = "Descripcion";
            clbFuncionalidades.ValueMember = "ID";

            foreach (var func in _rol.Funcionalidades)
            {
                clbFuncionalidades.SetItemChecked(func,true);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Validaciones()) return;
            try
            {
                DAORol.UpdateRol(GenerarRol());
                MessageBox.Show("Rol agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private bool Validaciones()
        {
            return true;
        }

        private Rol GenerarRol()
        {
            throw new NotImplementedException();
        }
    }
}
