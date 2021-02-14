using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrCopy = new int[arr.Length];

            for(int i = 0;i<arr.Length;i++)

            {
                arrCopy[i] = arr[i];
            }

            for(int i= 0; i<arrCopy.Length; i++)
            {
                Console.WriteLine(arrCopy[i] + " ");
                Console.ReadKey();
            }
        }
    }
}
