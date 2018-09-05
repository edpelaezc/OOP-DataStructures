using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class LinkedStack<T> : Stack<T>
    {
        public MyLinkedList<T> myList;
        public LinkedStack()
        {
            myList = new MyLinkedList<T>();
        }

        public override bool isEmpty()
        {
            return myList.isEmpty();
        }

        public override T pop()
        {
            return myList.removeFirst();
        }

        public override void push(T t)
        {
            myList.addFirst(t);
        }

        public override int size()
        {
            return myList.size();
        }

        public override T top()
        {
            return myList.first();
        }
    }
}
