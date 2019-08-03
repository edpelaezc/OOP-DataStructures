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
            AVLTree<int, int> tree = new AVLTree<int, int>(compareInt);

            tree.add(8);
            tree.add(6);
            tree.add(9);
            tree.add(7);
            tree.add(10);
            tree.add(4);
            tree.add(5);
            tree.remove(tree.root, 7);            
            tree.preOrder(tree.root);


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
