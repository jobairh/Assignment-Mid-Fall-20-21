using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Course
    {
        public string Name { get; set; }
        public int Id { get; set; }

        private int numberofsections = 0;
        Section[] sectionlist = new Section[50];

        public Course() { }
        public Course(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public void AddSection(Section sectionname)
        {
            this.sectionlist[numberofsections] = sectionname;
            numberofsections++;
        }
        public void ShowInfo()
        {
            Console.WriteLine("course name: " + this.Name);
            Console.WriteLine("course id: " + this.Id);
            Console.WriteLine("section list: ");

            for(int i = 0; i < numberofsections; i++)
            {
                Console.WriteLine(sectionlist[i].Name);
            }

        }

    }
}
