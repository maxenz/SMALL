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
    class ADOComprar : SqlConnector
    {
        // --> Chequeo si el individuo tiene mas de 5 calificaciones pendientes, si da 1 es true.
        public static int CheckDebeCalificaciones(int IdPersona)
        {
            return SqlConnector.executeProcedureWithReturnValue("CheckDebeCalificaciones", IdPersona);
        }

    }
}
