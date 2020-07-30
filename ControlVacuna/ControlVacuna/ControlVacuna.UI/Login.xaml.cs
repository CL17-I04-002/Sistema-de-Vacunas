using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

using ControlVacuna.AccesoDatos;
using ControlVacuna.LogicaDeNegocio;

namespace ControlVacuna.UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        public bool Aceptado { get; set; }

        ////Instanciar las clases logica de negocios y acceso a datos

        AdministradorBL _adminBL = new AdministradorBL();
        Administrador _adminEntity = new Administrador();

        public Login()
        {
            InitializeComponent();
        }
        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            txtNick.Focus();
        }

        private async void btnIniciar_Sesion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (txtNick.Text == string.Empty)
                //{
                //    string error = Convert.ToString(await this.ShowMessageAsync("Usuario incorrecto", "Error"));
                //}
                //if (txtPass.Password == string.Empty)
                //{
                //    string error = Convert.ToString(await this.ShowMessageAsync("Contraseña incorrecto", "Error"));
                //}
                if (txtNick.Text == string.Empty || txtPass.Password == string.Empty)
                {
                    string error = Convert.ToString(await this.ShowMessageAsync("Error", "Usuario o contraseña incorrecto"));
                }
                if (!(txtNick.Text == string.Empty || txtPass.Password == string.Empty))
                {
                    var admin = new Administrador
                    {
                        Nick = txtNick.Text,
                        Pass = txtPass.Password
                    };

                    if (_adminBL.ValidarAcceso(admin))
                    {
                        await this.ShowMessageAsync("Bienvenido", txtNick.Text);
                        Aceptado = true;
                        DialogResult = true;
                    }
                    else
                    {
                        string error = Convert.ToString(await this.ShowMessageAsync("Error", "Usuario o contraseña incorrecto"));
                        //txtNick.Text = string.Empty;
                        //txtPass.Password = string.Empty;
                        txtNick.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos algo ocurrió mal" + "Advertencia" + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            btnRegistrar.Visibility = Visibility.Hidden;

            Registro _regis = new Registro();
            _regis.Show();
        }

        private void btnRegistrar_Loaded(object sender, RoutedEventArgs e)
        {
            if (_adminBL.ObtenerAdministradores().Count == 0)
            {
                btnRegistrar.Visibility = Visibility.Visible;
            }
            else
            {
                btnRegistrar.Visibility = Visibility.Hidden;
            }
        }
    }
}
