using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Tarea
    {
        //validación para covertir cadena a enteros. 
        public static bool parsed(string _string)
        {
            int numValue;
            return int.TryParse(_string, out numValue);
        }

        static void Main(string[] args)
        {
            string name = "";
            string carrera = "";
            string carnet = "";
            Console.WriteLine("Mi segundo programa");
            Console.Write("\nIngrese su nombre: ");
            name = Console.ReadLine();
            Console.Write("Ingrese su numero de carnet: ");
            carnet = Console.ReadLine();                    
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine("\nSoy " + name + ", con numero de carnet: " + carnet + ", estudio: " + carrera);
            Console.ReadLine();
        }
    }
}
