using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce.Abm_Cliente;
using FrbaCommerce.ABM_Rol;
using FrbaCommerce.Comprar_Ofertar;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Helpers;
using FrbaCommerce.Login;
using FrbaCommerce.Abm_Empresa;
using FrbaCommerce.Model;

namespace FrbaCommerce
{
    public partial class MenuPrincipal : Form
    {
        private Usuario _usuario;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AbmEmpresaForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        public void mostrarPantallaUsuario(Usuario usuario)
        {
            _usuario = usuario;
            logoutToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Visible = false;
            var lista = Controls.OfType<Button>();
            foreach (var button in lista)
            {
                button.Visible = true;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new LoginForm(this).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("¿Está seguro que desea cerrar sesión?","FRBA Commerce v1.0",MessageBoxButtons.YesNo);

            if (dr != DialogResult.Yes) return;
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
            Logout();
        }

        private void Logout()
        {
            var lista = Controls.OfType<Button>();
            foreach (var button in lista)
            {
                button.Visible = false;
            }
        }

        private void btnComprarOfertar_Click(object sender, EventArgs e)
        {
            FormHelper.mostrarNuevaVentana(new ComprarOfertarForm(this,12), this);
        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            var frmGenPub = new frmGenerarPublicacion(this);
            //frmGenPub.publicacion = DAO.ADOPublicacion.getPublicacion(1);
            FormHelper.mostrarNuevaVentana(frmGenPub, this);
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AbmClienteForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void btbABMRol_Click(object sender, EventArgs e)
        {
            var nuevaForma = new AbmRolForm(this);
            FormHelper.mostrarNuevaVentana(nuevaForma, this);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            var frmFacturar = new Facturar_Publicaciones.frmFacturarPublicaciones(this);
            FormHelper.mostrarNuevaVentana(frmFacturar, this);
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            var frmCalificar = new Calificar_Vendedor.Calificar(this, Globals.userID);
            FormHelper.mostrarNuevaVentana(frmCalificar, this);
        }

    }
}
