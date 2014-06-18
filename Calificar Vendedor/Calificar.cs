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

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class Calificar : Form
    {
        Form _padre;
        int _persona;

        int nroPagina = 1;
        int fin = 0;

        public Calificar(Form padre, int IdPersona)
        {
            _persona = IdPersona;
            _padre = padre;
            InitializeComponent();
        }

        private void searchPublicaciones()
        {
            this.Buscar();

        }

        private void Calificar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchPublicaciones();

        }

        private ProductoACalificar rowToProducto(DataRow r)
        {
            ProductoACalificar p = new ProductoACalificar(
                Convert.ToInt32(r["ID_Publicacion"]), Convert.ToDateTime(r["Fecha"]));
            return p;
        }

        private void Buscar()
        {

            DataTable dtCompras = ADOCalificacion.getComprasACalificar(_persona);

            DataTable dtSubastas = ADOCalificacion.getSubastasACalificar(_persona);

            List<ProductoACalificar> prodsToCal = new List<ProductoACalificar>();

            foreach (DataRow r in dtCompras.Rows)
            {
                prodsToCal.Add(rowToProducto(r));

            }

            foreach (DataRow r in dtSubastas.Rows)
            {
                prodsToCal.Add(rowToProducto(r));

            }
  
            int skipReg = (nroPagina * 10) - 10;
            fin = (prodsToCal.Count() / 10);
            if (prodsToCal.Count() % 10 > 0) fin++;

            prodsToCal = prodsToCal.Skip(skipReg).Take(10).ToList();
            dgvGrillaPublicaciones.DataSource = prodsToCal;

        }

        private void Calificar_Load(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            nroPagina = 1;
            searchPublicaciones();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (nroPagina > 1)
            {
                nroPagina--;
                searchPublicaciones();
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nroPagina < fin)
            {
                nroPagina++;
                searchPublicaciones();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            nroPagina = fin;
            searchPublicaciones();
        }

        private void dgvGrillaPublicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPublicacion = Convert.ToInt32(dgvGrillaPublicaciones.Rows[e.RowIndex].Cells["ID_Publicacion"].Value);
            FormHelper.mostrarNuevaVentana(new CalificarDetalle(this, Globals.userID, idPublicacion), this);
            this.Hide();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.mostrarNuevaVentana(new MenuInicio(),this);
        }

    }
}
