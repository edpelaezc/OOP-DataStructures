using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class CircularLinkedList<T>
    {
        private class Node<T>
        {
            private T element;
            private Node<T> next;
            public Node(T element, Node<T> next)
            {                
                this.element = element;
                this.next = next;
            }
            public T getElement()
            {
                return element;
            }
            public Node<T> getNext()
            {
                return next;
            }
            public void setNext(Node<T> next)
            {
                this.next = next;
            }
        }


        private Node<T> tail = null;
        private int listSize = 0;

        public int size() { return listSize; }

        public bool isEmpty() { return listSize == 0; }

        public T first()
        {
            if (isEmpty()) return default(T);
            return tail.getNext().getElement();//Primer cambio
        }

        public T last()
        {
            if (isEmpty()) return default(T);
            return tail.getElement();
        }

        public void rotate()
        {
            if (tail != null)
                tail = tail.getNext();
        }

        public void addFirst(T e)
        {
            if (listSize == 0)
            {
                tail = new Node<T>(e, null);
                tail.setNext(tail);
            }
            else
            {
                Node<T> newest = new Node<T>(e, tail.getNext());
                tail.setNext(newest);
            }
            listSize++;
        }

        public void addLast(T e)
        {
            addFirst(e);
            tail = tail.getNext();
        }

        public T removeFirst()
        {
            if (isEmpty()) return default(T);
            Node<T> head = tail.getNext();
            if (head == tail) tail = null;
            else tail.setNext(head.getNext());
            listSize--;
            return head.getElement();
        }


    }
}
