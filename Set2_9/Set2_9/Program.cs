using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1000;
            for (int i = 1; i <= total; i++)
            {
                for (int j = 1; j <= total; j++)
                {
                    int k = total - i - j;
                    int res = (i * i) + (j * j) + (k * k);
                    int r = i + j + k;

                    int left = (i * i) + (j * j);
                    int right = (k * k);

                    if (left == right && i < j && j < k)
                    {
                        Console.WriteLine(i + " " + j + " " + k);
                        Console.WriteLine(Math.Pow(i, 2) + " " + Math.Pow(j, 2) + " " + Math.Pow(k, 2));
                        Console.WriteLine(i * j * k);
                        Console.WriteLine("---------------------");
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
