using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_3
{
    class Student
    {

        private String name;
        private String id;
        private String deparment;
        private float cgpa;


        public Student(String name, String id, String deparment, float cgpa)

        {
            this.name = name;
            this.id = id;
            this.deparment = deparment;
            this.cgpa = cgpa;
        }

        public void ShowInfo()

        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Id :" + id);
            Console.WriteLine("Deparment :" + deparment);
            Console.WriteLine("Cgpa :" + cgpa);

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Department
        {
            get { return deparment; }
            set { deparment = value; }
        }

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
    }
}
