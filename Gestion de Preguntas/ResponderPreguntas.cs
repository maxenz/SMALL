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

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class ResponderPreguntasForm : Form
    {
        Form _padre;

        public ResponderPreguntasForm(Form Padre)
        {
            _padre = Padre;
            InitializeComponent();
        }

        private void ResponderPreguntas_Load(object sender, EventArgs e)
        {
            //Acá me debe traer todas las preguntas de MIS publicaciones SIN responder.
            dgvPreguntas.DataSource = ADOPreguntarResponder.getPeguntasSinResponder(12353);
            dgvPreguntas.Columns[0].Visible = false;
            dgvPreguntas.Columns[1].Visible = false;
            dgvPreguntas.Columns[2].Width = 700;
            dgvPreguntas.Columns[3].Visible = false;
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
            int IdPreguntaRespuesta = Convert.ToInt32(r.Cells[0].Value);
            string Pregunta = Convert.ToString(r.Cells[2].Value);

            Form MostrarPubForm = new ResponderForm(this, IdPreguntaRespuesta, IdPublicacion, Pregunta);

            MostrarPubForm.Visible = true;
            MostrarPubForm.Activate();
            MostrarPubForm.Select();
            this.Hide();

        }

    }
}
