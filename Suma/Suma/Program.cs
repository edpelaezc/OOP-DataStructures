using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;

            Console.WriteLine("Ingrese el primer numero: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > 0 || b > 0) //los dos son positivos
            {
                a *= -1;
                resultado = a - b;
                resultado *= -1;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (a < 0 && b < 0) // los dos son negativos
            {
                a *= -1;
                resultado = b - a;                
                Console.WriteLine("Resultado: " + resultado);
            }


            Console.ReadKey();
        }
    }
}
