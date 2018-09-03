using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosRecursivos recursion = new MetodosRecursivos();
            Console.WriteLine("Ingrese un numero: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial de " + n + ": " + recursion.Factorial(n));
            Console.ReadLine();
        }
    }
}
