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
using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls.Dialogs;

///Son los  namespace de las capas donde se encuentran métodos y la conección a la BDD
using ControlVacuna.AccesoDatos;
using ControlVacuna.LogicaDeNegocio;

namespace ControlVacuna.UI
{
    /// <summary>
    /// Interaction logic for BuscarVacuna.xaml
    /// </summary>
    public partial class BuscarVacuna : MetroWindow
    {
        ///Instancia de la capa BL
        VacunaBL _vacunaBL = new VacunaBL();
        ///Se manda a llamar la clase con sus propiedades
        public Vacuna VacunaEntity { get; set; }

        public BuscarVacuna()
        {
            InitializeComponent();
        }
        private void FechaVacunaPicker_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Vacuna _va = new Vacuna();
                if(fechaVacunaPicker.SelectedDate.HasValue)
                _va.Fecha = fechaVacunaPicker.SelectedDate.Value;

                ///Aparecen los datos en el grid por el criterio de busqueda "Buscar por fecha"
                dgVacuna.ItemsSource = _vacunaBL.ObtenerVacunaPorFecha(_va);
            }
            ///Captura como mensaje un error no correjido
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgVacuna_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ///A la hora de dar doble click sobre un registro los datos se arrastran al formulario de mantenimiento y el formulario de busqueda se cierra automáticamente
                VacunaEntity = dgVacuna.SelectedItem as Vacuna;
                DialogResult = true;
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            ///El evento Loaded nos sirve para cargar y visualizar todos los datos registrados que están en la BDD
            dgVacuna.ItemsSource = _vacunaBL.ObtenerVacunas();
        }

        private void fechaVacunaPicker_PreviewKeyDown(object sender, KeyEventArgs e)
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
        
        }
    }
