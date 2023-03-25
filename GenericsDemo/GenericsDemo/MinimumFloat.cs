using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class MinimumFloat
    {
        public static void CheckMinFloat()
        {
            Console.WriteLine("Enter the 3 Float value");
            int a = (int)Convert.ToDouble(Console.ReadLine());
            int b = (int)Convert.ToDouble(Console.ReadLine());
            int c = (int)Convert.ToDouble(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine("Third number is smallest",  +c);
            }
            else if (a > b && c > b)
            {
                Console.WriteLine("Second number is smallest",  +b);
            }
            else
            {
                Console.WriteLine("First number is smallest",  +a);
            }


        }
    }
}
