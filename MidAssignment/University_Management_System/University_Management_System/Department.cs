using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private int numberofcourses = 0;
        Course[] courselist = new Course[50];
        private string v;

        public Department() { }

        public Department(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public Department(string v)
        {
            this.v = v;
        }

        public void AddCourse(Course coursename)
        {
            this.courselist[numberofcourses] = coursename;
            numberofcourses++;
        }
        public void ShowInfo()
        {
            Console.WriteLine("department name: " + this.Name);
            Console.WriteLine("department id: " + this.Id);
            Console.WriteLine("course list: ");

            for (int i = 0; i < numberofcourses; i++)
            {
                Console.WriteLine(courselist[i].Name);

            }
        }
    }
}
