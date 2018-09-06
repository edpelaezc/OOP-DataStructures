using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class LinkedQueue<T> : Queue<T>
    {
        Comparer<T> comp = Comparer<T>.Default;
        MyLinkedList<T> myList;
        public LinkedQueue()
        {
            myList = new MyLinkedList<T>();
        }

        public void purge()
        {
            Node<T> auxiliary = myList.head;
            Node<T> newAux = myList.head.getNext();            

            while (auxiliary.getNext() != null)
            {
                while (newAux != null)
                {
                    if (newAux.getNext() != null)
                    { 
                        newAux = newAux.getNext();
                    }                    
                }

                if (auxiliary.getNext() != null && newAux.getNext() != null)
                {
                    auxiliary = auxiliary.getNext();
                    newAux = auxiliary.getNext();
                }                                   
            }

            Node<T> auxiliar = myList.head.getNext();
            while (auxiliar.getNext() != newAux)
            {
                auxiliar = auxiliar.getNext();
            }

            auxiliar.setNext(newAux.getNext());
            newAux = null;
        }

        public override T dequeue()
        {
            return myList.removeFirst();
        }

        public override T front()
        {
            return myList.first();
        }

        public override bool isEmpty()
        {
            return myList.isEmpty();
        }

        public override void enqueue(T t)
        {
            myList.addLast(t);
        }

        public override int size()
        {
            return myList.size();
        }
    }
}
