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
    class ADOPreguntarResponder : SqlConnector
    {
        // --> Inserto la pregunta en la tabla
        public static void InsertaPregunta(int IdPublicacion, int IdPersona, string Pregunta)
        {
            SqlConnector.executeProcedure("InsertaPregunta", IdPublicacion, IdPersona, Pregunta);
        }

        // --> Inserto la pregunta en la tabla
        public static void InsertaRespuesta(int IdPreguntaRespuesta, string Respuesta, DateTime Fecha)
        {
            SqlConnector.executeProcedure("InsertaRespuesta", IdPreguntaRespuesta, Respuesta, Fecha);
        }

        //Preguntas que me hacen y todavia no respondí!!!!!
        public static DataTable getPeguntasSinResponder(int IdUsuarioVenta)
        {
            DataTable table = SqlConnector.retrieveDataTable("getPreguntasSinResponder", IdUsuarioVenta);
            return table;
        }

        //Preguntas que hice a otras publicaciones y ya me respondieron!!!!
        public static DataTable getPeguntasRespondidas(int IdUsuarioPregunta)
        {
            DataTable table = SqlConnector.retrieveDataTable("getPreguntasRespondidas", IdUsuarioPregunta);
            return table;
        }

        private static DataTable getDatatable(string consulta)
        {

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
    }
}
