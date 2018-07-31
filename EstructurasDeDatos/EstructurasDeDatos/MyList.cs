using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class MyList<T> : BasicStructure<T>
    {
        private int count;
        private T[] list;

        public MyList(int size)
        {
            list = new T[size];
            for (int i = 0; i < size; i++)
            {
                list[i] = default(T);
            }
            count = 0;
        }

        public override void add(T obj)
        {
            if (count >= 0 && count < list.Length)
            {
                list[count] = obj;
                count++;
            }
            else
            {
                throw new IndexOutOfRangeException("INDICE FUERA DE RANGO");
            }
        }

        public override bool isEmpty()
        {
            return count == 0;
        }

        public override T remove(int index)
        {
            if (index >= 0 && index < list.Length)
            {
                T auxiliary = list[index];
                list[index] = default(T);
                for (int i = index + 1; i < list.Length; i++)
                {
                    list[i - 1] = list[i];
                }
                count--;
                return auxiliary;
            }
            else
            {
                throw new IndexOutOfRangeException("INDICE FUERA DE RANGO");
            }
        }

        public override int size()
        {
            return count;
        }
    }
}
