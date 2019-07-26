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
        compare<T> compareElements;
        private int numberOfTreeNodes = 0;
        public AVLNode<T> root;

        public AVLTree(compare<T> cmp) {
            root = null;
            compareElements = cmp;
        }

        public int weight()
        {
            return numberOfTreeNodes;
        }

        public bool isEmpty() {
            return this.root == null;
        }

        public int height(AVLNode<T> root)
        {
            if (root == null) {
                return 0;
            }
            else {
                return root.getHeight();
            }
        }

        public void updateHeight (AVLNode<T> root) {
            if (root != null)
            {
                root.setHeight(Math.Max(height(root.getLeft()), height(root.getRight())) + 1);
            }
        }

        public void add(T element)
        {
            if (this.root == null)
            {
                root = new AVLNode<T>(element, null, null, null);
                numberOfTreeNodes++;
            }
            else
            {
                addElement(this.root, element);              
            }
        }

        private void addElement(AVLNode<T> root, T element)
        {
            if (compareElements(element, root.getElement()) < 0)//x es menor que y
            {
                if (root.getLeft() == null){
                    root.setLeft(new AVLNode<T>(element, root, null, null));
                    numberOfTreeNodes++;
                }
                else{
                    addElement(root.getLeft(), element);
                }
            }
            else if (compareElements(element, root.getElement()) > 0)//x es mayor que y 
            {
                if (root.getRight() == null){
                    root.setRight(new AVLNode<T>(element, root, null, null));
                    numberOfTreeNodes++;
                }
                else{
                    addElement(root.getRight(), element);
                }
            }
            balance(root);
            updateHeight(root);            
        }

        private void rotation(AVLNode<T> root, bool direction)
        {
            AVLNode<T> aux;
            AVLNode<T> parent;
            if (direction) //si es verdadero será rotación izquierda
            {
                aux = root.getLeft();
                parent = root.getParent();
                aux.setParent(parent);
                root.setLeft(aux.getRight());
                aux.setRight(root);
                parent.setRight(aux);
            }
            else //rotación derecha
            {
                aux = root.getRight();
                parent = root.getParent();
                aux.setParent(parent);
                root.setRight(aux.getLeft());
                aux.setLeft(root);
                parent.setRight(aux);
            }
            
            updateHeight(root);
            updateHeight(aux);
            root = aux;
        }

        private void doubleRotation(AVLNode<T> root, bool direction)
        {
            if (direction) //doble rotación izquierda
            {
                rotation(root.getLeft(), false);
                rotation(root, true);
            }
            else //doble rotación derecha
            {
                rotation(root.getRight(), true);
                rotation(root, false);
            }
        }

        void balance(AVLNode<T> root)
        {
            if (this.root != null)
            {
                if (height(root.getLeft()) - height(root.getRight()) == 2) //hay un desequilibrio a la izquierda
                {
                    if (height(root.getLeft().getLeft()) >= height(root.getLeft().getRight())) //desequilibrio simple hacia la izquierda
                    {
                        rotation(root, true);
                    }
                    else //desequilibrio doble hacia la izquierda
                    {
                        doubleRotation(root, true);
                    }
                }

                else if (height(root.getRight()) - height(root.getLeft()) == 2) //desequilibrio a la derecha
                {
                    if (height(root.getRight().getRight()) >= height(root.getRight().getLeft())) //desequiibrio simple hacia la derecha
                    {
                        rotation(root, false);
                    }
                    else //desequilibri doble hacia la derecha
                    {
                        doubleRotation(root, false);
                    }
                }
            }
        }

        public void preOrder(AVLNode<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.getElement());                
                preOrder(root.getLeft());
                preOrder(root.getRight());
            }
        }

    }
}

