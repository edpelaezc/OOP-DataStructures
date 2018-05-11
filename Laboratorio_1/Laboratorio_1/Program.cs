using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");            
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hola " + name + ", este es su primer programa!");
            Console.ReadLine();
        }
    }
}
