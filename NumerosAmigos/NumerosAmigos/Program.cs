using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAmigos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Metodo numeros = new Metodo();
            Console.Write("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            string[] arrayPrimos = numeros.numerosPrimos().Split(',');
            for (int j = 0; j < arrayPrimos.Length; j++)
                {
                    Console.Write(arrayPrimos[j] + "  ");
                }

            /*if (numeros.Comparacion(num1, num2))
            {
                Console.WriteLine("LOS NUMEROS SON AMIGOS");
            }*/
            Console.ReadLine();
        }
    }
}
