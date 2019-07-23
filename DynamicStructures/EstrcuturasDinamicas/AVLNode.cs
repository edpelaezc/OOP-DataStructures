using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class AVLNode<T>
    {
        private T element;
        private AVLNode<T> parent;
        private AVLNode<T> left;
        private AVLNode<T> right;
        private int height; 

        public AVLNode(T t, AVLNode<T> above, AVLNode<T> leftChild, AVLNode<T> rightChild)
        {
            element = t;
            parent = above;
            left = leftChild;
            right = rightChild;
        }

        public int getHeight()
        {
            return height;
        }

        public void setHeight(int nodeHeight)
        {
            height = nodeHeight;
        }

        public T getElement()
        {
            return element;
        }

        public AVLNode<T> getParent()
        {
            return parent;
        }

        public AVLNode<T> getLeft()
        {
            return left;
        }

        public AVLNode<T> getRight()
        {
            return right;
        }

        public void setElement(T t)
        {
            element = t;
        }

        public void setParent(AVLNode<T> parentAVLNode)
        {
            parent = parentAVLNode;
        }

        public void setLeft(AVLNode<T> leftChild)
        {
            left = leftChild;
        }

        public void setRight(AVLNode<T> rightChild)
        {
            right = rightChild;
        }
    }
}
