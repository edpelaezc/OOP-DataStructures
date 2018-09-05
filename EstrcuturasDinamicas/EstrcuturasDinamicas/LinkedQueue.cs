using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class LinkedQueue<T> : Queue<T>
    {
        public MyLinkedList<T> myList;
        public LinkedQueue()
        {
            myList = new MyLinkedList<T>();
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
