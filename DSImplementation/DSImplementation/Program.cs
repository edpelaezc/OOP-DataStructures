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
            /*LinkedStack<int> myStack = new LinkedStack<int>();
            LinkedQueue<int> myQueue = new LinkedQueue<int>();*/
            int cont = 0;
            myList.addLast(1);
            myList.addLast(3);
            myList.addLast(1);
            myList.addLast(3);
            myList.addLast(1);
            myList.addLast(2);
            myList.addLast(1);
            myList.addLast(1);
            myList.addLast(1);
            myList.addLast(7);
            myList.addLast(1);
            myList.addLast(2);           
            myList.addLast(5);
            myList.addLast(2);
            myList.addLast(2);
            myList.addLast(2);
            myList.addLast(2);
            myList.addLast(2);           
             myList.addElement(3, 15);
             myList.addAtIndex(4, 4);
            myList.purgeElement(1);
            myList.addFirst(500);            
            myList.removeElement(500);
            cont = myList.size();
            int[] array = myList.listToArray();
             Console.WriteLine("LISTA");             
             Console.WriteLine("El primer elemento de la lista es: " + myList.first());
             Console.WriteLine("El ultimo elemento de la lista es: " + myList.last());
             for (int i = 0; i < cont; i++)
             {
                 Console.WriteLine(array[i]);
             }

             /*myStack.push(1);
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
             
            myQueue.enqueue(15);
            myQueue.enqueue(3);
            myQueue.enqueue(4);
            myQueue.enqueue(15);
            myQueue.enqueue(70);
            myQueue.enqueue(45);
            myQueue.enqueue(2);
            myQueue.enqueue(45);
            myQueue.purge();            
            Console.WriteLine("\nCOLA");
            Console.WriteLine("El primer elemento de la pila es: " + myQueue.front());
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(myQueue.dequeue());
            }*/            
            Console.ReadLine();
        }
    }
}
