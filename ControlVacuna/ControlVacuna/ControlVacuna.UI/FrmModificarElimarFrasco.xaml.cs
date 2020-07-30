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
    /// Interaction logic for FrmModificarElimarFrasco.xaml
    /// </summary>
    public partial class FrmModificarElimarFrasco : MetroWindow
    {
        FrascoBL _frascoBL = new FrascoBL();
        public Frasco FrascoEntity { get; set; }

        public FrmModificarElimarFrasco()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            txtId.IsEnabled = false;
            dpFechaEntrega.IsEnabled = false;
            dpFechaFinalizacion.IsEnabled = false;

            txtId.Text = string.Empty;
            dpFechaEntrega.Text = string.Empty;
            dpFechaFinalizacion.Text = string.Empty;

            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnBuscar.IsEnabled = true;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BuscarFrasco _busFra = new BuscarFrasco();
                _busFra.ShowDialog();

                if (_busFra.FrascoEntity == null) return;

                FrascoEntity = _busFra.FrascoEntity;
                txtId.Text = FrascoEntity.Id_Frasco.ToString();
                dpFechaEntrega.Text = FrascoEntity.Fecha_Entrega.ToString();
                dpFechaFinalizacion.Text = FrascoEntity.Fecha_Finalizacion.ToString();

                txtId.IsEnabled = false;
                dpFechaEntrega.IsEnabled = true;
                dpFechaFinalizacion.IsEnabled = true;

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
                if (dpFechaEntrega.Text == string.Empty || dpFechaFinalizacion.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Advertencia", "Por favor llene todos los campos.");
                }
                else
                {
                    if (Convert.ToDateTime(dpFechaEntrega.Text) >= Convert.ToDateTime(dpFechaFinalizacion.Text))
                    {
                        await this.ShowMessageAsync("Error", "No puede modificar una fecha mayor o igual en fecha de entrega que en la fecha de finalización");
                    }
                    else
                    {
                        if (!(dpFechaEntrega.Text == string.Empty || dpFechaFinalizacion.Text == string.Empty))
                        {
                            Frasco _fra = new Frasco();
                            _fra.Id_Frasco = Convert.ToInt64(txtId.Text);
                            _fra.Fecha_Entrega = Convert.ToDateTime(dpFechaEntrega.Text);
                            _fra.Fecha_Finalizacion = Convert.ToDateTime(dpFechaFinalizacion.Text);

                            if (_frascoBL.ModificarFrasco(_fra) > 0)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("No seleccione los últimos datos de la lista(están vacios) o pueda que se guarden pero no es recomendable\n" + "Error 808: " + ex.Message);
            }
        }

        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dpFechaEntrega.Text == string.Empty || dpFechaFinalizacion.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Advertencia", "No borre los campos a eliminar.");
                }
                else
                {

                    if (MessageBox.Show("Está seguro que desea eliminar", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }
                    else
                    {
                        FrascoEntity.Id_Frasco = Convert.ToInt64(txtId.Text);
                        FrascoEntity.Fecha_Entrega = Convert.ToDateTime(dpFechaEntrega.Text);
                        FrascoEntity.Fecha_Finalizacion = Convert.ToDateTime(dpFechaFinalizacion.Text);

                        if (_frascoBL.EliminarFrasco(FrascoEntity) > 0)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal, puede que se eliminen los datos pero no es recomendable" + "Error 707: " + ex.Message);
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

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            Actualizar();
        }
    }
}
