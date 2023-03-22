using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class DeleteArrayElement
    {
        public static void DeleteElement(int[] arr, int delete)
        {
            int k = 0;
            int[] result = new int[arr.Length - 1];
            for(int i = 0; i< arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach(var j in result)
            {
                Console.WriteLine(j + " ");
            }
        }
    }
}
