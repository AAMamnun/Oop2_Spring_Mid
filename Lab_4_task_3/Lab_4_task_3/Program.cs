using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4,5,1,2 };

            int single = 0;

            for (int i = 0; i < arr.Length; i++)

            {
                for (int j = i + 1; j < arr.Length; j++)

                {
                    if (arr[i]  == arr[j])

                        single++;

                }



            }

            Console.WriteLine("Single element{0}", single);
            Console.ReadKey();

        }
    }
}
