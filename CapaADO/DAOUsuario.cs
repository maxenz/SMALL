using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Model;

namespace FrbaCommerce.CapaADO
{
    public class DAOUsuario : SqlConnector
    {
        public static string GetUserPassword(string nombreUsuario)
        {
            DataTable dt = retrieveDataTable("getUserPassword", nombreUsuario);

            if (dt.Rows.Count == 0) return null;

            DataRow dr = dt.Rows[0];
            return dr["PassSHA256"].ToString();
        }

        public static int GetInvalidLogins(string nombreUsuario)
        {
            DataTable dt = retrieveDataTable("getInvalidLogins", nombreUsuario);
            return Convert.ToInt32(dt.Rows[0]["InvalidLogins"]);
        }

        public static void RaiseInvalidLogin(string nombreUsuario)
        {
            executeProcedure("raiseInvalidLogin", nombreUsuario);
        }

        public static void ResetInvalidLogins(string nombreUsuario)
        {
            executeProcedure("resetInvalidLogins", nombreUsuario);
        }

        public static int GetUserID(string nombreUsuario)
        {
            return Convert.ToInt32(SqlConnector.retrieveDataTable("GetUserID", nombreUsuario)
                    .Rows[0]["ID"]);
        }

        public static Usuario GetUsuario(string nombreUsuario, string password)
        {
            var passObtenido = GetUserPassword(nombreUsuario); //Traigo el hash del password del usuario en la tabla
            var passIngresado = Hasher.Hash(password); //Hasheo el password ingresado

            if (passObtenido == null) throw new UsuarioNoEncontradoException(nombreUsuario);

            //Valido que el usuario no haya pasado el limite de logins invalidos
            if (GetInvalidLogins(nombreUsuario) >= 3) throw new UsuarioAlcanzoLimiteLoginsException(nombreUsuario);

            //Chequeo que los hash coincidan
            if (passObtenido.Equals(passIngresado))
            {
                ResetInvalidLogins(nombreUsuario); //reseteo la cantidad de intentos de logins fallidos
                var rolesUsuario = DAORol.getRolesUsuario(nombreUsuario);

                if (rolesUsuario.Count == 0) throw new UsuarioSinRolesAsignadosException(nombreUsuario);

                Globals.setAdminLoggeado(true);
                return new Usuario(nombreUsuario, rolesUsuario);
            }
            
            //Password invalido, incremento la cantidad de logins fallidos
            RaiseInvalidLogin(nombreUsuario);
            throw new PasswordIncorrectoException();
            
        }

    }
}
