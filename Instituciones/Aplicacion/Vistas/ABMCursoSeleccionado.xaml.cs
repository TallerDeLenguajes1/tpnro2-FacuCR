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

namespace Aplicacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para ABMCursoSeleccionado.xaml
    /// </summary>
    public partial class ABMCursoSeleccionado : Window
    {
        int Seleccion;
        Curso Curs;
        ABMCursos abmCursos;

        public ABMCursoSeleccionado()
        {
            InitializeComponent();

            //Guardo el valor de la seleccion de la listbox accediendo a la ventana ABMCursos
            abmCursos = Application.Current.Windows.OfType<ABMCursos>().FirstOrDefault();

            Seleccion = abmCursos.lbxCursos.SelectedIndex;

            //Utilizo la seleccion de la listbox y eligo el instituto de la lista
            Curs = abmCursos.Instituto.Cursos[Seleccion];

            //Le coloco el nombre del Curso al titulo
            tblCursoSeleccionado.Text = Curs.Tema;

            btnSeleccionar.IsEnabled = false;

            btnEliminar.IsEnabled = false;

            if (Curs.Alumnos == null)
            {
                Curs.Alumnos = new List<Alumno>();
            }
            else
            {
                foreach (var alumno in Curs.Alumnos)
                {
                    lbxAlumnos.Items.Add(alumno);
                }
            }
        }

        private void LbxCursos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Revisa si hay un item seleccionado y lo habilita segun el resultado
            if (lbxAlumnos.SelectedIndex != -1)
            {
                btnSeleccionar.IsEnabled = true;
            }
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            ABMAltaAlumno frmAltaAlumno = new ABMAltaAlumno();

            frmAltaAlumno.ShowDialog();

            if (frmAltaAlumno.CrearAlumno() != null)
            {
                Curs.Alumnos.Add(frmAltaAlumno.CrearAlumno());

                lbxAlumnos.Items.Add(frmAltaAlumno.CrearAlumno());
            }
        }

        private void BtnSeleccionar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            GuardarCambiosDelCurso();

            this.Close();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        public void GuardarCambiosDelCurso()
        {
            abmCursos.Instituto.Cursos[Seleccion] = Curs;
        }

        private void BtnGuardar_Copy_Click(object sender, RoutedEventArgs e)
        {
            Curs.GuardarDatosEnArchivo();
        }
    }
}
