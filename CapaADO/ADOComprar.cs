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

        // --> Inserto la compra
        public static void InsertaCompra(int IdPublicacion, int IdPersona, int Cantidad, DateTime Fecha)
        {
            SqlConnector.executeProcedure("InsertaCompra", IdPublicacion, IdPersona, Cantidad, Fecha);
        }

        public static void InsertaOferta(int IdPublicacion, int IdPersona, int Precio, DateTime Fecha)
        {
            SqlConnector.executeProcedure("InsertaOferta", IdPublicacion, IdPersona, Precio, Fecha);
        }

    }
}
