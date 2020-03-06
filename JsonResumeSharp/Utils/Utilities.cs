using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonResumeSharp.Utils
{
    class Utilities
    {
        public static void  AddItemToList<T>(List<T> list, T item)
        {
            if (list == null)
                list = new List<T>();
            

            list.Add(item);
            
           
        }
    }
}
