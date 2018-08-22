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
            tree.add(tree.root, 8);
            tree.add(tree.root, 3);
            tree.add(tree.root, 1);
            tree.add(tree.root, 6);
            tree.add(tree.root, 4);
            tree.add(tree.root, 7);
            tree.add(tree.root, 10);
            tree.add(tree.root, 14);
            tree.add(tree.root, 13);
            tree.branchesDepth(tree.root);
            tree.remove(tree.root, 3);
            Console.WriteLine(tree.maxDepth());
            Console.ReadLine();
        }
    }
}
