using System;
namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose program from below options");
            Console.WriteLine("1:Integer Delete ArrayElement and also by Generic class " +
                             "\n2:Double Delete Element and by also Generic class" +
                             "\n3:Generic Method" +
                             "\n4:Charcter Delete Element and also by using Generic class and Generic Method");
            int option = Convert.ToInt32(Console.ReadLine());
            int[] intarr = { 30, 23, 45, 56 };
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
                case 3:
                    Console.WriteLine("Plese enter element one by one");
                    for (int i = 0; i < intarr.Length; i++)
                    {
                        intarr[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    Console.WriteLine("\nPlase pickup any one element from this array");
                    int result = Convert.ToInt32(Console.ReadLine());
                    GenericMethod.DeleteElement<int>(intarr, result);
                    break;
                case 4:
                    Console.WriteLine("How many character to add into array ");
                    int gsize =Convert.ToInt32(Console.ReadLine());
                    char[] chararr = new char[gsize];
                    Console.WriteLine("Plese enter element one by one");
                    for (int i = 0; i < gsize; i++)
                    {
                        chararr[i] = Convert.ToChar(Console.ReadLine());

                    }
                    Console.WriteLine("\nPlase pickup any one element from this array");
                    char chardelete = Convert.ToChar(Console.ReadLine());
                    DeleteArrayElement.CharDeleteElement(chararr, chardelete);
                    //GenericClass<char> genericClass2 = new GenericClass<char>(chararr, chardelete);
                    //genericClass2.DeleteElement();
                   // GenericMethod.DeleteElement<char>(chararr, chardelete);
                    break;

            }

        }
    }
}
