using System;
using System.Collections.Generic;
using EstrcuturasDinamicas;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree<T>
    {
        public Node<T> root;
        int contRight = 0;
        int contLeft = 0;
        private int treeSize = 0;
        Comparer<T> comp = Comparer<T>.Default;
        LinkedQueue<Node<T>> order = new LinkedQueue<Node<T>>(); 

        public BinaryTree()
        {
            root = null;
        }

        public int size()
        {
            return treeSize;
        }

        public int maxDepth(Node<T> root)
        {
            if (root.getLeft() != null)
            {
                contLeft = maxDepth(root.getLeft());                
            }
            if (root.getRight()!= null)
            {
                contRight = maxDepth(root.getRight());
            }
            return Math.Max(contRight, contLeft);
        }

        public void add(Node<T> root, T element)
        {            
            if (root == null)
            {
                root = new Node<T>(element, null, null, null); ;
            }
            else
            {                
                if (comp.Compare(element, root.getElement()) < 0)//x es menor que y
                {
                    if (root.getLeft() == null)
                    {
                        root.setLeft(new Node<T>(element, root, null, null));
                        treeSize++;
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
                        root.setRight(new Node<T>(element,root, null, null));
                        treeSize++;
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

        public bool elementExists(Node<T> root, T element)
        {
            if (root == null)
            {
                return false;
            }
            else if (comp.Compare(element, root.getElement()) == 0)
            {
                return true;
            }
            else
            {
                if (comp.Compare(element, root.getElement()) < 0)
                {
                    return elementExists(root.getLeft(), element);
                }
                else
                {
                    return elementExists(root.getRight(), element);
                }
            }
        }

      /*  public Node<T> locate(Node<T> root, T element)
        {
            if (root == null)
            {
                return null;
            }
            else if (comp.Compare(element, root.getElement()) == 0)
            {
                return root;
            }
            else
            {
                if (comp.Compare(element, root.getElement()) < 0)
                {
                    return locate(root.getLeft(), element);
                }
                else
                {
                    return locate(root.getRight(), element);
                }
            }
        }*/

        public int numberOfChildren(Node<T> root)
        {
                int count = 0;
                if (root.getLeft() != null)
                    count++;
                if (root.getRight() != null)
                    count++;
                return count;            
        }

        public T remove(Node<T> root, T element)
        {
            if (root == null)
            {
                return default(T);
            }
            else if (comp.Compare(element, root.getElement()) == 0)
            {
                if (numberOfChildren(root) == 0)
                {
                    if (comp.Compare(element, root.getParent().getLeft().getElement()) == 0 )
                    {
                        T aux = root.getElement();
                        root.getParent().setLeft(null);
                        root = null;
                        return aux;
                    }
                    else
                    {
                        T aux = root.getElement();
                        root.getParent().setRight(null);
                        root = null;
                        return aux;
                    }
                }
                else if (numberOfChildren(root) == 1)
                {
                    T aux = root.getElement();
                    if (comp.Compare(element, root.getParent().getLeft().getElement()) == 0)
                    {                        
                        if (root.getLeft() != null)
                        {
                            root.getParent().setLeft(root.getLeft());
                        }
                        else
                        {
                            root.getParent().setLeft(root.getRight());
                        }
                    }
                    else
                    {
                        if (root.getLeft() != null)
                        {
                            root.getParent().setRight(root.getLeft());
                        }
                        else
                        {
                            root.getParent().setRight(root.getRight());
                        }
                    }
                    return aux;
                }
                else
                {
                    T aux = root.getElement();

                    return aux;
                }
            }
            else
            {
                if (comp.Compare(element, root.getElement()) < 0)
                {
                    return remove(root.getLeft(), element);
                }
                else
                {
                    return remove(root.getRight(), element);
                }
            }                                   
        }        

        public void preOrder(Node<T> root)
        {
            if (root != null)
            {
                order.enqueue(root);
                preOrder(root.getLeft());
                preOrder(root.getRight());
            }   
        }

        public void postOrder(Node<T> root)
        {
            if (root != null)
            {
                postOrder(root.getLeft());
                postOrder(root.getRight());
                order.enqueue(root);
            }
        }

        public void inOrder(Node<T> root)
        {
            if (root != null)
            {
                inOrder(root.getLeft());
                order.enqueue(root);
                inOrder(root.getRight());
            }
        }
    }
}
