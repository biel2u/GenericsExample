using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class Program
    {
        private static void Main()
        {
            var arrayOfInt = new ArrayOfThings<int>(10);
            var arrayOfString = new ArrayOfThings<string>(10);

            for (var i = 0; i < 10; i++)
            {
                arrayOfInt.Set(i, i);
                arrayOfString.Set(i, $"string number {i}.");
            }

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayOfInt.Get(i));
                Console.WriteLine(arrayOfString.Get(i));
            }

            Console.ReadKey();
        }
    }
}
