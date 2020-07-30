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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        AdministradorBL _adminBL = new AdministradorBL();
        Administrador _adminEntity = new Administrador();
        public Administrador AdminEntity { get; set; }

        public Menu()
        {
            InitializeComponent();

            ///Esto quiere decir que si el usuario es correcto aparecerá el menú
             Login _log = new Login();
            _log.ShowDialog();
            if(_log.Aceptado) 
            {
                //MessageBox.Show("Bienvenido", txtNombre.Text);
            }
            else
            {
                Close();
            }
        }


        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            ///A la hora de dar click en el botón de registrar, se habilitará el Flyout
            FlyRegistrar.IsOpen = true;
        }

        private async void btnAgregarAdmin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ///Si las contraseñas no coinciden aparecerá un mensaje de error y no guardará
                if (!(txtPass.Password == txtConfirmar.Password))
                {
                    await this.ShowMessageAsync("Vuelva a intentar", "El campo contraseña y confirmar contraseña no coinciden");
                }
                    ///De lo contrario...
                else
                {
                    ///Ésto indica si a la hora que guardemos un usuario y el nick sea igual a uno que esté registrado a la base de datos, éste no nos permitirá guardar. Ésto nos ayuda para que no haya problema de autenticación cuando hayan 2 nicks iguales
                    if (_adminBL.NickExists(txtNick.Text))
                    {
                        await this.ShowMessageAsync("Vuelva a intentar", "Ese nick ya existe");
                        txtNick.Focus();
                    }
                        ///De lo contrario...
                    else
                    {
                        ///Si los campos están vacios no guardará
                        if ((txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtNick.Text == string.Empty || txtPass.Password == string.Empty || txtConfirmar.Password == string.Empty))
                        {
                            string error = Convert.ToString(await this.ShowMessageAsync("Error", "Por favor llene todos los campos"));
                        }
                        ///Si los campos están llenos
                        if (!(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtNick.Text == string.Empty || txtPass.Password == string.Empty || txtConfirmar.Password == string.Empty))
                        {
                            Administrador _admin = new Administrador();

                            ///Igualamos la entidad con el textbox
                            _admin.Nombre = txtNombre.Text;
                            _admin.Apellido = txtApellido.Text;
                            _admin.Nick = txtNick.Text;
                            _admin.Pass = (txtPass.Password);
                            _admin.Confirmar = (txtConfirmar.Password);

                            ///Si el método "AgregarAdministrador" es mayor a cero guardará
                            if (_adminBL.AgregarAdministrador(_admin) > 0)
                            {
                                await this.ShowMessageAsync("Éxito", "El registro se agrego");
                                ///Me limpia los textbox y me cierra automáticamente el flyout
                                txtNombre.Clear();
                                txtApellido.Clear();
                                txtNick.Clear();
                                txtPass.Clear();
                                txtConfirmar.Clear();
                                FlyRegistrar.IsOpen = false;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrio mal" + "Error 508" + ex.Message);
            }
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }
            else
            {
                this.Close();
            }
         
        }

        //private async void Tile_Click_2(object sender, RoutedEventArgs e)
        //{
        //    await this.ShowMessageAsync("" ,"Este formulario está diseñado para el control de vacunaspara el paciente Daniel");
        //}

        private void btnAgregarVacuna_Click(object sender, RoutedEventArgs e)
        {
            FrmAgregarVacuna _frmagg = new FrmAgregarVacuna();
            _frmagg.Show();
        }

        private async void btnAyuda_Click(object sender, RoutedEventArgs e)
        {
            await this.ShowMessageAsync("", "Este sistema está diseñado para el control y mantenimiento de vacunas para los pacientes de la clínica alergica.");
        }

        private void btnBuscarVacuna_Click(object sender, RoutedEventArgs e)
        {
            BuscarVacuna _buscarv = new BuscarVacuna();
            _buscarv.ShowDialog();
        }

        private void btnBuscarUsuario_Click(object sender, RoutedEventArgs e)
        {
            BuscarAdministrador _buscAdmin = new BuscarAdministrador();
            _buscAdmin.ShowDialog();
        }

        private void btnModificarAdministrador_Click(object sender, RoutedEventArgs e)
        {
            FrmModElimUsuario _frmMod = new FrmModElimUsuario();
            _frmMod.Show();
        }

        private void btnModificarVcuna_Click(object sender, RoutedEventArgs e)
        {
            FrmModElimVacuna _frmModV = new FrmModElimVacuna();
            _frmModV.ShowDialog();
        }

        private void btnAgregarFrasco_Click(object sender, RoutedEventArgs e)
        {
            FrmAgregarFrasco _frmAgregarFras = new FrmAgregarFrasco();
            _frmAgregarFras.Show();
        }


        private void btnBuscarFrasco_Click(object sender, RoutedEventArgs e)
        {
            BuscarFrasco _busFras = new BuscarFrasco();
            _busFras.ShowDialog();
        }

        private void btnEliModFrasco_Click(object sender, RoutedEventArgs e)
        {
            FrmModificarElimarFrasco _frmm = new FrmModificarElimarFrasco();
            _frmm.ShowDialog();
        }

        private void btnBuscarPaciente_Click(object sender, RoutedEventArgs e)
        {
            BuscarPaciente _busPacient = new BuscarPaciente();
            _busPacient.ShowDialog();
        }

        private void btnAgregarPaciente_Click(object sender, RoutedEventArgs e)
        {
            FrmAgregarPaciente _agPacient = new FrmAgregarPaciente();
            _agPacient.ShowDialog();
        }

        private void btnModificarPaciente_Click(object sender, RoutedEventArgs e)
        {
            FrmModElimPaciente _modElimPacient = new FrmModElimPaciente();
            _modElimPacient.ShowDialog();
        }
       
        }

    }
