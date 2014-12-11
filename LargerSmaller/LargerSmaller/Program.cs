using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerSmaller
{
    class Program
    {
        static void Main(string[] args)
        {
            int value,value1;

            Console.WriteLine("Enter First number");
            string num1 = Console.ReadLine();
            int.TryParse(num1, out value);

            Console.WriteLine("Enter Second number");
            string num2 = Console.ReadLine();
            int.TryParse(num2, out value1);
            if (value > value1)
            {
                Console.Write("Small number is: ");
                Console.WriteLine(value1);
                Console.Write("large number is: ");
                Console.WriteLine(value);
            }
            else
            {
                Console.Write("Small number is: ");
                Console.WriteLine(value);
                Console.Write("large number is: ");
                Console.WriteLine(value1); 
            }

            Console.ReadLine();

        }
    }
}
