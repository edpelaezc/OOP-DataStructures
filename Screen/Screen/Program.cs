using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EstrcuturasDinamicas;

namespace Screen
{
    class Program
    {
        static StreamReader reader = new StreamReader(@"C:\Users\edanP\Documents\ARQUITECTURA DEL COMPUTADOR\nand2tetris\nand2tetris\tools\builtInChips\archivo.txt");//lector de archivo
        static StreamWriter file = new StreamWriter(@"C:\Users\edanP\Documents\ARQUITECTURA DEL COMPUTADOR\nand2tetris\nand2tetris\tools\builtInChips\Screen.tst");//generador de script .tst
        static LinkedQueue<string> lines = new LinkedQueue<string>();//almacenará las líneas del archivo donde esten las letras

        static void Main(string[] args)
        {
            string line = "";
            line = reader.ReadLine();

            while (line != null)//obetine cada linea del archivo
            {
                lines.enqueue(line);
                line = reader.ReadLine();
            }
            reader.Close();

            Console.WriteLine("Ingrese fila: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese columna: ");
            int column = int.Parse(Console.ReadLine());
            writeDirections(InitialPosition(column, row));
        }

        public static int InitialPosition(int column, int row)
        {
            return (row * 32) + (column / 16);
        }

        public static void writeDirections(int position)
        {
            file.WriteLine("load Screen.hdl,\noutput-file Screen.out;\noutput-list out%B1.16.1;\n\n");

            string line = lines.dequeue();
            while (line != null)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line[j] == '*')
                        {
                            file.WriteLine("set in %B111111111111111,\n"
                                         + "set load %B1,\n"
                                         + "set address %B"
                                         + Convert.ToString((position + j + (i * 96)), 2) + ",\n"
                                         + "eval,\noutput;\n");
                        }
                    }
                    line = lines.dequeue();
                }
                position += 4;
            }

            file.Close();
        }
    }
}
