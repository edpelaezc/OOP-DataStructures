using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T>
    {
        private T element;        
        private Node<T> left;
        private Node<T> right; 
        
        public Node(T t, Node<T> leftChild, Node<T> rightChild)
        {
            element = t;            
            left = leftChild;
            right = rightChild;
        }

        public T getElement() 
        {
			return element;
        }      

        public Node<T> getLeft()
        {
            return left;
        }

        public Node<T> getRight()
        {
            return right;
        }

        public void setElement(T t)
        {
            element = t;
        }

        public void setLeft(Node<T> leftChild)
        {
            left = leftChild;
        }

        public void setRight(Node<T> rightChild)
        {
            right = rightChild;
        }
    }
}
