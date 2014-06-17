using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class CalificarDetalle : Form
    {
        int _idPublicacion;
        Form _padre;
        int _persona;

        public CalificarDetalle(Form padre, int IdPersona, int idPublicacion)
        {
            _persona = IdPersona;
            _padre = padre;
            _idPublicacion = idPublicacion;
            InitializeComponent();
        }

        private void CalificarDetalle_Load(object sender, EventArgs e)
        {
            for (var k = 1; k < 6; k++)
            {
                cmbCalificacion.Items.Add(k);
            }

            cmbCalificacion.SelectedIndex = 0;
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {

            int cEstrellas = Convert.ToInt32(cmbCalificacion.Text);
            string detalleCalif = txtDetalleCalificacion.Text;

            DAO.ADOCalificacion.setCalificacion(_idPublicacion, cEstrellas, detalleCalif);

            MessageBox.Show("La calificación se ha enviado correctamente");

            this.Hide();
            FormHelper.mostrarNuevaVentana(new Calificar(this, Globals.userID), new MenuInicio());
            
            

        }
    }
}
