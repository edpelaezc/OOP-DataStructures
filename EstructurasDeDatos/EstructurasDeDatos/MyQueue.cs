using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    class MyQueue<T> : BasicStructure<T>
    {
        MyList<T> list;
        public MyQueue(int size)
        {
            list = new MyList<T>(size);
        }

        public override void add(T obj)
        {
            list.add(obj);   
        }

        public override bool isEmpty()
        {
            return list.isEmpty();
        }

        public override T remove(int index)
        {
            return list.remove(0);
        }

        public override int size()
        {
            return list.size();
        }
    }
}
