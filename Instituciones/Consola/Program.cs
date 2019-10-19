using Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nom, Apel, Documento;
            DateTime FDeNac;
            var ADePrueba = new Alumno();

            Console.WriteLine("Ingrese Nombre");

            Nom = Console.ReadLine();

            Console.WriteLine("Ingrese Apellido");

            Apel = Console.ReadLine();

            Console.WriteLine("Ingrese Documento");

            Documento = Console.ReadLine();

            Console.WriteLine("Ingrese Fecha de Nacimiento");
 
            Console.Write("Ingresar dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Ingresar mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("ingresar año: ");
            int anio = int.Parse(Console.ReadLine());

            FDeNac = new DateTime(anio, mes, dia);

            ADePrueba.Nombre = Nom;

            ADePrueba.Apellido = Apel;

            ADePrueba.FechaDeNacimiento = FDeNac;

            ADePrueba.DNI = Documento;

            Console.ReadKey();

        }
    }
}
