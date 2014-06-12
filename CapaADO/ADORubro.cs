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
            DataTable table = SqlConnector.retrieveDataTable("getRubros");
            foreach (DataRow dr in table.Rows)
            {
                Rubro rubro = new Rubro(Convert.ToInt32(dr["ID"]),dr["Descripcion"].ToString());

                rubros.Add(rubro);
            }
            return rubros;
        }
    }
}
