using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Generar_Publicacion;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class SeleccionPublicacionForm : Form
    {
        int _idUsuario;
        Form _padre;

        public SeleccionPublicacionForm(Form padre, int IdUsuario)
        {
            _idUsuario = IdUsuario;
            _padre = padre;

            InitializeComponent();
        }

        private void SeleccionPublicacion_Load(object sender, EventArgs e)
        {
            dgvHistorial.Visible = true;
            dgvHistorial.DataSource = DAO.ADOPublicacion.getMisPublicaciones(_idUsuario);
            //Escondele todas las columnas que quieras.
            dgvHistorial.Columns[1].Visible = false;
        }


        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = (DataGridViewRow)dgvHistorial.Rows[e.RowIndex];

            int IdPublicacion = Convert.ToInt32(r.Cells[0].Value);

            frmGenerarPublicacion frmGenPub = new frmGenerarPublicacion(this);

            frmGenPub.publicacion = DAO.ADOPublicacion.getPublicacion(IdPublicacion);

            FormHelper.mostrarNuevaVentana(frmGenPub, this);
 
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHelper.volverAPadre(_padre);
        }

    }
}
