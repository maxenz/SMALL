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
    class ADOVisibilidad : SqlConnector
    {

        /*****************************
         * Obtengo un listado de las visibilidades *
         ****************************/
        public static List<Visibilidad> getVisibilidades()
        {
            List<Visibilidad> visibilidades = new List<Visibilidad>();
            DataTable table = getDatatable("SELECT * FROM SMALL.Visibilidad");
            foreach (DataRow dr in table.Rows)
            {
                Visibilidad visibilidad = new Visibilidad(Convert.ToInt32(dr["ID"])
                    ,dr["Descripcion"].ToString(),
                    Convert.ToDouble(dr["Precio"]),Convert.ToDouble(dr["Porcentaje"]),
                    Convert.ToBoolean(dr["Activo"]),Convert.ToInt32(dr["Dias_Activo"]));
                visibilidades.Add(visibilidad);
            }
            return visibilidades;
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

    }
}
