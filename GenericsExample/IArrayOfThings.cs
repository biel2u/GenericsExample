using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public interface IArrayOfThings<T> where T: new()
    {
        T Get(int index);
        void Set(int index, T value);
    }
}
