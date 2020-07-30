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

using ControlVacuna.AccesoDatos;
using ControlVacuna.LogicaDeNegocio;

using MahApps.Metro.Controls;
using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls.Dialogs;

namespace ControlVacuna.UI
{
    /// <summary>
    /// Interaction logic for FrmModElimPaciente.xaml
    /// </summary>
    public partial class FrmModElimPaciente : MetroWindow
    {
        PacienteBL _pacienteBL = new PacienteBL();
        public Paciente PacienteEntity { get; set; }

        public FrmModElimPaciente()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            txtId.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtApellido.IsEnabled = false;
            txtEdad.IsEnabled = false;
            txtDireccion.IsEnabled = false;

            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            

            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnBuscar.IsEnabled = true;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BuscarPaciente _busPacient = new BuscarPaciente();
                _busPacient.ShowDialog();

                if (_busPacient.PacienteEntity == null) return;

                PacienteEntity = _busPacient.PacienteEntity;
                txtId.Text = PacienteEntity.Id_Paciente.ToString();
                txtNombre.Text = PacienteEntity.Nombre;
                txtApellido.Text = PacienteEntity.Apellido;
                txtEdad.Text = PacienteEntity.Edad.ToString();
                txtDireccion.Text = PacienteEntity.Direccion;

                txtId.IsEnabled = false;
                txtNombre.IsEnabled = true;
                txtApellido.IsEnabled = true;
                txtEdad.IsEnabled = true;
                txtDireccion.IsEnabled = true;

                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal" + "Error 254: " + ex.Message);
            }
        }

        private async void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtEdad.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Advertencia", "Por favor llene todos los campos.");
                }
                else
                {
                    if (!(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtEdad.Text == string.Empty))
                    {
                        Paciente _pacient = new Paciente();
                        _pacient.Id_Paciente = Convert.ToInt64(txtId.Text);
                        _pacient.Nombre = txtNombre.Text;
                        _pacient.Apellido = txtApellido.Text;
                        _pacient.Edad = Convert.ToInt32(txtEdad.Text);
                        _pacient.Direccion = txtDireccion.Text;

                        if (_pacienteBL.ModificarPaciente(_pacient) > 0)
                        {
                            await this.ShowMessageAsync("Éxito", "El registro se modificó.");
                            Actualizar();
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
                if (MessageBox.Show("Está seguro que desea eliminar", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }

                else
                {
                    PacienteEntity.Id_Paciente = Convert.ToInt64(txtId.Text);
                    PacienteEntity.Nombre = txtNombre.Text;
                    PacienteEntity.Apellido = txtApellido.Text;
                    PacienteEntity.Edad = Convert.ToInt32(txtEdad.Text);
                    PacienteEntity.Direccion = txtDireccion.Text;

                    if (_pacienteBL.EliminarPaciente(PacienteEntity) > 0)
                    {
                        await this.ShowMessageAsync("Éxito", "El registro se eliminó.");
                        Actualizar();
                    }
                    else
                    {
                        await this.ShowMessageAsync("Error", "El registro no se eliminó.");
                    }
                }
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
