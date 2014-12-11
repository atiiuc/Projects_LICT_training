using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit=100, f0 = 0, f1 = 1, i, sum=0;
            Console.WriteLine(f0);
            Console.WriteLine(f1);
            for (i = f0; sum < limit; i++)
            {
                sum = f0 + f1;
                if(sum<100)
                Console.WriteLine(sum);
                f0 = f1;
                f1 = sum;
            }
            Console.ReadLine();
        }
    }
}
