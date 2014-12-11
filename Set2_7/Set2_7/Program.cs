using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Set2_7
{
    class Program
    {
        static void Main(string[] args)
        {
           int count=0,num=2,j,isprime=1;
           
            while(count<10001)
            {
                num++;
               for(j=2;j<num/2;j++)
               {
                  
                    if (num%j == 0)
                    {
                        
                        isprime = 0;
                        break;
                    }
                    else
                    {
                        isprime = 1;
                    }
                }
                if (isprime == 1)
                {
                    count++;
                }
               
            }
          
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
