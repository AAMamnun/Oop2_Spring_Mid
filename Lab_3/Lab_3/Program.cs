using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Triangle
    {
        private int x, y, z;

        public Triangle(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void showInfo()

        {
            Console.WriteLine("line number one "+ x);
            Console.WriteLine("line number two "+ y);
            Console.WriteLine("line number three "+ z);

            Console.WriteLine (TestTriangle());

        }
        private string TestTriangle()

        {
            if (x == y && y == z)
            {
                return "This is an equilateral triagle";
            }
            
                else if (x == y || x == z || y == z )
            {
                return "This is an isosceles triangle";
            }
            else
            {
                return "This is an scalene triangle";
            }
        }

        public int  X
        {
            get { return x; }
            set { x = value; }
        }
         public int Y
        {
            get { return y; }
            set { x = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
            
        }
    }
}
