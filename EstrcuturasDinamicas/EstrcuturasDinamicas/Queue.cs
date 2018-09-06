using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public abstract class Queue<T>
    {
        public abstract int size();
        public abstract bool isEmpty();
        public abstract void enqueue(T t);
        public abstract T dequeue();
        public abstract T front();
        public abstract void purge();
    }
}
