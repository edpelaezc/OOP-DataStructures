using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class AVLTree<T>
    {
        public delegate int compare<T>(T aux, T aux2);
        private int numberOfTreeNodes = 0;
        public AVLNode<T> root;

        public AVLTree() {
            root = null;
        }

        public int weight()
        {
            return numberOfTreeNodes;
        }

        public bool isEmpty() {
            return root == null;
        }

        public int height(AVLNode<T> root) {
            if (root == null) {
                return -1;
            }
            else {
                return root.getHeight();
            }
        }

        public void updateHeight(AVLNode<T> root) {
            if (root != null) {
                root.setHeight(Math.Max(height(root.getLeft()), height(root.getRight())) + 1);
            }
        }

        public void add(T element, compare<T> compareElements)
        {
            if (this.root == null)
            {
                root = new AVLNode<T>(element, null, null, null);
                numberOfTreeNodes++;
            }
            else
            {
                addElement(root, element, compareElements);
            }
        }

        private void addElement(AVLNode<T> root, T element, compare<T> compareElements)
        {
            if (compareElements(element, root.getElement()) < 0)//x es menor que y
            {
                if (root.getLeft() == null)
                {
                    root.setLeft(new AVLNode<T>(element, root, null, null));
                    numberOfTreeNodes++;
                }
                else
                {
                    addElement(root.getLeft(), element, compareElements);
                }
            }
            else if (compareElements(element, root.getElement()) > 0)//x es mayor que y 
            {
                if (root.getRight() == null)
                {
                    root.setRight(new AVLNode<T>(element, root, null, null));
                    numberOfTreeNodes++;
                }
                else
                {
                    addElement(root.getRight(), element, compareElements);
                }
            }
            else//x es igual que y
            {
                throw new Exception("NO SE PERMITEN DUPLICADOS");
            }
        }
    }
}
