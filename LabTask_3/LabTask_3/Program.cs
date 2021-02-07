using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student("Abdullah Mamnun", "18-38257-2", "CSE", (float)3.44);
            s.Name = "Mamnun";
            s.ShowInfo();

            Console.ReadKey();
        }
    }
}
