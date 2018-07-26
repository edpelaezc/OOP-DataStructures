using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Metodos
    {
        public void escribirTablas()
        {
            for (int j = 1; j < 11; j++)
            {
                Console.Write("\t" + j);                
            }

            Console.WriteLine();

            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j < 11; j++)
                {                                    
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
