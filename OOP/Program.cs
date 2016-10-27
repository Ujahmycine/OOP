using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name("Vardy","Jamie","Onaga");
            Department department = new Department("Agric Science");
            Student chisom = new Student(name,department);

            Console.WriteLine(chisom.StudentName.Fullname);
            Console.WriteLine(chisom.StudentName.Initials);
            Console.ReadKey();
        }
    }
}
