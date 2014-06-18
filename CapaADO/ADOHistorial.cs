using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FrbaCommerce.CapaADO;

namespace FrbaCommerce.CapaADO
{
    class ADOHistorial : SqlConnector //Armar los procedures!!!!
    {
        public static DataTable getMisComprasRealizadas(int idPersona)
        {
            return SqlConnector.retrieveDataTable("getMisComprasRealizadas", idPersona);
        }
        public static DataTable getMisOfertasRealizadas(int idPersona)
        {
            return SqlConnector.retrieveDataTable("getMisOfertasRealizadas", idPersona);
        }
        public static DataTable getCalificacionesOtorgadas(int idPersona)
        {
            return SqlConnector.retrieveDataTable("getCalificacionesOtorgadas", idPersona);
        }
        public static DataTable getCalificacionesRecibidas(int idPersona)
        {
            return SqlConnector.retrieveDataTable("getCalificacionesRecibidas", idPersona);
        }
    }
}