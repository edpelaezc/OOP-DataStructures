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
            tree.add(4);
            tree.add(2);
            tree.add(5);
            tree.add(1);
            tree.add(7);
            tree.add(3);
            tree.add(6);            

            //tree.add(8);
            //tree.add(11);
            //tree.add(5);
            //tree.add(2);
            //tree.add(9);
            //tree.add(6);
            //tree.add(15);
            //tree.add(0);
            //tree.add(10);
            //tree.add(14);
            //tree.add(3);
            //tree.add(7);
            //tree.add(18);
            //tree.add(4);
            //tree.remove(tree.root, 15);
            //tree.remove(tree.root, 6);
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
