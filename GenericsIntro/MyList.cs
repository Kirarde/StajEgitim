using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items= new T[0];
        }
        public void Add(T item) 
        {
            
        }
    }
}
