using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstrcuturasDinamicas;

namespace BinarySearchTree
{
    public class BinaryTree<T>
    {
        public Node<T> root;
        private int treeSize = 0;        
        public int depthRight = 0;
        public int depthLeft = 0;
        Comparer<T> comp = Comparer<T>.Default;
        public MyLinkedList<Node<T>> order = new MyLinkedList<Node<T>>();

        public BinaryTree()
        {
            root = null;
        }

        public int size()
        {
            return treeSize;
        }

        public void branchesDepth(Node<T> root)
        {
            if (root != null)
            {
                if (root.getLeft() != null && root.getRight() == null)
                {
                    depthLeft++;
                    branchesDepth(root.getLeft());
                }
                else if (root.getRight() != null && root.getLeft() == null) 
                {
                    depthRight++;
                    branchesDepth(root.getRight());
                }
                else if (root.getRight() != null && root.getLeft() != null)
                {
                    depthLeft++;
                    depthRight++;
                    branchesDepth(root.getLeft());
                    branchesDepth(root.getRight());
                }
            }
            else
            {
                depthLeft = 0;
                depthRight = 0;
            }
        }

        public int maxDepth()
        {
            branchesDepth(this.root);
            return Math.Max(depthLeft,depthRight) - 1;
        }

        public void add(Node<T> root, T element)
        {            
            if (this.root == null)
            {
                this.root = new Node<T>(element, null, null, null);
                treeSize++;
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

        public int numberOfChildren(Node<T> root)
        {
                int count = 0;
                if (root.getLeft() != null)
                    count++;
                if (root.getRight() != null)
                    count++;
                return count;            
        }

        public void removeLeaf(Node<T> root, T element)
        {
            if (root != null)
            {
                if (comp.Compare(element, root.getElement()) == 0)
                {
                    if (numberOfChildren(root) == 0)
                    {
                        if (comp.Compare(element, root.getParent().getLeft().getElement()) == 0)
                        {                            
                            root.getParent().setLeft(null);
                            root = null;                            
                        }
                        else
                        {                            
                            root.getParent().setRight(null);
                            root = null;                            
                        }
                    }
                }
                else
                {
                    if (comp.Compare(element, root.getElement()) < 0)
                    {
                        removeLeaf(root.getLeft(), element);
                    }
                    else
                    {
                        removeLeaf(root.getRight(), element);
                    }
                }
            }
        }

        public T searchRight(Node<T> root) 
        {
            Node<T> next = root.getLeft();
            while (next.getRight() != null)
            {
                next = next.getRight();
            }
            return next.getElement();
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
                        treeSize--;
                        return aux;
                    }
                    else
                    {
                        T aux = root.getElement();
                        root.getParent().setRight(null);
                        root = null;
                        treeSize--;
                        return aux;
                    }
                }
                else if (numberOfChildren(root) == 1)
                {
                    T aux = root.getElement();
                    if (root.getParent().getLeft() != null)
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
                    treeSize--;
                    return aux;
                }
                else//El que sustituirá será el más derecho de los izquierdos
                {
                    Node<T> next = root.getLeft();
                    T aux = root.getElement();                                                        
                    while (next.getRight() != null)
                    {
                        next = next.getRight();
                    }
                    root.setElement(next.getElement());
                    Node<T> father = next.getParent();
                    father.setRight(null);
                    treeSize--;
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
                order.addLast(root);
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
                order.addLast(root);
            }
        }

        public void inOrder(Node<T> root)
        {
            if (root != null)
            {
                inOrder(root.getLeft());
                order.addLast(root);
                inOrder(root.getRight());
            }
        }
    }
}
