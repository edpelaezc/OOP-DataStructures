using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class MyDoubleLinkedList<T>
    {
        public class Node<T>
        {
            T element; 
            Node<T> predecessor;
            Node<T> successor;

            public Node(T e, Node<T> p, Node<T> n)
            {
                element = e;
                predecessor = p;
                successor = n;
            }

            public T getElement()
            {
                return element;
            }

            public Node<T> getPredecessor()
            {
                return predecessor;
            }

            public void setPredecessor(Node<T> prev)
            {
                this.predecessor = prev;
            }

            public Node<T> getSuccessor()
            {
                return successor;
            }

            public void setSuccessor(Node<T> next)
            {
                this.successor = next;
            }
        }

        private Node<T> header;
        private Node<T> trailer;        
        private int listSize;
        Comparer<T> comp = Comparer<T>.Default;

        public MyDoubleLinkedList()
        {
            header = new Node<T>(default(T), null, null);
            trailer = new Node<T>(default(T), header, null);
            header.setSuccessor(trailer);
            listSize = 0;
        }

        public int size() { return listSize; }

        public bool isEmpty() { return listSize == 0; }

        public T first()
        {
            if (isEmpty())
            {
                return default(T);
            }
            else
            {
                return header.getElement();
            }
        }

        public T last()
        {
            if (isEmpty())
            {
                return default(T);
            }
            else
            {
                return trailer.getElement();
            }
        }

        public void addFirst(T t)
        {

        }
    }
}
