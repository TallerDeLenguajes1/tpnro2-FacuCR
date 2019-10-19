using Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aplicacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para ABMAltaAlumno.xaml
    /// </summary>
    public partial class ABMAltaAlumno : Window
    {
        Alumno alumno;

        public ABMAltaAlumno()
        {
            InitializeComponent();

            btnGuardar.IsEnabled = false;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            CrearAlumno();

            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Limito al textbox dni para que solo se puedan ingresar numeros
        private void TxtDNI_Copy_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void TxtNombre_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            HabilitacionParaGuardar();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            HabilitacionParaGuardar();
        }

        public void HabilitacionParaGuardar()
        {
            //Controla si los campos estan vacios y devuelve verdadero si estan escritos
            var habilitar = !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtDNI.Text) && dtpFechaNac.SelectedDate != null;

            //Se habilita o no el boton segun el valor que devuelva la variable habilitar
            btnGuardar.IsEnabled = habilitar;
        }

        public Alumno CrearAlumno()
        {
            alumno = new Alumno();

            alumno.Nombre = txtNombre.Text;

            alumno.Apellido = txtApellido.Text;

            alumno.DNI = txtDNI.Text;

            var FechaDN = Convert.ToDateTime(dtpFechaNac.SelectedDate);

            alumno.FechaDeNacimiento = FechaDN;

            return alumno;
        }
    }
}
