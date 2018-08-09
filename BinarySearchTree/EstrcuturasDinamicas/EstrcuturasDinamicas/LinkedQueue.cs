using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    class LinkedQueue<T> : Queue<T>
    {
        LinkedList<T> myList;
        public LinkedQueue()
        {
            myList = new LinkedList<T>();
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
