using System;
using System.Collections.Generic;
using System.Linq;

namespace sum{

 public static class Extensions
 {
     public static IEnumerable<T> Where<T> (this IEnumerable<T> source,  Func<T,bool> p)
     {
         foreach(var i in source)
         {
             if(p(i))
             {
                 yield return i;
             }
         }
     }
 }
}