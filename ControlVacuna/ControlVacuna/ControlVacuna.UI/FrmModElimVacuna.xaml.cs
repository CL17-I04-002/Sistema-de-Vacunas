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
    /// Interaction logic for FrmModElimVacuna.xaml
    /// </summary>
    public partial class FrmModElimVacuna : MetroWindow
    {
        ///Instancia de la capa BL
        VacunaBL _vacunaBL = new VacunaBL();
        ///Instancia de la entidad que se encuentra en el modelo de datos
        public Vacuna VacunaEntity { get; set; }

        Paciente _paciente = new Paciente();

        public FrmModElimVacuna()
        {
            InitializeComponent();
        }
        ///Este método lo creamos y nos sirve para desabilitar los textbox, también limpiarlos y solo habilitar el botón de buscar
        private void Actualizar()
        {
            txtId.IsEnabled = false;
            dpFecha.IsEnabled = false;
            txtNombrePacient.IsEnabled = false;
            txtCantidad.IsEnabled = false;
            txtDescripcion.IsEnabled = false;

            txtId.Text = string.Empty;
            dpFecha.Text = string.Empty;
            txtNombrePacient.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;

            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnBuscar.IsEnabled = true;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ///Se crea la instancia para para que aparezca el formulario de busqueda
                BuscarVacuna _buscarv = new BuscarVacuna();
                _buscarv.ShowDialog();

                ///Esto nos sirve si en el formulario de busqueda no sellecionamos ningun registro y le damos al botón de salir, nos ebita un mensaje de error en el catch:"Referencia a objeto no establecida como instancia de un objeto" eso da porque no seleccionamos ningún registro y la instancia es igual a null
                if (_buscarv.VacunaEntity == null) return;

                ///Se iguala la variable a nivel de clase con el objeto del formulario de busqueda
                VacunaEntity = _buscarv.VacunaEntity;
                ///se iguala el textbox a la variable a nivel clase con la entidad, en otras palabras se arrastran los datos del grid a los textbox
                txtId.Text = VacunaEntity.Id_Vacuna.ToString();
                dpFecha.Text = VacunaEntity.Fecha.ToString();
                txtNombrePacient.Text = VacunaEntity.Paciente.Nombre;
                txtCantidad.Text = VacunaEntity.Cantidad.ToString();
                txtDescripcion.Text = VacunaEntity.Descripcion;

                txtId.IsEnabled = false;
                dpFecha.IsEnabled = true;
                txtCantidad.IsEnabled = true;
                txtDescripcion.IsEnabled = true;

                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
            }
            ///Captura como mensaje un error no correjido
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal" + "Error 254: " + ex.Message);
            }
        }

        ///Se le agrega "async" al botón para poder crear mensajes estilo windows 8 entre otras cosas
        private async void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ///Si los campos están vacios, tira un mensaje de error y no modifica
                if (dpFecha.Text == string.Empty || txtCantidad.Text == string.Empty || txtDescripcion.Text == string.Empty || txtNombrePacient.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Advertencia", "Por favor llene todos los campos.");
                }
                    ///De lo contrario...
                else
                {
                    ///Si los campos no están vacios
                    if (!(dpFecha.Text == string.Empty || txtCantidad.Text == string.Empty || txtDescripcion.Text == string.Empty || txtNombrePacient.Text == string.Empty))
                    {
                        ///Se crea la instancia de la clase y luego la variable creada de la clase manda a llamar a las entidades igualandola con los textbox con sus respectivas conversiones
                        Vacuna _vacuna = new Vacuna();
                        _vacuna.Id_Vacuna = Convert.ToInt64(txtId.Text);
                        _vacuna.Fecha = Convert.ToDateTime(dpFecha.Text);
                        _vacuna.Paciente.Nombre = txtNombrePacient.Text;
                        _vacuna.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                        _vacuna.Descripcion = txtDescripcion.Text;

                        ///Si el método "ModificarVacuna" es mayor que cero se modifica
                        if (_vacunaBL.ModificarVacuna(_vacuna) > 0)
                        {
                            await this.ShowMessageAsync("Éxito", "El registro se modificó.");
                            Actualizar();
                        }
                            ///De lo contrario no modifica
                        else
                        {
                            await this.ShowMessageAsync("Error", "Por favor modifique al menos un campo.");
                        }
                    }
                }

            }
            ///Captura como mensaje un error no correjido
            catch (Exception ex)
            {
                MessageBox.Show("No seleccione los últimos datos de la lista(están vacios) o pueda que se guarden pero no es recomendable\n" + "error 802: " + ex.Message);
            }
        }
        ///Se le agrega "async" al botón para poder crear mensajes estilo windows 8 entre otras cosas
        private async void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (dpFecha.Text == string.Empty || txtCantidad.Text == string.Empty || txtDescripcion.Text == string.Empty)
                //{
                //    await this.ShowMessageAsync("Advertencia", "Por favor seleccione un registro.");
                //}

                ///Nos aparecerá un botón si deseamos eliminar, si damos click en no, no hará nada
                if (MessageBox.Show("Está seguro que desea eliminar", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { }
                    ///De lo contrario si en el botón le damos si...
                else
                {
                    ///La variable a nivel de clase con la entidad se iguala al textbox con su respectiva conversión
                    Vacuna va = new Vacuna();
                    VacunaEntity.Id_Vacuna = Convert.ToInt64(txtId.Text);
                    VacunaEntity.Fecha = Convert.ToDateTime(dpFecha.Text);
                    VacunaEntity.Paciente.Nombre = txtNombrePacient.Text;
                    VacunaEntity.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                    VacunaEntity.Descripcion = txtDescripcion.Text;

                    ///Si el método "EliminarVacuna" es mayor que cero elimina, esto quiere decir que si los registros son igual a cero no podra eliminar porque no hay nada almacenado
                    if (_vacunaBL.EliminarVacuna(VacunaEntity) > 0)
                    {
                        ///Mensaje estilo windows 8 
                        await this.ShowMessageAsync("Éxito", "El registro se eliminó.");
                        Actualizar();

                    }
                        ///De lo contrario no guarda
                    else 
                    {
                        await this.ShowMessageAsync("Error", "El registro no se eliminó.");
                    }
                }
            }
            ///Captura como mensaje un error no correjido
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo ocurrió mal, puede que se eliminen los datos pero no es recomendable" + "Error 707: " + ex.Message);
            }
        }
        ///En el evento loaded del formulario, mandamos a llamar el método que creamos "Actualizar". Ésto nos sirve para no entrar en enfasis
        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            Actualizar();
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
    }
}
