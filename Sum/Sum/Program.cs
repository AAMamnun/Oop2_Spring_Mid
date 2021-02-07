using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Task

    {
        static void Main(string[] args)
        {
            int i, sum = 0;

            for (i = 1; i <= 100; i++)
            {
                sum = sum + i;
                Console.WriteLine("{0}", i);

            }
            Console.ReadKey();
        }
  
    }
}
