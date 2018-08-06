using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree<T>
    {
        Node<T> root;
        private int treeSize = 0;
        Comparer<T> comp = Comparer<T>.Default;

        public BinaryTree()
        {
            root = null;
        }

        public int size()
        {
            return treeSize;
        }

        public void add(Node<T> root, T element)
        {            
            if (root == null)
            {
                root = new Node<T>(element, null, null); ;
            }
            else
            {                
                if (comp.Compare(element, root.getElement()) < 0)//x es menor que y
                {
                    if (root.getLeft() == null)
                    {
                        root.setLeft(new Node<T>(element, null, null));
                    }
                    else
                    {
                        add(root.getLeft(), element);
                    }
                }
                else if (comp.Compare(element, root.getElement()) > 0)//x es mayor que y 
                {
                    if (root.getRight() == null)
                    {
                        root.setRight(new Node<T>(element, null, null));
                    }
                    else
                    {
                        add(root.getRight(), element);
                    }
                }
                else//x es igual que y
                {
                    throw new Exception("NO SE PERMITEN DUPLICADOS");
                }
            }
        }
    }
}
