using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTree;

namespace MaximumDepthOfBT
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.add(tree.root, 3);
            tree.add(tree.root, 2);
            tree.add(tree.root, 20);
            tree.add(tree.root, 15);
            tree.add(tree.root, 7);
            tree.add(tree.root, 5);
            tree.maxDepth(tree.root);
            Console.WriteLine("LA PROFUNDIDAD DE SU ARBOL BINARIO ES: " + tree.depth);                 
            Console.ReadLine();
        }
    }
}
