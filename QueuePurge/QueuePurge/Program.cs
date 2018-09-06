using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstrcuturasDinamicas;

namespace QueuePurge
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> myQueue = new LinkedQueue<int>();
            myQueue.enqueue(15);
            myQueue.enqueue(3);
            myQueue.enqueue(4);
            myQueue.enqueue(15);
            myQueue.enqueue(70);
            myQueue.enqueue(45);
            myQueue.enqueue(2);
            myQueue.enqueue(45);
            myQueue.purge();
            int cont = myQueue.size();

            Console.WriteLine("La nueva lista, sin elementos repetidos es: ");
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(myQueue.dequeue().ToString());
            }
            Console.ReadLine();
        }
    }
}
