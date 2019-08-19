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
            AVLTree<Student, int> tree = new AVLTree<Student, int>();
            tree.compareNodesDelegate(compareStudents);
            tree.compareKeysDelegate(compareKey);

            tree.add(new Student(4, "Eduardo"));
            tree.add(new Student(1, "Antonio"));
            tree.add(new Student(5, "Pelaez"));
            tree.add(new Student(3, "Cifuentes"));
            tree.add(new Student(6, "Roberto"));
            tree.add(new Student(7, "Ana"));
            tree.preOrder(tree.root);


            Console.ReadLine();
        }

        static int compareInt(int number1, int number2)
        {
            if (number1 < number2)            
                return -1;        
            else if (number1 > number2)
                return 1;
            else
            return 0;
        }

        static int compareStudents(Student st1, Student st2) {
            if (st1.getID() < st2.getID())
                return -1;
            else if (st1.getID() > st2.getID())
                return 1;
            else
                return 0;
        }

        static int compareKey(Student st1, int key)
        {
            if (st1.getID() < key)
                return -1;
            else if (st1.getID() > key)
                return 1;
            else
                return 0;
        }
    }
}
