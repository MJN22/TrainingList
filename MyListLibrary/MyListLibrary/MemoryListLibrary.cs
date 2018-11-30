using System;
using System.Collections.Generic;

namespace MemoryListLibrary.Library
{
    public class MemoryListLibrary<T> where T : new()
    {
        public List<T> _list = new List<T>();

        public void Add(T item) {
        //Add generic type item to the list
            _list.Add(item);
          
        }

        public void Remove(T item) {
        //removes generic type item from the list

        if(Contains(item)) {
            _list.Remove(item);

           } else 
               Console.WriteLine("Item is not in list");

        } 
        public bool Contains(T item)
         // checks to see if the item already exists in the list
        {
            return _list.Contains(item);
        }

    }
}
