using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace FrbaCommerce
{
    class Globals
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BaseDatos"].ConnectionString;
        private static bool isLogged = false;

        public static string getConnectionString()
        {
            return connectionString;
        }

        public static DateTime getFechaSistema()
        {
            return Convert.ToDateTime(ConfigurationSettings.AppSettings["fechaSistema"]);
        }

        public static void setAdminLoggeado(bool status)
        {
            isLogged=status;
        }

        public static bool adminLoggeado()
        {
            return isLogged;
        }


    }
}
