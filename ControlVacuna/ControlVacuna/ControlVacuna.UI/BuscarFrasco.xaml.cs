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

using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

using ControlVacuna.AccesoDatos;
using ControlVacuna.LogicaDeNegocio;

namespace ControlVacuna.UI
{
    /// <summary>
    /// Interaction logic for BuscarFrasco.xaml
    /// </summary>
    public partial class BuscarFrasco : MetroWindow
    {
        FrascoBL _frascoBL = new FrascoBL();
        FrmModificarElimarFrasco _frm = new FrmModificarElimarFrasco();
        public Frasco FrascoEntity { get; set; }

        public BuscarFrasco()
        {
            InitializeComponent();
        }

        private void dgFrasco_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                FrascoEntity = dgFrasco.SelectedItem as Frasco;
                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            dgFrasco.ItemsSource = _frascoBL.ObtenerFrasco();
        }

        private void DatePicker_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Frasco _fra = new Frasco();
                if(dpFechaEntrega.SelectedDate.HasValue)
                _fra.Fecha_Entrega = dpFechaEntrega.SelectedDate.Value;

                dgFrasco.ItemsSource = _frascoBL.ObtenerFrascoPorFechaEntrega(_fra);

                //if (dpFechaEntrega == null)
                //{
                //    dgFrasco.ItemsSource = _frascoBL.ObtenerFrasco();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dpFechaEntrega_PreviewKeyDown(object sender, KeyEventArgs e)
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
