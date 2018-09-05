using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public class MyLinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        private int listSize;
        Comparer<T> comp = Comparer<T>.Default;

        /// <summary>
        /// Constructor de la Lista Enlazada simple
        /// </summary>
        public MyLinkedList()
        {
            head = null;
            tail = null;
            listSize = 0;
        }

        /// <summary>
        /// Size
        /// </summary>
        /// <returns>Devuelve el tamaño de la lista.</returns>
        public int size() {return listSize;}

        /// <summary>
        /// isEmpty
        /// </summary>
        /// <returns>Devuelve un valor booleano si la lista está vacía o no.</returns>
        public bool isEmpty() { return listSize == 0; }

        /// <summary>
        /// first
        /// </summary>
        /// <returns>Devuelve el primero elemento de la lista.</returns>
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

        /// <summary>
        /// last
        /// </summary>
        /// <returns>Devuelve el último elemento de la lista.</returns>
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

        /// <summary>
        /// addFirst
        /// </summary>
        /// <param name="t">Agrega el elemento genérico "t" en la primera posición de la lista (head).</param>
        public void addFirst(T t)
        {
            head = new Node<T>(t, head);
            if (listSize == 0)
            {
                tail = head;
            }
            listSize++;
        }

        /// <summary>
        /// addElement
        /// </summary>
        /// <param name="reference">Elemento que sirve de referencia para insertar.</param>
        /// <param name="t">Inserta el genérico "t" después del genérico "reference"</param>
        public void addElement(T reference, T t) 
        {            
            Node<T> auxiliar = head;
            while (comp.Compare(auxiliar.getElement(), reference) != 0)
            {
                auxiliar = auxiliar.getNext();
            }
            Node<T> newNode = new Node<T>(t, auxiliar.getNext());
            auxiliar.setNext(newNode);
            listSize++;
        }

        /// <summary>
        /// addLast
        /// </summary>
        /// <param name="t">Agrega el elemento genérico "t" en la última posición de la lista (tail).</param>
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
            }
            tail = newest;
            listSize++;
        }

        /// <summary>
        /// removeFirst
        /// </summary>
        /// <returns>Elimina el elemento que se encuentra en la última posición de la lista.</returns>
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
