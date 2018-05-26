using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Program
    {
        public static bool parsed(string _string)
        {
            int numValue;
            return int.TryParse(_string, out numValue);
        }

        public static int pagoEmpleado(int horas)
        {            
            int dias = 0;
            int extras = 0;
            dias = horas / 8;
            extras = horas - (dias * 8);            
            return (dias * 50) + (extras * 5);
        }

        static void Main(string[] args)
        {
            //problema no.4   
            string horas = "";
            string nombre = "";
            Console.Write("Ingrese su nombre: ");
            nombre += Console.ReadLine();
            Console.Write("Horas de trabajo en el mes: ");
            horas = Console.ReadLine();
            if (parsed(horas))
            {
                Console.Write("\nNombre: " + nombre);
                Console.Write("\nSu pago es de: Q" + pagoEmpleado(int.Parse(horas)));
            }
            else
            {
                Console.Write("TIENE QUE INGRESAR UN NUMERO EN LAS HORAS.");
                Console.Write("\nPresione cualquier tecla para volver.");
                Console.ReadLine();
                Console.Clear();             
                Console.Write("Horas de trabajo en el mes: ");
                string nHoras = Console.ReadLine();
                Console.Write("\nNombre: " + nombre);
                Console.Write("\nSu pago es de: Q" + pagoEmpleado(int.Parse(nHoras)));
            }
            Console.ReadLine();
        }
    }
}
