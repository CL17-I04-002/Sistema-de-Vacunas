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
using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls.Dialogs;

using ControlVacuna.AccesoDatos;
using ControlVacuna.LogicaDeNegocio;

namespace ControlVacuna.UI
{
    /// <summary>
    /// Interaction logic for FrmModElimUsuario.xaml
    /// </summary>
    public partial class FrmModElimUsuario : MetroWindow
    {
        AdministradorBL _adminBL = new AdministradorBL();
        public Administrador AdministradorEntity { get; set; }
        
        

        public FrmModElimUsuario()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            txtId.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtApellido.IsEnabled = false;
            txtNick.IsEnabled = false;
            txtPass.IsEnabled = false;
            txtConfirmar.IsEnabled = false;

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNick.Text = string.Empty;
            txtPass.Password = string.Empty;
            txtConfirmar.Password = string.Empty;

            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnBuscar.IsEnabled = true;
        }
        //private void Update()
        //{

        //    btnModificar.IsEnabled = true;
        //    btnEliminar.IsEnabled = true;

        //    txtId.IsEnabled = false;
        //    txtNombre.IsEnabled = true;
        //    txtApellido.IsEnabled = true;
        //    txtNick.IsEnabled = true;
        //    txtContra.IsEnabled = true;
        //    txtConfirmar.IsEnabled = true;
        //    txtNombre.Focus();
        //}
        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNick.Clear();
            txtPass.Clear();
            txtConfirmar.Clear();
        }
        private async void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtNick.Text == string.Empty || txtPass.Password == string.Empty)
                {
                    await this.ShowMessageAsync("Advertencia", "Por favor llene todos los campos.");
                }
                    
                else
               

                    if (!(txtPass.Password == txtConfirmar.Password))
                    {
                        await this.ShowMessageAsync("Vuelva a intentar", "No coinciden los campos contraseña y confirmar contraseña.");
                    }
                    else
                    {
                        if (!(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtNick.Text == string.Empty || txtPass.Password == string.Empty))
                        {
                            Administrador _administrador = new Administrador();
                            _administrador.Id_Administrador = Convert.ToInt64(txtId.Text);
                            _administrador.Nombre = txtNombre.Text;
                            _administrador.Apellido = txtApellido.Text;
                            _administrador.Nick = txtNick.Text;
                            _administrador.Pass = txtPass.Password;
                            _administrador.Confirmar = txtConfirmar.Password;

                            if (_adminBL.ModificarAdministrador(_administrador) > 0)
                            {
                                await this.ShowMessageAsync("Éxito", "El registro se modificó.");
                                Actualizar();
                                Limpiar();
                            }
                            else
                            {
                                await this.ShowMessageAsync("Error", "Por favor modifique al menos un campo.");
                            }
                        }
                    }

                }
            
            catch (Exception ex)
            {
                MessageBox.Show("No seleccione los últimos datos de la lista(están vacios) o pueda que se guarden pero no es recomendable\n" + "Error 802: " + ex.Message);
            }
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtNick.Text == string.Empty || txtPass.Password == string.Empty)
                //{
                //    await this.ShowMessageAsync("Advertencia", "Por favor seleccione un registro.");
                //}

                if (MessageBox.Show("Está seguro que desea eliminar", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }
                else
                {
                    AdministradorEntity.Id_Administrador = Convert.ToInt64(txtId.Text);
                    AdministradorEntity.Nombre = txtNombre.Text;
                    AdministradorEntity.Apellido = txtApellido.Text;
                    AdministradorEntity.Nick = txtNick.Text;
                    AdministradorEntity.Pass = txtPass.Password;
                    AdministradorEntity.Confirmar = txtConfirmar.Password;
                    if (_adminBL.EliminarAdministrador(AdministradorEntity) > 0)
                    {

                        await this.ShowMessageAsync("Éxito", "El registro se eliminó.");
                        Actualizar();
                        Limpiar();

                    }
                    else 
                    {
                        await this.ShowMessageAsync("Error", "El registro no se eliminó.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal, puede que se eliminen los datos pero no es recomendable" + "Error 107: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BuscarAdministrador _buscarv = new BuscarAdministrador();
                _buscarv.ShowDialog();

                if (_buscarv.AdminEntity == null) return;

                AdministradorEntity = _buscarv.AdminEntity;
                txtId.Text = AdministradorEntity.Id_Administrador.ToString();
                txtNombre.Text = AdministradorEntity.Nombre;
                txtApellido.Text = AdministradorEntity.Apellido;
                txtNick.Text = AdministradorEntity.Nick;
                txtPass.Password = AdministradorEntity.Pass;
                txtConfirmar.Password = AdministradorEntity.Confirmar;

                txtId.IsEnabled = false;
                txtNombre.IsEnabled = true;
                txtApellido.IsEnabled = true;
                txtNick.IsEnabled = true;
                txtPass.IsEnabled = true;
                txtConfirmar.IsEnabled = true;

                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal" + "Error 254: " + ex.Message);
            }
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            Actualizar();
        }
        }
        }
