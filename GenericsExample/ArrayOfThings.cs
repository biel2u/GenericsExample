using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class ArrayOfThings<T>
    {
        private readonly T[] _array;

        public ArrayOfThings(int size)
        {
            _array = new T[size];
        }
        public T Get(int index)
        {
            return _array[index];
        }
        public void Set(int index, T value)
        {
            _array[index] = value;
        }
    }
}