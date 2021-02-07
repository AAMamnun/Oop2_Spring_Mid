using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(String[] args)
        {
            Triangle t = new Triangle(6, 3, 8);
            t.showInfo();

            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}

