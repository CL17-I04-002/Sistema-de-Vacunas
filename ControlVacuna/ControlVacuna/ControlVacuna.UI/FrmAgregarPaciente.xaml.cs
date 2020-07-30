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

using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;
using MahApps.Metro.Behaviours;

namespace ControlVacuna.UI
{
    /// <summary>
    /// Interaction logic for FrmAgregarPaciente.xaml
    /// </summary>
    public partial class FrmAgregarPaciente : MetroWindow
    {

        PacienteBL _pacienteBL = new PacienteBL();

        public FrmAgregarPaciente()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == string.Empty && txtApellido.Text == string.Empty && txtEdad.Text == string.Empty && txtDireccion.Text == string.Empty)
            {
                this.Close();
            }
            else
            {
                if (!(txtNombre.Text == string.Empty && txtApellido.Text == string.Empty && txtEdad.Text == string.Empty && txtDireccion.Text == string.Empty))
                {
                    if (MessageBox.Show("¿Está seguro que desea salir?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }
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
                if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtEdad.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Error", "Por favor llene los campos necesarios");
                }
                else
                {
                    if (!(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtEdad.Text == string.Empty))
                    {
                        Paciente _paciente = new Paciente();

                        _paciente.Nombre = txtNombre.Text;
                        _paciente.Apellido = txtApellido.Text;
                        _paciente.Edad = Convert.ToInt32(txtEdad.Text);
                        _paciente.Direccion = txtDireccion.Text;

                        if (_pacienteBL.AgregarPaciente(_paciente) > 0)
                        {
                            await this.ShowMessageAsync("Éxito", "El registro se agregó");
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtEdad.Clear();
                            txtDireccion.Clear();
                            txtNombre.Focus();
                        }
                        else
                        {
                            await this.ShowMessageAsync("Error", "El paciente no se pudo agregar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal" + "Error 508: " + ex.Message);
            }
        }

        private void txtEdad_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = new TextBox();

            if (e.Key == Key.Back || e.Key == Key.Delete)
                return;

            //Evaluamos el valor de la tecla presionada de acuerdo al
            //enumerador Key, donde los números están en el rango de
            // 34 a 43 en el teclado y de 74 a 83 en el teclado numérico
            if ((int)e.Key < 74)
            {
                if (((int)e.Key < 34 || (int)e.Key > 43))
                    e.Handled = true;
            }
            else if ((int)e.Key > 83
                //Evaluamos si se ha presionado la tecla de punto
                //para interpretarlo como punto decimal
                && !((e.Key == Key.OemPeriod || e.Key == Key.Decimal)
                //Evaluamos que el TextBox no contenga ya un
                //punto decimal en la propiedad Text.
                && !txt.Text.Contains("/")))
                e.Handled = true;     
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            txtNombre.Focus();
        }
    }
}
