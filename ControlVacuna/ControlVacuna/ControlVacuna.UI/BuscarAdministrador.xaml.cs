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
    /// Interaction logic for BuscarAdministrador.xaml
    /// </summary>
    public partial class BuscarAdministrador : MetroWindow
    {
        AdministradorBL _adminBL = new AdministradorBL();
        public Administrador AdminEntity { get; set; }

        public BuscarAdministrador()
        {
            InitializeComponent();
        }

        private void txtNombreAdmin_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Administrador _administrador = new Administrador();
                _administrador.Nombre = txtNombreAdmin.Text;

                dgAdmin.ItemsSource = _adminBL.ObtenerAdministradorPorNombre(_administrador);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MetroWindow_Loaded_2(object sender, RoutedEventArgs e)
        {
            dgAdmin.ItemsSource = _adminBL.ObtenerAdministradores();
        }

        private void dgAdmin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                AdminEntity = dgAdmin.SelectedItem as Administrador;
                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
