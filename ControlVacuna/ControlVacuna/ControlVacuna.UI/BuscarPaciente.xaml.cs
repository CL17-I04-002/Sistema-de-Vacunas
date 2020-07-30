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
    /// Interaction logic for BuscarPaciente.xaml
    /// </summary>
    public partial class BuscarPaciente : MetroWindow
    {
        PacienteBL _pacienteBL = new PacienteBL();
        public Paciente PacienteEntity { get; set; }
        public BuscarPaciente()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            dgPaciente.ItemsSource = _pacienteBL.ObtenerPacientes();
        }

        private void txtNombrePaciente_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Paciente _paciente = new Paciente();
                _paciente.Nombre = txtNombrePaciente.Text;

                dgPaciente.ItemsSource = _pacienteBL.ObtenerPacientesPorNombre(_paciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPaciente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                PacienteEntity = dgPaciente.SelectedItem as Paciente;

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
