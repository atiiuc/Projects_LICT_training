using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int value,value1,add, sub, div, mul;
            Console.WriteLine("Enter First numbers");
            string line=Console.ReadLine();
           
            int.TryParse(line, out value);
            Console.WriteLine("Enter Second numbers");
            string line1 = Console.ReadLine();
            int.TryParse(line1, out value1);

            add = value + value1;
            sub = value - value1;
            div = value / value1;
            mul = value * value1;
            Console.Write("additon result: ");
            Console.WriteLine(add);
            Console.Write("subtractin result: ");
            Console.WriteLine(sub);
            Console.Write("division result: ");
            Console.WriteLine(div);
            Console.Write("multiplication result: ");
            Console.WriteLine(mul);
            Console.ReadLine();
        }
    }
}
