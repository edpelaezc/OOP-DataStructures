using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    /// <summary>
    /// Estructura de datos básica. 
    /// </summary>
    /// <typeparam name="T">Nodo genérico, el parámetro será el elemento a insertar dependiendo de su tipo.</typeparam>
    public class Node<T>
    {
        private T element;//valor
        private Node<T> next;//nodo siguiente        

        /// <summary>
        /// Node. Constructor de la Clase.
        /// </summary>
        /// <param name="newElement">Elemento del nodo.</param>
        /// <param name="nextNode">Referencia a nodo siguiente.</param>
        public Node(T newElement, Node<T> nextNode)
        {
            element = newElement;
            next = nextNode;
        }

        /// <summary>
        /// getElement
        /// </summary>
        /// <returns>Retorna el elemento del nodo.</returns>
        public T getElement()
        {
            return element;
        }

        /// <summary>
        /// getNext
        /// </summary>
        /// <returns>Obtiene el nodo siguiente del nodo actual.</returns>
        public Node<T> getNext()
        {
            return next;
        }

        /// <summary>
        /// setNext
        /// </summary>
        /// <param name="next">Permite cambiar el nodo siguiente del nodo analizado.</param>
        public void setNext(Node<T> next)
        {
            this.next = next;
        }
    }
}
