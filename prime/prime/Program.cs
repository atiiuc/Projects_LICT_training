using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFound = false;
            bool isPrime = false;
            int limit = 10001;
            int count = 0;
            int val = 1;
            while (isFound == false)
            {
                if (val == 2)
                {
                    count++;
                }
                else
                {
                    for (int i = 2; i < val; i++)
                    {
                        if (val % i != 0 && val != i)
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
                        count++;
                        if (count == limit)
                        {
                            Console.WriteLine("The" + limit + " th prime number is : " + val);
                        }
                    }
                }
                val++;
            }
            Console.ReadLine();

        }
    }
}
