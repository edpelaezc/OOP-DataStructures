using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTree;

namespace BTImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.add(9);
            tree.add(11);
            tree.add(10);
            tree.add(12);
            Console.WriteLine("Arbol binario completo");
            tree.preOrder(tree.root);
            Console.WriteLine("Raiz actual: " + tree.root.getElement());
            tree.remove(tree.root, 9);
            Console.WriteLine("\nEliminando nodo raiz\n");
            Console.WriteLine("Raiz actual: " + tree.root.getElement());
            tree.preOrder(tree.root);
            Console.ReadLine();
        }
    }
}
