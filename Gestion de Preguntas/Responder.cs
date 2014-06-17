using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Helpers;
using FrbaCommerce.DAO;
using FrbaCommerce.Gestion_de_Preguntas;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class ResponderForm : Form
    {
        int _IdPreguntaRespuesta;
        int _IdPublicacion;
        string _pregunta;
        ResponderPreguntasForm _padre;

        public ResponderForm(ResponderPreguntasForm Padre, int IdPreguntaRespuesta, int IdPublicacion, string Pregunta)
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

            //Acá llamo al SP que me inserta la respuesta en el ID de pregunta correspondiente!!
            if (Convert.ToInt32(txtRespuesta.Text.Length.ToString()) >= 255)
                MessageBox.Show("Su respuesta es muy larga y supera los 255 caracteres, acórtela.", "Ojo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                ADOPreguntarResponder.InsertaRespuesta(_IdPreguntaRespuesta, txtRespuesta.Text.ToString(), Globals.getFechaSistema());
                MessageBox.Show("Su consulta ha sido procesada correctamente.", ";)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //ResponderPreguntasForm.ActiveForm.;
                //ver de actualizar la grilla del padre
                this.Close();
                _padre.UpdateGrid();
                FormHelper.volverAPadre(_padre);                
            }

        }


    }
}
