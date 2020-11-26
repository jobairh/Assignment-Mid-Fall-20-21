using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Faculty
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public double WorkingHour { get; set; }

        Department Dept;

        private int numofsections = 0;
        Section[] sectionlist = new Section[10];
        private string v1;
        private double v2;
        private string v3;

        public Faculty() { }

        public Faculty(string name, int id, double workinghr, Department dept) 
        {
            this.Name = name;
            this.Id = id;

            this.WorkingHour = workinghr;
            this.Dept = dept;
        }

        public Faculty(string v1, double v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void AddToSection(Section sec)
        {
            if (WorkingHour < 21)
            {
                this.sectionlist[numofsections] = sec;
                numofsections++;
                WorkingHour += 3;
            }
            else
            {
                Console.WriteLine("faculty has already 21 hours of working time");
                Console.WriteLine("you can't be added to new section!");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("faculty name:" + this.Name);
            Console.WriteLine("faculty Id:" + this.Id);
            Console.WriteLine("faculty department:" + this.Dept);
            Console.WriteLine("faculty working hour:" + this.WorkingHour);
            Console.WriteLine("section list:" + this.numofsections);
            for(int i=0; i< numofsections; i++)
            {
                Console.WriteLine(sectionlist[i].Name);
            }
        }
        
    }
}
