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

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '-' || input[i] != '>' )
                {
                    if (input[i] != ',')
                    {
                        list1.addLast(input[i++].ToString());
                    }
                    else
                    {
                        list2.addLast(input[i++].ToString());
                    }
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
