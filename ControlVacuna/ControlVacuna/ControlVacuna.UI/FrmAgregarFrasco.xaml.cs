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
    /// Interaction logic for FrmAgregarFrasco.xaml
    /// </summary>
    public partial class FrmAgregarFrasco : MetroWindow
    {
        FrascoBL _frascoBL = new FrascoBL();
        Frasco _frascoEntity = new Frasco();

        public FrmAgregarFrasco()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (dpFechaEntrega.Text == string.Empty && dpFechaFinalizacion.Text == string.Empty)
            {
                this.Close();
            }
            else
            {
                if (!(dpFechaEntrega.Text == string.Empty && dpFechaFinalizacion.Text == string.Empty))
                {
                    string mensaje = Convert.ToString(MessageBox.Show("¿Está seguro que desea salir?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question));

                    if (mensaje == "Yes")
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

                if (dpFechaEntrega.Text == string.Empty || dpFechaFinalizacion.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Error", "Por favor llene todos los campos.");
                }
                else
                {
                    if (Convert.ToDateTime(dpFechaEntrega.Text) >= Convert.ToDateTime(dpFechaFinalizacion.Text))
                    {
                        await this.ShowMessageAsync("Error", "No puede guardar una fecha mayor o igual en fecha de entrega que en la fecha de finalización.");
                    }
                    else
                    {
                        if (!(dpFechaEntrega.Text == string.Empty || dpFechaFinalizacion.Text == string.Empty))
                        {
                            Frasco _frasco = new Frasco();
                            _frasco.Fecha_Entrega = Convert.ToDateTime(dpFechaEntrega.Text);
                            _frasco.Fecha_Finalizacion = Convert.ToDateTime(dpFechaFinalizacion.Text);

                            if (_frascoBL.AgregarFrasco(_frasco) > 0)
                            {
                                await this.ShowMessageAsync("Éxito", "Los datos se guardaron.");
                                dpFechaEntrega.Text = "";
                                dpFechaFinalizacion.Text = "";
                                dpFechaEntrega.Focus();
                            }
                            else
                            {
                                await this.ShowMessageAsync("Error", "No se pudieron guardar los datos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal\n" + "Error 514: " + ex.Message);
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
                && !txt.Text.Contains("/")))
                e.Handled = true;     
        }

        private void dpFechaFinalizacion_PreviewKeyDown(object sender, KeyEventArgs e)
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
    }
}
