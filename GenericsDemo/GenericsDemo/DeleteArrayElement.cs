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
            foreach(int j in result)
            {
                Console.WriteLine(j + " ");
            }
        }
        public static void DoubleDeleteElement(double[] doublearr, double delete)
        {
            int k = 0;
            double[] result = new double[doublearr.Length - 1];
            for (int i = 0; i < doublearr.Length; i++)
            {
                if (delete != doublearr[i])
                {
                    result[k] = doublearr[i];
                    k++;
                }
            }
            foreach (double j in result)
            {
                Console.WriteLine(j + " ");
            }
        }
        public static void CharDeleteElement(char[] chararr, char chardelete)

        {
            int k = 0;
            char[] result = new char[chararr.Length - 1];
            for (int i = 0; i < chararr.Length; i++)
            {
                if (chardelete != chararr[i])
                {
                    result[k] = chararr[i];
                    k++;
                }
            }
            foreach (char j in result)
            {
                Console.WriteLine(j + " ");
            }
        }

    }
}
