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

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class ListadosForm : Form
    {
        Form _padre;

        public ListadosForm(Form padre)
        {
            _padre = padre;
            InitializeComponent();
        }

        private void ListadosForm_Load(object sender, EventArgs e)
        {
            dgvListado.Visible = true;
            label4.Visible = false;
            cboxMes.Visible = false;
            cargarComboBoxAños();
            cargarComboBoxTrimestre();
            cboxListado.SelectedIndex = 0;
        }
        
        private void ListadoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           FormHelper.volverAPadre(_padre);
        }

        public void cargarComboBoxAños()
        {
            List<KeyValuePair<string, int>> anios = new List<KeyValuePair<string, int>>();
            anios.Add(generarKeyValueInt("2010", 2010));
            anios.Add(generarKeyValueInt("2011", 2011));
            anios.Add(generarKeyValueInt("2012", 2012));
            anios.Add(generarKeyValueInt("2013", 2013));
            anios.Add(generarKeyValueInt("2014", 2014));
            cboxAnio.DisplayMember = "Key";
            cboxAnio.ValueMember = "Value";
            cboxAnio.DataSource = anios;
            cboxAnio.SelectedIndex = 0;
        }

        public void cargarComboBoxTrimestre()
        {
            List<KeyValuePair<string, int>> trimestre = new List<KeyValuePair<string, int>>();
            trimestre.Add(generarKeyValueInt("Primer", 1));
            trimestre.Add(generarKeyValueInt("Segundo", 2));
            trimestre.Add(generarKeyValueInt("Tercer", 3));
            trimestre.Add(generarKeyValueInt("Cuarto", 4));
            cboxTrimestre.DisplayMember = "Key";
            cboxTrimestre.ValueMember = "Value";
            cboxTrimestre.DataSource = trimestre;
            cboxTrimestre.SelectedIndex = 0;
        }

        public void cargarComboBoxMes()
        {
            int tri = ((KeyValuePair<string, int>)cboxTrimestre.SelectedItem).Value;

            List<KeyValuePair<string, int>> mes = new List<KeyValuePair<string, int>>();

            if(tri == 1)
            {
                mes.Clear();
                mes.Add(generarKeyValueInt("Enero", 1));
                mes.Add(generarKeyValueInt("Febrero", 2));
                mes.Add(generarKeyValueInt("Marzo", 3));
            }
            if (tri == 2)
            {
                mes.Clear();
                mes.Add(generarKeyValueInt("Abril", 4));
                mes.Add(generarKeyValueInt("Mayo", 5));
                mes.Add(generarKeyValueInt("Junio", 6));
            }
            if (tri == 3)
            {
                mes.Clear();
                mes.Add(generarKeyValueInt("Julio", 7));
                mes.Add(generarKeyValueInt("Agosto", 8));
                mes.Add(generarKeyValueInt("Septiembre", 9));
            }
            if (tri == 4)
            {
                mes.Clear();
                mes.Add(generarKeyValueInt("Octubre", 10));
                mes.Add(generarKeyValueInt("Noviembre", 11));
                mes.Add(generarKeyValueInt("Diciembre", 12));
            }
            cboxMes.DisplayMember = "Key";
            cboxMes.ValueMember = "Value";
            cboxMes.DataSource = mes;
        }

        private KeyValuePair<string, int> generarKeyValueInt(string descripcion, int numero)
        {
            return new KeyValuePair<string, int>(descripcion, numero);
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            int trimestre = this.getTrimestre();
            int anio = this.getAnio();
            int mes = this.getMes();
            switch (cboxListado.SelectedIndex)
            {
                case 0:
                    this.cargarGrid(ADOListados.getTop5VendedoresMayorCantidadProductosNoVendidos(mes, trimestre, anio));

                    break;

                case 1:
                    this.cargarGrid(ADOListados.getTop5VendedoresMayorFacturacion(trimestre, anio));

                    break;
                case 2:
                    this.cargarGrid(ADOListados.getTop5VendedoresMayorCalificacion(trimestre, anio));

                    break;
                case 3:
                    this.cargarGrid(ADOListados.getTop5ClientesMayorCantPubliSinCalificar(trimestre, anio));

                    break;
                default:
                    break;
            }
            dgvListado.AutoResizeColumns();
            dgvListado.AutoResizeRows();
        }

        private int getAnio()
        {
            return ((KeyValuePair<string, int>)cboxAnio.SelectedItem).Value;
        }

        private int getTrimestre()
        {
            return ((KeyValuePair<string, int>)cboxTrimestre.SelectedItem).Value;
        }

        private int getMes()
        {
            return ((KeyValuePair<string, int>)cboxMes.SelectedItem).Value;
        }

        private void cargarGrid(DataTable dt)
        {
            dgvListado.Visible = true;
            dgvListado.DataSource = dt;
        }

        private void cboxTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboBoxMes();
        }

        private void cboxListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxListado.SelectedIndex)
            {
                case 0:
                    label4.Visible = true;
                    cboxMes.Visible = true; 
                    break;

                case 1:
                    label4.Visible = false;
                    cboxMes.Visible = false;
                    break;
                case 2:
                    label4.Visible = false;
                    cboxMes.Visible = false;
                    break;
                case 3:
                    label4.Visible = false;
                    cboxMes.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHelper.volverAPadre(_padre);
        }
    }
}
