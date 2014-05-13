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
    class ADORubro : SqlConnector
    {
        public static List<Rubro> getRubros()
        {
            List<Rubro> rubros = new List<Rubro>();
            DataTable table = getDatatable("SELECT * FROM SMALL.Rubro");
            foreach (DataRow dr in table.Rows)
            {
                Rubro rubro = new Rubro(Convert.ToInt32(dr["ID"]),dr["Descripcion"].ToString());

                rubros.Add(rubro);
            }
            return rubros;
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
