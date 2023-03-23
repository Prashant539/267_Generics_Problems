using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class GenericMethod
    {
        public static void DeleteElement<T>(T[] arr, T delete)
        {
            int k = 0;
            T[] result = new T[arr.Length - 1];
            for(var i = 0; i < arr.Length; i++)
            {
                if (!delete.Equals(arr[i]))
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (var j in result)
            {
                Console.WriteLine(j + " ");
            }
        }
    }
}
 
