using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int listSize;
        
        public LinkedList()
        {
            head = null;
            tail = null;
            listSize = 0;
        }

        public int size() {return listSize;}

        public bool isEmpty() { return listSize == 0; }

        public T first()
        {
            if (isEmpty())
            {
                return default(T);
            }
            else
            {
                return head.getElement();
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
                return tail.getElement();
            }
        }

        public void addFirst(T t)
        {
            head = new Node<T>(t, head);
            if (listSize == 0)
            {
                tail = head;
            }
            listSize++;
        }

        public void addLast(T t)
        {
            Node<T> newest = new Node<T>(t, null);
            if (isEmpty())
            {
                head = newest;
            }
            else
            {                
                tail.setNext(newest);
                tail = newest;
                listSize++;
            }                        
        }

        public T removeFirst()
        {            
            if (isEmpty())
            {
                return default(T);
            }
            else
            {
                T auxiliary = head.getElement();
                head = head.getNext();
                listSize--;
                if (listSize == 0)
                {
                    tail = null;
                }
                return auxiliary;
            }
        }
    }
}
