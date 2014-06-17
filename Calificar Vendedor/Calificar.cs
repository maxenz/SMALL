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
            int IdRubro = Convert.ToInt32(cmbRubros.SelectedValue);
            string Descripcion = txtDescripcion.Text;
            this.Buscar(IdRubro, Descripcion);
            dgvGrillaPublicaciones.Columns[0].Visible = false;

        }

        private void Calificar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            searchPublicaciones();

        }

        private void Buscar(int IdRubro, string Descripcion)
        {

            List<Publicacion> lPublicaciones = ADOPublicacion.getPublicacionesACalificar(_persona);

            if (IdRubro != 0)
            {
               
                lPublicaciones = lPublicaciones
                    .Where(x => x.Rubros.Exists(j => j.ID == IdRubro))
                    .ToList();
            }
            
            if (Descripcion != "")
            {
                lPublicaciones = lPublicaciones
                                .Where(x => x.Descripcion.Contains(Descripcion))
                                .ToList();
            }

            int skipReg = (nroPagina * 10) - 10;
            fin = (lPublicaciones.Count() / 10);
            if (lPublicaciones.Count() % 10 > 0) fin++;

            lPublicaciones = lPublicaciones.Skip(skipReg).Take(10).ToList();
            dgvGrillaPublicaciones.DataSource = lPublicaciones;

        }

        private void Calificar_Load(object sender, EventArgs e)
        {
            //En este load debería verificar el estado de las publicaciones en relacion a la fecha del momento.
            cmbRubros.DataSource = ADORubro.getRubros();
            cmbRubros.DisplayMember = "Descripcion";
            cmbRubros.ValueMember = "ID";
            cmbRubros.SelectedItem = null;
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
            int idPublicacion = Convert.ToInt32(dgvGrillaPublicaciones.Rows[e.RowIndex].Cells["ID"].Value);
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
