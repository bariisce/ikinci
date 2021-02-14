using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaryy
{
    class MyDictionary<A>
    {
        A[] items;
        public MyDictionary()
        {
            items = new A[0];
        }

        public void Add(A item)
        {
            A[] tempKey = items;
            items = new A[items.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                items[i] = tempKey[i];
            }
            items[items.Length - 1] = item;
            Console.WriteLine("Oyuncu Eklendi --> " + items[0]);
        }
    }
}
