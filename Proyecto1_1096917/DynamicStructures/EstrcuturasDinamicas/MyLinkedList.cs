using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    /// <summary>
    /// Lista enlazada simple 
    /// </summary>
    /// <typeparam name="T">Lista de tipo genérico</typeparam>
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
        public int size() { return listSize; }

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
        /// addAtIndex
        /// </summary>
        /// <param name="t">Elemento que se insertará en la lista cuando el contador auxiliar sea igual al índice.</param>
        /// <param name="index">Posición en donde se insertará el elemento.</param>
        public void addAtIndex(T t, int index)
        {
            int size = this.size();
            if (validate(index.ToString()))
            {
                if (index == 0)
                {
                    this.addFirst(t);
                }
                else if (size > 0 && index < size)
                {
                    Node<T> actualNode = head;
                    int cont = 1;

                    while (cont < index)
                    {
                        actualNode = actualNode.getNext();
                        cont++;
                    }

                    this.addElement(actualNode.getElement(), t);
                }
                else if (size == index)
                {
                    this.addLast(t);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new FormatException();
            }
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
        /// Purge. Elimina elementos repetidos en la lista enlazada. 
        /// </summary>
        public void purge()
        {
            Node<T> aux = head;
            Node<T> aux2 = aux.getNext();
            while (aux2.getNext() != null)
            {
                while (aux2 != null)
                {
                    if (comp.Compare(aux.getElement(), aux2.getElement()) == 0)
                    {
                        Node<T> auxiliar = head;
                        while (auxiliar.getNext() != aux2)
                        {
                            auxiliar = auxiliar.getNext();
                        }
                        auxiliar.setNext(aux2.getNext());
                        listSize--;
                    }
                    aux2 = aux2.getNext();
                }
                aux = aux.getNext();
                aux2 = aux.getNext();
                if (aux == null || aux2 == null)
                {
                    break;
                }
            }
        }

        public void purgeElement(T reference)
        {
            Node<T> aux = head;
            while (aux != null)
            {
                if (comp.Compare(aux.getElement(), reference) == 0)
                {
                    removeElement(reference);                    
                }
                aux = aux.getNext();
            }
        } 

        /// <summary>
        /// removeAtIndex
        /// </summary>
        /// <param name="index">Número entero que indica la posición en donde se quiere eliminar.</param>
        /// <returns>Retorna en el elemento que se encuentra en la posición del índice.</returns>
        public T removeAtIndex(int index)
        {
            if (validate(index.ToString()))
            {
                if (index == 0)
                {
                    return this.removeFirst();
                }
                else
                {
                    int cont = 0;
                    Node<T> auxiliarNode = head;
                    while (cont < index)
                    {
                        cont++;
                        auxiliarNode = auxiliarNode.getNext();
                    }                    
                    return this.removeElement(auxiliarNode.getElement());
                }
            }
            else
            {
                throw new FormatException();
            }
        }

        /// <summary>
        /// removeElement
        /// </summary>
        /// <param name="reference">Parámetro de referencia, elemento que se eliminará</param>
        /// <returns>Retorna el elemento que se especificó en el parámetro.</returns>
        public T removeElement(T reference)
        {
            Node<T> predecessor = null;
            Node<T> auxNode = head;
            while (comp.Compare(auxNode.getElement(), reference) != 0)
            {
                predecessor = auxNode;
                auxNode = auxNode.getNext();
            }
            if (predecessor != null)
            {
                T auxiliary = auxNode.getElement();
                predecessor.setNext(auxNode.getNext());
                listSize--;
                return auxiliary;
            }
            else
            {
                return this.removeFirst();
            }            
        }

        /// <summary>
        /// removeFirst
        /// </summary>
        /// <returns>Elimina el elemento que se encuentra en la primera posición de la lista.</returns>
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

        /// <summary>
        /// removeLast
        /// </summary>
        /// <returns>Elimina el elemento que se encuentra en la última posición de la lista.</returns>
        public T removeLast()
        {
            if (isEmpty())
            {
                return default(T);
            }
            else
            {
                T auxiliary = tail.getElement();
                Node<T> auxNode = head;

                while (auxNode.getNext() != tail)
                {
                    auxNode = auxNode.getNext();
                }
                tail = auxNode;                
                listSize--;

                if (listSize == 0)
                {
                    tail = null;
                }
                return auxiliary;
            }
        }

        /// <summary>
        /// listToArray
        /// </summary>
        /// <returns>Devuelve los elementos de la lista enlazada en un arreglo convencional.</returns>
        public T[] listToArray()
        {
            Node<T> auxiliar = head;
            T[] myArray = new T[this.size()];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = auxiliar.getElement();
                auxiliar = auxiliar.getNext();
            }

            return myArray;
        }

        /// <summary>
        /// validate
        /// </summary>
        /// <param name="_string">Cadena que se tratará de convertir a tipo entero. Índice que se utiliza en algunos métodos de la lista.</param>
        /// <returns>"True" si es posible convertir la cadena a entero, "False" si no es posible hacer la conversión.</returns>
        public bool validate(string _string)
        {
            int numValue;
            return int.TryParse(_string, out numValue);
        }
    }
}
