using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Empleado : Persona
    {
        public enum Cargos { Profesor, Director, Ayudante }

        private DateTime fechaDeAlta;
        private Cargos cargo;
        private decimal sueldo;


        public DateTime FechaDeAlta
        {
            get
            {
                return fechaDeAlta;
            }

            set
            {
                fechaDeAlta = value;
            }
        }

        internal Cargos Cargo
        {
            get
            {
                return cargo;
            }

            set
            {
                cargo = value;
            }
        }

        public decimal Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
        }

        //Calcular años de antiguedad del empleado
        public int Antiguedad()
        {
            int antiguedad;

            antiguedad = DateTime.Now.Day - FechaDeAlta.Day;

            return antiguedad;
        }

        //Constructor vacio
        public Empleado()
        {

        }
    }
}
