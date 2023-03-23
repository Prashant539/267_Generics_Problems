using System;
namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose program from below options");
            Console.WriteLine("1:Integer Delete ArrayElement and also by Generic class \n2:Double Delete Element and by also Generic class");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("How many elements to add into array ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Plese enter element one by one");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    Console.WriteLine("\nPlase pickup any one element from this array");
                    int delete = Convert.ToInt32(Console.ReadLine());
                   // DeleteArrayElement.DeleteElement(arr, delete);
                    GenericClass<int> genericClass = new GenericClass<int>(arr, delete);
                    genericClass.DeleteElement();
                    //genericClass.DeleteElement
                    Console.ReadLine();
                    break;
                 case 2:
                    Console.WriteLine("How many elements to add into array ");
                    int doublesize = Convert.ToInt32(Console.ReadLine());
                    double[] doublearr = new double[doublesize];
                    Console.WriteLine("Plese enter element one by one");
                    for (int i = 0; i < doublearr.Length; i++)
                    {
                        doublearr[i] = Convert.ToDouble(Console.ReadLine());

                    }
                    Console.WriteLine("\nPlase pickup any one element from this array");
                    double doubledelete = Convert.ToDouble(Console.ReadLine());
                   // DeleteArrayElement.DoubleDeleteElement(doublearr, doubledelete);
                    GenericClass<double> genericClass1 = new GenericClass<double>(doublearr, doubledelete);
                    genericClass1.DeleteElement();
                    break;
          
            }

        }
    }
}
