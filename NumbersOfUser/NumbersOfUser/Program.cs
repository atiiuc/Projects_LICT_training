using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOfUser
{
    class Program
    {
        private static void Main(string[] args)
        {
            int value, value1, i;
            Console.WriteLine("Enter First numbers");
            string line = Console.ReadLine();

            int.TryParse(line, out value);
            Console.WriteLine("Enter Second numbers");
            string line1 = Console.ReadLine();
            int.TryParse(line1, out value1);

            Console.WriteLine();
            for (i = value; i <= value1; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
