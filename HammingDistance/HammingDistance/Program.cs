using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero binario: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero binario: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("La distancia de Hamming entre los btis es de: " + HammingDistance(first, second));
            Console.ReadKey();
        }

        static int HammingDistance(int x, int y)
        {
            string first = Convert.ToString(x, 2);
            string second = Convert.ToString(y, 2);
            int count = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i]) { count++; }
            }
            return count;
        }

        static string bin(int x)
        {
            string response = "";

            return response;
        }
    }
}
