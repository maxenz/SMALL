﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.DAO
{
    class ADOCalificacion : SqlConnector
    {
        public static void setCalificacion(int idPublicacion, int cEstrellas, string detalle)
        {
            int idPersona = 37;

            DateTime fechaActual = DateTime.Now;
            SqlConnector.executeProcedure("SetCalificacion", idPublicacion, cEstrellas,
                detalle, fechaActual, idPersona);

        }

        public static DataTable getComprasACalificar(int _persona)
        {
            return SqlConnector.retrieveDataTable("GetComprasACalificar", _persona);
        }

        public static DataTable getSubastasACalificar(int _persona)
        {
            return SqlConnector.retrieveDataTable("GetSubastasACalificar", _persona);
        }
    }
 

}
