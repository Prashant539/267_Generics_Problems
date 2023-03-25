using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class MinInteger
    {
        public static void CheckMinInteger()
        {
            Console.WriteLine("Enter the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Secong Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a > b && b> c)
            {
                Console.WriteLine("Third number is smallest" +c);
            }
            else if(a>b && c > b)
            {
                Console.WriteLine("Second number is smallest" + b);
            }
            else
            {
                Console.WriteLine("First number is smallest" + a);
            }


        }
    }
}
