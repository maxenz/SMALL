using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.DAO
{
    class ADOPublicacion : SqlConnector
    {
        /*****************************
         * Obtengo el ultimo codigo de publicacion y le sumo 1 *
         ****************************/
        public static int getNewPublicacionNumber()
        {
            int newPublicacionNumber = 0;
            DataTable dt = getDatatable("SELECT TOP 1 ID FROM SMALL.Publicacion " +
                                        "ORDER BY ID DESC");
            if (dt.Rows.Count > 0) {
                newPublicacionNumber = Convert.ToInt32(dt.Rows[0]["ID"]);
            } 
             
            newPublicacionNumber += 1;
            return newPublicacionNumber;
        }

        public static List<EstadoPublicacion> getEstadosPublicacion() {

            List<EstadoPublicacion> estadosPublicacion = new List<EstadoPublicacion>();
            DataTable table = getDatatable("SELECT * FROM SMALL.Estado_Publicacion");
            foreach (DataRow dr in table.Rows)
            {
                EstadoPublicacion estadoPublicacion = new EstadoPublicacion(Convert.ToInt32(dr["ID"]),
                    dr["Descripcion"].ToString());
                estadosPublicacion.Add(estadoPublicacion);
            }
            return estadosPublicacion;
        }


        private static DataTable getDatatable(string consulta) {

            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            List<string> args = new List<string>();

                conexionSql(cn, cm);
                cm.CommandText = consulta;
                dr = cm.ExecuteReader();
                dt.Load(dr);

            return dt;

        }

         /*****************************
         * Obtengo un listado de los tipos de publicacion *
         ****************************/
        public static List<TipoPublicacion> getTiposDePublicacion()
        {
            List<TipoPublicacion> tiposDePublicacion = new List<TipoPublicacion>();
            DataTable table = getDatatable("SELECT * FROM SMALL.Tipo_Publicacion");
            foreach (DataRow dr in table.Rows)
            {
                TipoPublicacion tip_pub = new TipoPublicacion(dr["Descripcion"].ToString());
                tip_pub.ID = Convert.ToInt32(dr["ID"]);
                tiposDePublicacion.Add(tip_pub);
            }
            return tiposDePublicacion;
        }

        //Esto hay que cambiarlo por el procedure
        public static List<Publicacion> GetPublicaciones()
        {

            List<Publicacion> lPublicaciones = new List<Publicacion>();

            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;

            conexionSql(cn, cm);

            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from SMALL.Publicacion";

            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                Publicacion p = new Publicacion(Convert.ToInt32(dr["Id"]),
                    Convert.ToInt32(dr["Id_Visibilidad"]),
                    Convert.ToInt32(dr["Id_Tipo_Publicacion"]),
                    Convert.ToInt32(dr["Id_Estado"]),
                    Convert.ToInt32(dr["Id_Persona"]),
                    dr["Descripcion"].ToString(),
                    Convert.ToDateTime(dr["Fecha_Inicio"]),
                    Convert.ToDateTime(dr["Fecha_Vencimiento"]),
                    Convert.ToInt32(dr["Stock"]),
                    Convert.ToDouble(dr["Precio"]),
                    Convert.ToBoolean(dr["Hab_Preguntas"]));

                lPublicaciones.Add(p);
            }
            return lPublicaciones;
        }

    }
}
