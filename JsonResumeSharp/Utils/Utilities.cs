using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonResumeSharp.Utils
{
    class Utilities
    {
        public static void  AddItemToArray<T>(T[] array, T item)
        {
            
            var list = array.ToList();
            list.Add(item);
            array = list.ToArray();
           
        }
    }
}
