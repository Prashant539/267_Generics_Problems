using System;
namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements to add into array ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Plese enter element one by one");
            for(int i = 0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\nPlase pickup any one element from this array");
            int delete = Convert.ToInt32(Console.ReadLine());
            DeleteArrayElement.DeleteElement(arr, delete);
            Console.ReadLine();
        }
    }
}
