using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using FrbaCommerce.CapaADO;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Model;

namespace FrbaCommerce.Login
{
    public partial class LoginForm : Form
    {
        MenuPrincipal _principal;
        const int IS_CLIENT = 2;

        public LoginForm(MenuPrincipal principal)
        {
            _principal = principal;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login_button.Enabled = false;
        }

        private void Cambios(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void validarCampos()
        {
            var nombreUsuario = tBoxNombreUsuario.Text;
            var password = tBoxPassword.Text;
            var camposAValidar = new List<ICampoAbstracto>
            {
                new Campo("Usuario", nombreUsuario, true, Controller.TipoValidacion.Alfanumerico),
                new Campo("Password", password, true, Controller.TipoValidacion.Alfanumerico)
            };

            try
            {
                Controller.validarCampos(camposAValidar);
                login_button.Enabled = true;
                errorBox.Text = "";
            }
            catch (ValidationException vEx)
            {
                errorBox.Text = vEx.mensaje;
                login_button.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ////Loggeo directo hasta que esten hechos los procedimientos en la BDD
            //_principal.mostrarPantallaUsuario(new Usuario("", new List<Rol>()));
            //DialogResult = DialogResult.OK;
            //Close();
            //return;
            //
            string nombreUsuario = tBoxNombreUsuario.Text;
            string password = tBoxPassword.Text;
            try
            {
                Usuario usuario = DAOUsuario.GetUsuario(nombreUsuario, password);
                Globals.userID = DAOUsuario.GetUserID(nombreUsuario);
                Globals.userID = DAOUsuario.GetUserID(nombreUsuario);
                MessageBox.Show("Bienvenido " + nombreUsuario);
                _principal.mostrarPantallaUsuario(usuario);
                Close();
            }

            catch (UsuarioNoEncontradoException notFound)
            {
                MessageBox.Show("No existe el usuario " + notFound.getNombreUsuario());
            }

            catch (UsuarioAlcanzoLimiteLoginsException maxLogin)
            {
                MessageBox.Show("El usuario " + maxLogin.getNombreUsuario() +
                                " se encuentra bloqueado por superar la cantidad maxima de logins permitidos.");
            }
            catch (PasswordIncorrectoException)
            {
                MessageBox.Show("Password incorrecto.");
            }
            catch (UsuarioSinRolesAsignadosException noRolEx)
            {
                MessageBox.Show("El usuario " + noRolEx.getNombreUsuario() + " no tiene ningun rol asignado.");
            }
        }

        private bool datosValidos(string username, string password)
        {
            return Controller.stringValido(username) && Controller.stringValido(password);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _principal.Visible = true;
            _principal.Activate();
            _principal.Select();
        }

        

    }
}
