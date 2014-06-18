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

namespace FrbaCommerce.Historial_Cliente
{
    public partial class HistorialClienteForm : Form
    {
        Form _padre;
        int _idUsuario;

        public HistorialClienteForm(Form padre, int IdUsuario)
        {
            _padre = padre;
            _idUsuario = IdUsuario;
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboxHistoriales.SelectedIndex)
            {
                case 0:
                    this.cargarGrid(ADOHistorial.getMisComprasRealizadas(_idUsuario));

                    break;

                case 1:
                    this.cargarGrid(ADOHistorial.getMisOfertasRealizadas(_idUsuario));

                    break;
                case 2:
                    this.cargarGrid(ADOHistorial.getCalificacionesOtorgadas(_idUsuario));

                    break;
                case 3:
                    this.cargarGrid(ADOHistorial.getCalificacionesRecibidas(_idUsuario));

                    break;
                default:
                    break;
            }
            dgvHistorial.AutoResizeColumns();
            dgvHistorial.AutoResizeRows();
        }
        
        private void cargarGrid(DataTable dt)
        {
            dgvHistorial.Visible = true;
            dgvHistorial.DataSource = dt;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHelper.volverAPadre(_padre);
        }
    }
}
