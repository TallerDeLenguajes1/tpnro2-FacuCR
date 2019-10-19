using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Presencial : Curso
    {
        //Constructor vacio
        public Presencial()
        {

        }

        public override void GuardarDatosEnArchivo()
        {
            StreamWriter writer = new StreamWriter(File.Open(Tema + ".csv", FileMode.Create));

            writer.Write("Tema: " + Tema + "\nTurno: " + Turno + "\nModalidad: Presencial" + "\nInscripcion: " + Inscripcion + "\nCuota: " + ValorCuota() + "\n");

            writer.Write("\nAlumnos:\nNombre;Apellido;Edad;DNI\n");

            foreach (Alumno A in Alumnos)
            {
                writer.Write(A.Nombre + ";" + A.Apellido + ";" + A.Edad() + A.DNI + "\n");
            }

            writer.Close();
        }

        public override decimal ValorCuota()
        {
            decimal Iva = Cuota * (decimal)0.21;

            decimal total = Cuota + Iva;

            return total;
        }

        public override string ToString()
        {
            return Tema + " - " + Turno + " - Modalidad: Presencial - Inscripcion: $" + Inscripcion + " - Cuota: $" + ValorCuota();
        }

    }
}
