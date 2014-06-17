using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Helpers;

namespace FrbaCommerce.ABM_Rol
{
    public partial class FiltrarRolForm : Form
    {
        private Form _padre;
        public FiltrarRolForm(Form padre)
        {
            InitializeComponent();
            _padre = padre;
            CargarGrid();
        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = DAORol.getRoles();

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void FiltrarRolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHelper.volverAPadre(_padre);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Modificar.DisplayIndex) ModificarRol(e.RowIndex);
            if (e.ColumnIndex == Baja.DisplayIndex) BajaRol(e.RowIndex);
        }

        private void BajaRol(int rowIndex)
        {
            var dr = MessageBox.Show("¿Activar Rol?", "Baja de Rol",MessageBoxButtons.YesNo);
            int id = (int)dataGridView1["ID", rowIndex].Value;

            DAORol.BajaRol(id, dr == DialogResult.Yes ? 1 : 0);
        }

        private void ModificarRol(int rowIndex)
        {
            int id = (int)dataGridView1["ID", rowIndex].Value;
            new ModificarRolForm(id, this).Show();
        }
    }
}
