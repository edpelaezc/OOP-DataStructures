using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstrcuturasDinamicas;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            MyLinkedList<string> list1 = new MyLinkedList<string>();
            MyLinkedList<string> list2 = new MyLinkedList<string>();
            MyLinkedList<string> mergedList = new MyLinkedList<string>();
            Console.WriteLine("INGRESE LAS DOS LISTAS: ");
            input = Console.ReadLine();
            string[] elements = input.Split('-', '>');
            int cont = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == ",")
                {
                    cont = i;
                }
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (i < cont)
                {
                    list1.addLast(elements[i]);
                }
                else
                {
                    list2.addLast(elements[i]);
                }
            }


            while (list1.isEmpty() == false && list2.isEmpty() == false)
            {
                mergedList.addLast(list1.removeFirst());
                mergedList.addLast(list2.removeFirst());
            }
            Console.WriteLine(mergedList.size());
            Console.ReadLine();
        }
    }
}
