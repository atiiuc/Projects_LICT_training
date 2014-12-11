using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            double limit = 4000000, f0 = 0, f1 = 1, i, sum = 0;
            Console.WriteLine(f0);
            Console.WriteLine(f1);
            for (i = f0; sum < limit; i++)
            {
                sum = f0 + f1;
                if (sum < limit)
                    if (sum%2 == 0)
                    {
                        Console.WriteLine(sum);
                    }
                f0 = f1;
                f1 = sum;
            }
        

        Console.ReadLine();
        }
    }
}
