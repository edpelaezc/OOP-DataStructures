using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstrcuturasDinamicas;

namespace DSImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> tree = new AVLTree<int>(compareInt);
            tree.add(2);
            tree.add(1);
            tree.add(3);
            tree.add(5);
            tree.add(6);
            Console.ReadLine();
        }

        static int compareInt(int number1, int number2)
        {
            if (number1 < number2)            
                return -1;        
            else if (number1 > number2)
                return 1;
            else
            return 0;
        }
    }
}
