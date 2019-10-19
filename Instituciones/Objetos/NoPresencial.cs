using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class NoPresencial : Curso
    {
        //Constructor vacio
        public NoPresencial()
        {

        }

        public override void GuardarDatosEnArchivo()
        {
            StreamWriter writer = new StreamWriter(File.Open(Tema + ".csv", FileMode.Create));

            writer.Write("Tema: " + Tema + "\nTurno: " + Turno + "\nModalidad: No Presencial" + "\nInscripcion: " + Inscripcion + "\nCuota: " + ValorCuota() + "\n");

            writer.Write("\nAlumnos:\nNombre;Apellido;Edad;DNI\n");

            foreach (Alumno A in Alumnos)
            {
                writer.Write(A.Nombre + ";" + A.Apellido + ";" + A.Edad() + A.DNI + "\n");
            }

            writer.Close();
        }

        public override decimal ValorCuota()
        {
            decimal descuento = Cuota * (decimal)5.0;

            return base.ValorCuota() - descuento;
        }

        public override string ToString()
        {
            return Tema + " - " + Turno + " - Modalidad: No Presencial - Inscripcion: $" + Inscripcion + " - Cuota: $" + ValorCuota();
        }
    }
}
