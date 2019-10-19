using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Institucion
    {
        private string nombre;
        private string matriculaMinisterio;
        private List<Curso> cursos;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string MatriculaMinisterio
        {
            get
            {
                return matriculaMinisterio;
            }

            set
            {
                matriculaMinisterio = value;
            }
        }

        public List<Curso> Cursos
        {
            get
            {
                return cursos;
            }

            set
            {
                cursos = value;
            }
        }

        public Institucion()
        {

        }

        //Agregar curso a la lista
        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public override string ToString()
        {
            return Nombre + " - " + MatriculaMinisterio;
        }
    }
}
