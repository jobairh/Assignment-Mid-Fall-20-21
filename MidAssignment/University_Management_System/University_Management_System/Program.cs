using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("CSE", 10001);
            Course c1 = new Course("OOP2", 1102);
            Course c2 = new Course("Data communication", 1204);
            Course c3 = new Course("c++", 1307);
            Course c4 = new Course("compiler design", 1590);
            Course c5 = new Course("Digital Electronics", 1807);
            Course c6 = new Course("ELECTRICAL CIRCUITS 1", 1201);
            Course c7 = new Course("ELECTRICAL CIRCUITS 2", 1202);

            d1.AddCourse(c1);
            d1.AddCourse(c2);
            d1.AddCourse(c3);
            d1.AddCourse(c4);
            d1.ShowInfo();

            Console.WriteLine("-----------");
            Department d2 = new Department("EEE", 20001);
            d2.AddCourse(c5);
            d2.AddCourse(c6);
            d2.AddCourse(c7);
            d2.ShowInfo();

            Faculty f1 = new Faculty("Tanvir ahmed", 20.00, "CSE");
            f1.ShowInfo();

        }
    }
}
