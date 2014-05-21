﻿using System;
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

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class ComprarOfertarForm : Form
    {
        Form _padre;

        DataTable dtPublicaciones = new DataTable();
        DataTable dtPagina = new DataTable();
        DataRow fila;
        //DataRow drAux;

        int filasPagina = 15; // Definimos el numero de filas que deseamos ver por pagina, tambien puede leerse desde un archivo de configuracion.
        int nroPagina = 1;//Esto define el numero de pagina actual en al que  nos encontramos
        int ini = 0; //inicio del paginado
        int fin = 0;//fin del paginado
        int numeroRegistro;

        public ComprarOfertarForm(Form padre)
        {
            _padre = padre;
            InitializeComponent();
        }

        private void ComprarOfertarForm_Load(object sender, EventArgs e)
        {

            cmbRubros.DataSource = ADORubro.getRubros();
            cmbRubros.DisplayMember = "Descripcion";
            cmbRubros.ValueMember = "ID";
            cmbRubros.SelectedItem = null;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //List<Publicacion> lPublicaciones = new List<Publicacion>();

            //lPublicaciones = ADOPublicacion.GetPublicaciones();

            //this.dgvGrillaPublicaciones.DataSource = lPublicaciones;

            this.Buscar();

        }

        private void Buscar()
        {
            //clsEmpresa empresa = new clsEmpresa();
            List<Publicacion> lPublicaciones = ADOPublicacion.GetPublicaciones();//Metodo que devuelve un datatable como resultado de la ejecucion de una consulta 
            dtPublicaciones = FormHelper.ConvertToDT<Publicacion>(lPublicaciones);

            dtPagina.Columns.Add("Id");
            dtPagina.Columns.Add("Visibilidad");
            dtPagina.Columns.Add("Tipo Publicacion");
            dtPagina.Columns.Add("Estado");
            dtPagina.Columns.Add("Persona Venta");
            dtPagina.Columns.Add("Descripcion");
            dtPagina.Columns.Add("Fecha Inicio");
            dtPagina.Columns.Add("Fecha Venicimento");
            dtPagina.Columns.Add("Stock");
            dtPagina.Columns.Add("Precio");
            dtPagina.Columns.Add("Habilita Preguntas");

            if (dtPublicaciones.Rows.Count > 0)
            {
                this.numPaginas(); //Funcion para calcular el numero total de paginas que tendra nuestra vista
                this.paginar();//empezamos con la paginacion
                lblCantidadTotal.Text = "Publicaciones Encontradas: " + dtPublicaciones.Rows.Count.ToString();//Cantidad totoal de registros encontrados
                dgvGrillaPublicaciones.Select();
            }
            else
            {
                dgvGrillaPublicaciones.Rows.Clear();//En el caso de que la busqueda no genere ningun registro limopiamos el datagridview
                lblCantidadTotal.Text = "Publicaciones Encontradas: 0";
            }
        }

        private void paginar()
        {
            nroPagina = Convert.ToInt32(lblPaginaActual.Text); //Obtenemos el numero de pagina atual 
            if (dtPublicaciones.Rows.Count > filasPagina)
            {
                this.ini = nroPagina * filasPagina - filasPagina;
                this.fin = nroPagina * filasPagina;
                if (fin > dtPublicaciones.Rows.Count)
                    fin = dtPublicaciones.Rows.Count;
            }
            else
            {
                this.ini = 0;
                this.fin = dtPublicaciones.Rows.Count;
            }

            //dgvGrillaPublicaciones.Rows.Clear();
            //int indiceInsertar;
            //Ver esto pq esta agregando columnas cada vez que pagino!!!!!
            numeroRegistro = this.ini;
            dtPagina.Clear();

            for (int i = ini; i < fin; i++)
            {
                
                //DataRow dr = dtPagina.NewRow();
                fila = dtPublicaciones.Rows[i];
                //numeroRegistro = numeroRegistro + 1;
                dtPagina.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8], fila[9], fila[10]);

            }
            //ojo con esto que no está liberando la memoria del gridview, jaja, una negrada pero para salir del paso va!
            dgvGrillaPublicaciones.DataSource = null;
            dgvGrillaPublicaciones.Refresh();
            dgvGrillaPublicaciones.DataSource = dtPagina;
            dgvGrillaPublicaciones.AllowUserToAddRows = false;

        }

        private void numPaginas()
        {
            if (dtPublicaciones.Rows.Count % filasPagina == 0)
                lblTotalPagina.Text = (dtPublicaciones.Rows.Count / filasPagina).ToString();
            else
            {
                double valor = dtPublicaciones.Rows.Count / filasPagina;
                lblTotalPagina.Text = (Convert.ToInt32(valor) + 1).ToString();

            }
            lblPaginaActual.Text = "1";
        }

        private void llblPrimero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert.ToInt32(lblTotalPagina.Text) > 1)
            {
                this.nroPagina = 1;
                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void llblUltimo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert.ToInt32(lblTotalPagina.Text) > 1)
            {
                this.nroPagina = Convert.ToInt32(lblTotalPagina.Text);
                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void llblAnterior_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert.ToInt32(lblPaginaActual.Text) > 1)
            {
                this.nroPagina -= 1;
                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void llblSiguiete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert.ToInt32(lblPaginaActual.Text) < Convert.ToInt32(lblTotalPagina.Text))
            {
                this.nroPagina += 1;
                lblPaginaActual.Text = this.nroPagina.ToString();
                this.paginar();
            }
        }

        private void dgvGrillaPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Publicacion p = new Publicacion();
            DataGridViewRow r = (DataGridViewRow)dgvGrillaPublicaciones.Rows[e.RowIndex];

            int i = Convert.ToInt32(r.Cells[0].Value);

            Form MostrarPubForm = new MostrarPublicacionForm(this, i);

            MostrarPubForm.Visible = true;
            MostrarPubForm.Activate();
            MostrarPubForm.Select();
            this.Hide();
        }
    }
}
