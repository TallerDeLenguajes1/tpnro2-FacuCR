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
    /// Lógica de interacción para ABMCursos.xaml
    /// </summary>
    public partial class ABMCursos : Window
    {
        public Institucion Instituto;
        int Seleccion;
        public ABMCursos()
        {
            InitializeComponent();

            //Guardo el valor de la seleccion de la listbox
            Seleccion = ((MainWindow)Application.Current.MainWindow).lbxInstituciones.SelectedIndex;

            //Utilizo la seleccion de la listbox y eligo el instituto de la lista
            Instituto = ((MainWindow)Application.Current.MainWindow).Instituciones[Seleccion];

            //Le coloco el nombre del instituto al titulo
            tblCursos.Text = Instituto.Nombre;

            btnSeleccionar.IsEnabled = false;

            if (Instituto.Cursos == null)
            {
                Instituto.Cursos = new List<Curso>();
            }
            else
            {
                foreach (var curso in Instituto.Cursos)
                {
                    lbxCursos.Items.Add(curso);
                }
            }
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            ABMCrearCurso frmCrearCurso = new ABMCrearCurso();

            frmCrearCurso.ShowDialog();

            if (frmCrearCurso.CrearCurso() != null)
            {
                Instituto.AgregarCurso(frmCrearCurso.CrearCurso());

                lbxCursos.Items.Add(frmCrearCurso.CrearCurso());
            }
        }

        private void BtnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            ABMCursoSeleccionado frmCursoSeleccionado = new ABMCursoSeleccionado();

            frmCursoSeleccionado.ShowDialog();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LbxCursos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Revisa si hay un item seleccionado y lo habilita segun el resultado
            if (lbxCursos.SelectedIndex != -1)
            {
                btnSeleccionar.IsEnabled = true;
            }
        }
    }
}
