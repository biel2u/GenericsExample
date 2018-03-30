using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class ListOfThings<T> where T : new()
    {
        private readonly List<T> _list;

        public ListOfThings()
        {
            _list = new List<T>
            {
                new T()
            };
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T GetItem(int index)
        {
            var result = _list[index];
            return result;
        }
    }
}
