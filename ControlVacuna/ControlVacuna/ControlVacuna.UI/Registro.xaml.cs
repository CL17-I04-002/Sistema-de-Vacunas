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
    /// Interaction logic for Registro.xaml
    /// </summary>
    public partial class Registro : MetroWindow
    {
        AdministradorBL _adminBL = new AdministradorBL();
        Administrador _adminEntity = new Administrador();

        public Registro()
        {
            InitializeComponent();
        }

        //private void Tile_Click_1(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Este formulario funciona para el registro de administradores para dar mantenimiento al control de vacunas de la persona: Daniel Larín");

        //}

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty && txtNick.Text == string.Empty && txtPass.Password == string.Empty && txtConfirmar.Password == string.Empty)
            {
                this.Close();
            }
            else
            {
                if (!(txtNombre.Text == string.Empty && txtApellido.Text == string.Empty && txtNick.Text == string.Empty && txtPass.Password == string.Empty && txtConfirmar.Password == string.Empty))
                {

                    if (MessageBox.Show("Está seguro que desea salir", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }
                    else
                    {
                        this.Close();
                    }

                }
            }
        }

        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!(txtPass.Password == txtConfirmar.Password))
                {
                    await this.ShowMessageAsync("Vuelva a intentar", "El campo contraseña y confirmar contraseña no coinciden.");
                }
                else
                {

                    if ((txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtNick.Text == string.Empty || txtPass.Password == string.Empty || txtConfirmar.Password == string.Empty))
                    {
                        string error = Convert.ToString(await this.ShowMessageAsync("Error", "Por favor llene todos los campos."));
                    }
                    if (!(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtNick.Text == string.Empty || txtPass.Password == string.Empty || txtConfirmar.Password == string.Empty))
                    {
                        Administrador _admin = new Administrador();
                        _admin.Nombre = txtNombre.Text;
                        _admin.Apellido = txtApellido.Text;
                         _admin.Nick = txtNick.Text;
                         _admin.Pass = (txtPass.Password);
                         _admin.Confirmar = (txtConfirmar.Password);
                        if (_adminBL.AgregarAdministrador(_admin) > 0)
                        {
                            await this.ShowMessageAsync("Éxito", "El registro se agregó.");
                            this.Close();
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtNick.Clear();
                            txtPass.Clear();
                            txtConfirmar.Clear();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal" + "Error 508: " + ex.Message);
            }
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            txtNombre.Focus();
        }
    }
}
