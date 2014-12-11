using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isPrime = false;
            long limit = 2000000;
            long ans = 2;
            for (long i = 3; i < limit; i += 2)
            {
                for (long j = 2; j < i; j++)
                {
                    if (i%j != 0 && i != j)
                    {
                        isPrime = true;
                    }
                    else
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Clear();
                    ans += i;
                    Console.WriteLine(ans);
                }

            }
            Console.ReadLine();
        }
    }
}
