﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Task
    {

        static void Main(string[] args)
        {
            int number = 100;
            for (int i = 0; i<=number; i++)
            {
                if (i % 2 == 0)

                    Console.WriteLine(i);
            }

        }
        Console.ReadKey();
    }
}

