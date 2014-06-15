using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;
using FrbaCommerce.Gestion_de_Preguntas;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class ResponderForm : Form
    {
        int _IdPreguntaRespuesta;
        int _IdPublicacion;
        string _pregunta;
        Form _padre;

        public ResponderForm(Form Padre, int IdPreguntaRespuesta, int IdPublicacion, string Pregunta)
        {
            _IdPreguntaRespuesta = IdPreguntaRespuesta;
            _IdPublicacion = IdPublicacion;
            _padre = Padre;
            _pregunta = Pregunta;
            InitializeComponent();
        }

        private void ResponderForm_Load(object sender, EventArgs e)
        {
            txtPregunta.Text = _pregunta;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHelper.volverAPadre(_padre);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            
            //Acá llamo al SP que me inserta la pregunta en el ID de pregunta correspondiente!!
        }


    }
}
