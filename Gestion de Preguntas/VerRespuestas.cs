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
using FrbaCommerce.Comprar_Ofertar;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class VerRespuestasForm : Form
    {
        Form _padre;

        public VerRespuestasForm(Form Padre)
        {
            _padre = Padre;
            InitializeComponent();
        }

        private void ResponderPreguntas_Load(object sender, EventArgs e)
        {
            //Acá me debe traer todas las preguntas que yo hice a otras publicaciones.
            dgvPreguntas.DataSource = ADOPreguntarResponder.getPeguntasRespondidas(12353); //Le paso mi usuario para saber que preguntas hice y devuelvo las que tienen respuestas
            dgvPreguntas.Columns[0].Visible = false;
            dgvPreguntas.Columns[1].Visible = false;
            dgvPreguntas.Columns[2].Width = 350;
            dgvPreguntas.Columns[3].Width = 350;
            dgvPreguntas.Columns[4].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }

        private void dgvPreguntas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Publicacion p = new Publicacion();
            DataGridViewRow r = (DataGridViewRow)dgvPreguntas.Rows[e.RowIndex];

            int IdPublicacion = Convert.ToInt32(r.Cells[1].Value);

            bool SoloVeo = true;

            Form MostrarPubForm = new MostrarPublicacionForm(this, IdPublicacion, SoloVeo);

            MostrarPubForm.Visible = true;
            MostrarPubForm.Activate();
            MostrarPubForm.Select();
            this.Hide();
        }

    }
}
