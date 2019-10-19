using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Curso
    {
        public enum Turnos { Mañana, Tarde, Noche }

        private Turnos turno;
        private List<Alumno> alumnos;
        private string tema;
        private decimal cuota;
        private decimal inscripcion;

        public Turnos Turno
        {
            get
            {
                return turno;
            }

            set
            {
                turno = value;
            }
        }

        public string Tema
        {
            get
            {
                return tema;
            }

            set
            {
                tema = value;
            }
        }

        public decimal Cuota
        {
            get
            {
                return cuota;
            }

            set
            {
                cuota = value;
            }
        }

        public decimal Inscripcion
        {
            get
            {
                return inscripcion;
            }

            set
            {
                inscripcion = value;
            }
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }

            set
            {
                alumnos = value;
            }
        }

        //Cargar alumno en la lista del curso
        public void CargarAlumnos(Alumno Alu)
        {
            Alumnos.Add(Alu);
        }

        public virtual void GuardarDatosEnArchivo()
        {
            StreamWriter writer = new StreamWriter(File.Open(Tema + ".csv", FileMode.Create));

            writer.Write("Tema: " + Tema + "\nTurno: " + Turno + "\nInscripcion: " + Inscripcion + "\nCuota: " + Cuota + "\n");

            writer.Write("\nAlumnos:\nNombre;Apellido;Edad;DNI\n");

            foreach (Alumno A in Alumnos)
            {
                writer.Write(A.Nombre + ";" + A.Apellido + ";" + A.Edad() + A.DNI + "\n");
            }

            writer.Close();
        }

        //Devuelve el valor de la cuota del curso
        public virtual decimal ValorCuota()
        {
            return Cuota;
        }

        //Constructor vacio
        public Curso()
        {

        }

        public override string ToString()
        {
            return Tema + " - " + Turno + " - Inscripcion: $" + inscripcion + " - Cuota: $" + Cuota;
        }
    }
}
