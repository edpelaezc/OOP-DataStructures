using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstrcuturasDinamicas;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<User> myList = new MyLinkedList<User>();
            Messages usuario = new Messages();

            for (int i = 0; i < 10; i++)
            {
                usuario.setName("Eduardo " + (i + 1).ToString());
                usuario.setChat((i + 1).ToString());
                myList.addLast(usuario);
            }

            //User[] array = myList.listToArray();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myList.removeFirst().getName());
            }

            Console.ReadLine();
        }
    }
}
