using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Alumno : Persona
    {
        //Constructor vacio
        public Alumno() : base ()
        {

        }

        public override string ToString()
        {
            return Apellido + ",  " + Nombre + " - Edad: " + Edad() + " - DNI: " + DNI;
        }

    }
}
