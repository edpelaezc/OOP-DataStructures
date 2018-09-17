using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial1PA
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosRecursivos recursividad = new MetodosRecursivos();
            //int n, a, b;
            /*Console.Write("Ingrese un numero [n]: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de 1 hasta " + n.ToString() + " es: " + recursividad.sumaElementos(n));*/
            /*Console.Write("Ingrese un entero [a]: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un entero [b]: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("El MCD de [a] y [b] es: " + recursividad.maximoComunDivisor(a, b));*/
            //Console.WriteLine(recursividad.duplicacionRuso(27, 45));
            Console.WriteLine(recursividad.cambioBase("356", 16, 3));
            //Console.WriteLine(recursividad.esPalindromo("ala"));
            Console.ReadLine();
        }
    }
}
