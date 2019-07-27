using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class BinaryTree<T>
    {
        public TreeNode<T> root;
        private int numberOfTreeNodes = 0;
        Comparer<T> comp = Comparer<T>.Default;
        public MyLinkedList<TreeNode<T>> order = new MyLinkedList<TreeNode<T>>();

        public BinaryTree()
        {
            root = null;
        }

        public int weight()
        {
            return numberOfTreeNodes;
        }


        public int treeDepth(TreeNode<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = treeDepth(root.getLeft());
                int rightDepth = treeDepth(root.getRight());
                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }

        public void add(T element)
        {
            if (this.root == null)
            {
                root = new TreeNode<T>(element, null, null, null);
                numberOfTreeNodes++;
            }
            else
            {
                addElement(this.root, element);
            }
        }

        private void addElement(TreeNode<T> root, T element)
        {
            if (this.root == null)
            {
                this.root = new TreeNode<T>(element, null, null, null);
                numberOfTreeNodes++;
            }
            else
            {
                if (comp.Compare(element, root.getElement()) < 0)//x es menor que y
                {
                    if (root.getLeft() == null)
                    {
                        root.setLeft(new TreeNode<T>(element, root, null, null));
                        numberOfTreeNodes++;
                    }
                    else
                    {
                        addElement(root.getLeft(), element);
                    }
                }
                else if (comp.Compare(element, root.getElement()) > 0)//x es mayor que y 
                {
                    if (root.getRight() == null)
                    {
                        root.setRight(new TreeNode<T>(element, root, null, null));
                        numberOfTreeNodes++;
                    }
                    else
                    {
                        addElement(root.getRight(), element);
                    }
                }
                else//x es igual que y
                {
                    throw new Exception("NO SE PERMITEN DUPLICADOS");
                }
            }
        }

        public bool elementExists(TreeNode<T> root, T element)
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

        public int numberOfChildren(TreeNode<T> root)
        {
            int count = 0;
            if (root.getLeft() != null)
                count++;
            if (root.getRight() != null)
                count++;
            return count;
        }

        public T remove(TreeNode<T> root, T element)
        {
            if (root == null)
            {
                return default(T);
            }
            else if (comp.Compare(element, root.getElement()) == 0)
            {
                if (numberOfChildren(root) == 0)
                {
                    T aux = root.getElement();
                    if (root == this.root)
                    {
                        this.root = null;
                    }
                    else
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
                    numberOfTreeNodes--;
                    return aux;
                }
                else if (numberOfChildren(root) == 1)
                {
                    T aux = root.getElement();
                    if (root == this.root)
                    {
                        if (root.getLeft() != null)
                        {
                            this.root = root.getLeft();
                        }
                        else
                        {
                            this.root = root.getRight();
                        }
                    }
                    else
                    {
                        if (root.getParent().getLeft() != null)
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
                        else
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
                    }
                    numberOfTreeNodes--;
                    return aux;
                }
                else//El que sustituirá será el más derecho de los izquierdos
                {
                    TreeNode<T> next = root.getLeft();
                    T aux = root.getElement();
                    if (next.getRight() != null)
                    {
                        while (next.getRight() != null)
                        {
                            next = next.getRight();
                        }
                        root.setElement(next.getElement());
                        TreeNode<T> father = next.getParent();
                        father.setRight(null);
                    }
                    else
                    {
                        root.setElement(next.getElement());
                        root.setLeft(null);
                    }

                    numberOfTreeNodes--;
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

        public void preOrder(TreeNode<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.getElement());
                order.addLast(root);
                preOrder(root.getLeft());
                preOrder(root.getRight());
            }
        }

        public void postOrder(TreeNode<T> root)
        {
            if (root != null)
            {
                postOrder(root.getLeft());
                postOrder(root.getRight());
                order.addLast(root);
            }
        }

        public void inOrder(TreeNode<T> root)
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
