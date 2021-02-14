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
            int[] arr = new int [] { 1,2,3,4,5,67,4,2,1 };

            int duplicate = 0;

            for(int i = 0 ; i<arr.Length; i++)

            {
                for(int j = i + 1; j<arr.Length; j++)

                {
                    if (arr[i] == arr[j])

                        duplicate++;
                        
                }

               

            }

            Console.WriteLine("Duplicate element{ }"," " duplicate);
            Console.ReadKey();

        }
    }
}
