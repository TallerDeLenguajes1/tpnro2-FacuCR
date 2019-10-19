using Objetos;
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
using static Objetos.Curso;

namespace Aplicacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para ABMCrearCurso.xaml
    /// </summary>
    public partial class ABMCrearCurso : Window
    {
        Curso Curs;

        public ABMCrearCurso()
        {
            InitializeComponent();

            btnCrear.IsEnabled = false;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            CrearCurso();

            this.Close();
        }

        public Curso CrearCurso()
        {
            switch (cbxModalidad.Text)
            {
                case "Presencial":
                    Curs = new Presencial();
                    break;

                case "Semi Presencial":
                    Curs = new SemiPresencial();
                    break;

                case "No Presencial":
                    Curs = new NoPresencial();
                    break;

                default:
                    break;
            }

            Curs.Tema = txtTema.Text;

            //Convierto el texto seleccionado en el combobox a tipo Turnos
            var turno = (Turnos)Enum.Parse(typeof(Turnos), cbxTurno.Text);

            Curs.Turno = turno;

            Curs.Inscripcion = Convert.ToDecimal(sldInscripcion.Value);

            Curs.Cuota = Convert.ToDecimal(sldCuota.Value);

            return Curs;
        }

        private void TxtTema_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Controla si los campos estan vacios y devuelve verdadero si estan escritos
            var habilitar = !string.IsNullOrEmpty(txtTema.Text) && cbxTurno.SelectedIndex != -1 && cbxModalidad.SelectedIndex != -1;

            //Se habilita o no el boton segun el valor que devuelva la variable habilitar
            btnCrear.IsEnabled = habilitar;
        }

        private void CbxTurno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Controla si los campos estan vacios y devuelve verdadero si estan escritos
            var habilitar = !string.IsNullOrEmpty(txtTema.Text) && cbxTurno.SelectedIndex != -1 && cbxModalidad.SelectedIndex != -1;

            //Se habilita o no el boton segun el valor que devuelva la variable habilitar
            btnCrear.IsEnabled = habilitar;
        }
    }
}
