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
            DataTable table = SqlConnector.retrieveDataTable("GetVisibilidades");
            foreach (DataRow dr in table.Rows)
            {
                Visibilidad visibilidad = dataRowToVisibilidad(dr);
                visibilidades.Add(visibilidad);
            }
            return visibilidades;
        }

        public static Visibilidad getVisibilidad(int idVisibilidad)
        {
            DataRow dr = SqlConnector.retrieveDataTable("GetVisibilidad",idVisibilidad).Rows[0];
            return dataRowToVisibilidad(dr);

        }

        private static Visibilidad dataRowToVisibilidad(DataRow dr)
        {
            Visibilidad vis = new Visibilidad(Convert.ToInt32(dr["ID"])
                    , dr["Descripcion"].ToString(),
                    Convert.ToDouble(dr["Precio"]), Convert.ToDouble(dr["Porcentaje"]),
                    Convert.ToBoolean(dr["Activo"]), Convert.ToInt32(dr["Dias_Activo"]),
                    Convert.ToInt32(dr["Contador"]));

            return vis;

        }

        public static void setContadorVisibilidad(int idVisibilidad, int contador)
        {

            SqlConnector.executeProcedure("SetContadorVisibilidad", idVisibilidad, contador);

        }

    }
}
