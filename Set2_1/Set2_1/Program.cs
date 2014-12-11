using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,sum=0;
            for (i = 0; i < 1000; i++)
            {
                if((i%3==0 )||(i%5==0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
