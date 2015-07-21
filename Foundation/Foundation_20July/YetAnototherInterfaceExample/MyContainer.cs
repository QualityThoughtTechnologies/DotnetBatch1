using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnototherInterfaceExample
{
    class MyContainer<T>:IMyContainer<T>
    {
        private T[] items;
        public void Add(T item)
        {
            if (items == null)
            {
                items = new T[1];
                items[0] = item;
            }
            else
            {
                int newLength = items.Length + 1;
                T[] newCourses = new T[newLength];
                Array.Copy(items, newCourses, items.Length);
                newCourses[newLength - 1] = item;
                items = new T[newLength];
                Array.Copy(newCourses, items, items.Length);
            }
        }

        public string Display()
        {
            foreach(T t in items)
            {
                Console.WriteLine(t);
            }

            return(string.Join(",", items));
        }
    }
}
