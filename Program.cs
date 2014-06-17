using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FrbaCommerce.Login;

namespace FrbaCommerce
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var menu = new MenuPrincipal();
            var login = new LoginForm(menu);
            if (login.ShowDialog() == DialogResult.OK) Application.Run(menu);
        }
    }
}
