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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Aplicacion.Vistas;

namespace Aplicacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Institucion> Instituciones;
        public MainWindow()
        {
            InitializeComponent();

            Instituciones = new List<Institucion>();

            //Desahabilitar los botones
            btnCrear.IsEnabled = false;

            btnSeleccionar.IsEnabled = false;
        }

        //Crear un instituto y lo guarda en la lista
        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            var Instituto = new Institucion();

            Instituto.Nombre = txtNombreInstitucion.Text;

            Instituto.MatriculaMinisterio = txtMatriculaInstitucion.Text;

            Instituciones.Add(Instituto);

            lbxInstituciones.Items.Add(Instituto);
        }

        private void BtnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            ABMCursos frmCursos = new ABMCursos();

            frmCursos.ShowDialog();

            btnSeleccionar.IsEnabled = false;
        }

        private void NombreInstitucion_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Controla si los campos estan vacios y devuelve verdadero si estan escritos
            var habilitar = !string.IsNullOrEmpty(txtNombreInstitucion.Text) && !string.IsNullOrEmpty(txtMatriculaInstitucion.Text);

            //Se habilita o no el boton segun el valor que devuelva la variable habilitar
            btnCrear.IsEnabled = habilitar;
        }

        //Habilita el boton seleccionar
        private void LbxInstituciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Revisa si hay un item seleccionado y lo habilita segun el resultado
            if (lbxInstituciones.SelectedIndex != -1)
            {
                btnSeleccionar.IsEnabled = true;
            }
        }
    }
}
