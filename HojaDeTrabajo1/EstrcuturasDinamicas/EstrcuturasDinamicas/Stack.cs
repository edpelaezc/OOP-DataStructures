using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrcuturasDinamicas
{
    public abstract class Stack<T>
    {
        public abstract int size();
        public abstract bool isEmpty();
        public abstract void push(T t);
        public abstract T pop();
        public abstract T top();
    }
}
