using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeDatos
{
    public abstract class BasicStructure<T>
    {
        public abstract void add(T obj);
        public abstract T remove(int index);
        public abstract bool isEmpty();
        public abstract int size();
    }
}
