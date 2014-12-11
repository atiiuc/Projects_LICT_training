using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_3
{
    class Program
    {
        private static void Main(string[] args)
        {
            ulong n = 600851475143;
            ulong i = 1;
            ulong result,how;
            while (n != 1)
            {
                i++;
                how = 0;
                while (n % i == 0)
                {
                    n /= i;
                }
            }
            result = i;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
