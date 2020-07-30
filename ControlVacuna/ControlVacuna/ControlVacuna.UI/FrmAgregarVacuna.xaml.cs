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

///Son los namespace de Mahapps para que funcione el estilo metro de los formularios
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

///Son los  namespace de las capas donde se encuentran métodos y la conección a la BDD
using ControlVacuna.AccesoDatos;
using ControlVacuna.LogicaDeNegocio;

namespace ControlVacuna.UI
{
    /// <summary>
    /// Interaction logic for FrmAgregarVacuna.xaml
    /// </summary>
    public partial class FrmAgregarVacuna : MetroWindow
    {
        ///Instancia de la capa BL
        VacunaBL _vacunaBL = new VacunaBL();
        ///Instancia de la entidad que se encuentra en el modelo de datos
        //Vacuna _vacunaEntity = new Vacuna();

        Paciente _paciente = new Paciente();

        public FrmAgregarVacuna()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (dpFecha.Text == string.Empty && txtCantidad.Text == string.Empty && txtDescripcion.Text == string.Empty && txtNombrePacient.Text == string.Empty)
            {
                this.Close();
            }
            else
            {
                if (!(dpFecha.Text == string.Empty && txtCantidad.Text == string.Empty && txtDescripcion.Text == string.Empty && txtNombrePacient.Text == string.Empty))
                {
                    if (MessageBox.Show("Está seguro que desea salir", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        ///Se le agrega "async" al botón para poder crear mensajes estilo windows 8 entre otras cosas"
        private async void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                ///Si los campos están vacios, tira un mensaje de error y no guarda
                if (dpFecha.Text == string.Empty || txtCantidad.Text == string.Empty || txtDescripcion.Text == string.Empty || txtNombrePacient.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Error", "Por favor llene todos los campos.");
                }
                ///Si los campos no están vacios
                if (!(dpFecha.Text == string.Empty || txtCantidad.Text == string.Empty || txtDescripcion.Text == string.Empty || txtNombrePacient.Text == string.Empty))
                {
                    ///Se crea la instancia de la clase para luego almacenar los capos digitados a la BDD
                    Vacuna _vacuna = new Vacuna();
                    //_vacuna.Paciente = new Paciente();
                    _vacuna.Fecha = Convert.ToDateTime(dpFecha.Text);
                    _vacuna.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                    _vacuna.Paciente.Nombre = txtNombrePacient.Text;
                    _vacuna.Descripcion = txtDescripcion.Text;

                    ///Si el método AgregarVacuna vacuna sea mayor que cero guardará
                    if (_vacunaBL.AgregarVacuna(_vacuna) > 0)
                    {
                        ///await funciona para lanzar mensajes estilo windows 8
                        await this.ShowMessageAsync("Éxito", "Los mensajes se guardaron.");
                        dpFecha.Text = "";
                        txtCantidad.Text = "";
                        txtNombrePacient.Text = "";
                        txtDescripcion.Text = "";
                        dpFecha.Focus();
                    }
                        ///De lo contrario no guarda
                    else
                    {
                        await this.ShowMessageAsync("Error", "No se pudieron guardar los datos.");
                    }
                }

            //}
                ///Captura como mensaje un error no correjido
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lo sentimos, algo ocurrió mal\n" + "Error 514" + ex.Message);
            //}
        }

        private void txtCantidad_PreviewKeyDown(object sender, KeyEventArgs e)
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
                && !txt.Text.Contains(".")))
                e.Handled = true;  
        }

        private void dpFecha_PreviewKeyDown(object sender, KeyEventArgs e)
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

        private void btnBuscarPacient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BuscarPaciente _bus = new BuscarPaciente();
                _bus.ShowDialog();

                if (_bus.PacienteEntity == null) return;

                _paciente = _bus.PacienteEntity;
                txtNombrePacient.Text = _paciente.Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            txtNombrePacient.IsEnabled = false;
        }

        
    }
}
