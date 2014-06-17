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
        int _persona;
        Form _padre;

        public ResponderPreguntasForm(Form Padre, int IdPersona)
        {
            _persona = IdPersona;
            _padre = Padre;
            InitializeComponent();


        }

        public void UpdateGrid()
        {
            //Acá me debe traer todas las preguntas de MIS publicaciones SIN responder.
            dgvPreguntas.DataSource = ADOPreguntarResponder.getPeguntasSinResponder(_persona);
            dgvPreguntas.Columns[0].Visible = false;
            dgvPreguntas.Columns[1].Visible = false;
            dgvPreguntas.Columns[2].Width = 250;
            dgvPreguntas.Columns[3].Width = 250; 
        }

        private void ResponderPreguntas_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }

        private void dgvPreguntas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = (DataGridViewRow)dgvPreguntas.Rows[e.RowIndex];

            int IdPublicacion = Convert.ToInt32(r.Cells[0].Value);
            int IdPreguntaRespuesta = Convert.ToInt32(r.Cells[1].Value);
            string Pregunta = Convert.ToString(r.Cells[3].Value);

            Form MostrarPubForm = new ResponderForm(this, IdPreguntaRespuesta, IdPublicacion, Pregunta);

            MostrarPubForm.Visible = true;
            MostrarPubForm.Activate();
            MostrarPubForm.Select();
            this.Hide();

        }

    }
}
