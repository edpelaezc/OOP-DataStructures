using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    class Node<T>
    {
        private T element;//valor
        private Node<T> next;//nodo siguiente
        public Node(T newElement, Node<T> nextNode)
        {
            element = newElement;
            next = nextNode;
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
}
