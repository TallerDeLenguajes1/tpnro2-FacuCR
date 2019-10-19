using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private string dNI;

        //Calcular Edad de la persona
        public int Edad()
        {
            int edad;

            edad = DateTime.Today.AddTicks(-FechaDeNacimiento.Ticks).Year - 1;

            return edad;
        }

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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;
            }

            set
            {
                fechaDeNacimiento = value;
            }
        }

        public string DNI
        {
            get
            {
                return dNI;
            }

            set
            {
                dNI = value;
            }
        }

        //Constructor Vacio
        public Persona()
        {

        }
    }
}
