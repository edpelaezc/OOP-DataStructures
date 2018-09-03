using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstrcuturasDinamicas;

namespace DSImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myList = new MyLinkedList<int>();
            LinkedStack<int> myStack = new LinkedStack<int>();
            LinkedQueue<int> myQueue = new LinkedQueue<int>();
            int cont = 0;
            myList.addLast(1);
            myList.addLast(3);
            myList.addLast(7);
            myList.addLast(5);
            myList.addFirst(10);
            myList.addElement(3, 15);
            cont = myList.size();

            Console.WriteLine("LISTA");
            Console.WriteLine("El primer elemento de la lista es: " + myList.first());
            Console.WriteLine("El ultimo elemento de la lista es: " + myList.last());
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(myList.removeFirst());
            }
            Console.WriteLine("\nEl primer elemento de la lista es: " + myList.first());
            Console.WriteLine("El ultimo elemento de la lista es: " + myList.last());
            Console.WriteLine("El nuevo tamaño de la lista es: " + myList.size());

            myStack.push(1);
            myStack.push(3);
            myStack.push(7);
            myStack.push(5);
            myStack.push(10);
            Console.WriteLine("\nPILA");
            Console.WriteLine("El primer elemento de la pila es: " + myStack.top());
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(myStack.pop());
            }

            myQueue.enqueue(1);
            myQueue.enqueue(3);
            myQueue.enqueue(7);
            myQueue.enqueue(5);
            myQueue.enqueue(10);
            Console.WriteLine("\nCOLA");
            Console.WriteLine("El primer elemento de la pila es: " + myQueue.front());
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(myQueue.dequeue());
            }            
            Console.ReadLine();
        }
    }
}
