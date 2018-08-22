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
            tree.add(tree.root, 15);
            tree.add(tree.root, 6);
            tree.add(tree.root, 3);
            tree.add(tree.root, 9);
            tree.add(tree.root, 1);
            tree.add(tree.root, 4);
            tree.add(tree.root, 7);
            tree.add(tree.root, 12);
            tree.add(tree.root, 20);
            tree.add(tree.root, 18);
            tree.add(tree.root, 17);
            tree.add(tree.root, 24);
            tree.branchesDepth(tree.root);
            tree.remove(tree.root, 6);
            Console.WriteLine(tree.maxDepth());
            Console.ReadLine();
        }
    }
}
